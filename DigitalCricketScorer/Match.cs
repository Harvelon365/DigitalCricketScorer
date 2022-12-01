using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalCricketScorer
{
    /// <summary>
    /// Class that holds the data about the current match which may change over its duration
    /// </summary>
    public class Match
    {
        public string ballString { get; set; }
        public Team homeTeam { private set; get; }
        public Team awayTeam { private set; get; }
        public MatchTeam homeMatchTeam { get; set; } = new MatchTeam();
        public MatchTeam awayMatchTeam { get; set; } = new MatchTeam();
        public DateTime matchDate { private set; get; }
        public bool tossWonByHome { private set; get; }
        public bool homeBattingFirst { private set; get; }
        public bool homeCurrentlyBatting { private set; get; }
        private decimal _currentOver;
        public decimal currentOver
        {
            get
            {
                return _currentOver;
            }
            set
            {
                _currentOver = value;
                oversRemaining = 20 - currentOver - 0.4m;
            }
        }
        public decimal oversRemaining;
        public int currentBatsmanId;
        public int currentBowlerId;

        public Match(int homeID, int awayID, DateTime mDate, bool tossWonByH, bool hBattingFirst)
        {
            homeTeam = SQLUtils.LoadTeam(homeID);
            awayTeam = SQLUtils.LoadTeam(awayID);
            matchDate = mDate;
            tossWonByHome = tossWonByH;
            homeBattingFirst = hBattingFirst;

            homeCurrentlyBatting = homeBattingFirst;

        }

        // Opens a SelectPlayerWindow to allow a user to select a batsman for a match
        public MatchPlayer SelectBatsman()
        {
            MatchPlayer tempPlayer = null;
            using (SelectPlayerWindow selectPlayerWindow = new SelectPlayerWindow(homeCurrentlyBatting ? homeTeam : awayTeam, "Select a Batsman"))
            {
                if (selectPlayerWindow.ShowDialog() == DialogResult.OK)
                {
                    tempPlayer = selectPlayerWindow.selectedPlayer;
                }
            }
            tempPlayer.isValid = false;
            return tempPlayer;
        }

        // Opens a SelectPlayerWindow to allow a user to select a bowler for a match
        public MatchPlayer SelectBowler()
        {
            MatchPlayer tempPlayer = null;
            using (SelectPlayerWindow selectPlayerWindow = new SelectPlayerWindow(homeCurrentlyBatting ? awayTeam : homeTeam, "Select a Bowler"))
            {
                if (selectPlayerWindow.ShowDialog() == DialogResult.OK)
                {
                    tempPlayer = selectPlayerWindow.selectedPlayer;
                }
            }
            tempPlayer.isValid = false;
            return tempPlayer;
        }

        // Checks if both teams' innings have been complete and either ends the match or starts the second innings
        public bool EndInnings(ScorerWindow main)
        {
            MessageBox.Show("Innings Finished!\n" + (homeCurrentlyBatting ? homeTeam.name : awayTeam.name) + "\n" + (homeCurrentlyBatting ? homeMatchTeam.runCount + "/" + homeMatchTeam.wicketCount : awayMatchTeam.runCount + "/" + awayMatchTeam.wicketCount), "Innings Finished", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if ((homeBattingFirst && homeCurrentlyBatting) || (!homeBattingFirst && !homeCurrentlyBatting))
            {
                ballString += "I|";
                homeCurrentlyBatting = !homeCurrentlyBatting;
                foreach (MatchPlayer p in homeTeam.players)
                {
                    p.isValid = true;
                }
                foreach (MatchPlayer p in awayTeam.players)
                {
                    p.isValid = true;
                }
                currentOver = 0m;
                return true;
            }
            else
            {
                ballString += "I|";
                SQLUtils.SaveMatchData(this);
                new MatchWindow(this, true).Show();
                main.Hide();
                return false;
            }
        }
    }
}
