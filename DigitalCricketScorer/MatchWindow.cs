using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalCricketScorer
{
    public partial class MatchWindow : Form
    {
        public Match matchToShow;
        private Dictionary<int, MatchPlayer> matchPlayers = new Dictionary<int, MatchPlayer>();
        private bool endOfMatch;

        public MatchWindow(Match match, bool _endOfMatch)
        {
            InitializeComponent();
            matchToShow = match;
            endOfMatch = _endOfMatch;
            this.FormClosed += new FormClosedEventHandler(WindowClosed);
        }
        private void WindowClosed(object sender, FormClosedEventArgs e)
        {
            if (endOfMatch)
            {
                Application.Exit();
            }
        }

        private void MatchWindow_Load(object sender, EventArgs e)
        {
            matchDateLabel.Text = matchToShow.matchDate.ToShortDateString();
            homeTeamScoreLabel.Text = matchToShow.homeTeam.name + " - " + matchToShow.homeMatchTeam.runCount + "/" + matchToShow.homeMatchTeam.wicketCount;
            awayTeamScoreLabel.Text = matchToShow.awayTeam.name + " - " + matchToShow.awayMatchTeam.runCount + "/" + matchToShow.awayMatchTeam.wicketCount;
            if (matchToShow.homeBattingFirst && matchToShow.tossWonByHome || !matchToShow.homeBattingFirst && !matchToShow.tossWonByHome)
            {
                tossOutcomelabel.Text = matchToShow.tossWonByHome ? matchToShow.homeTeam.name + " won the toss and chose to bat" : matchToShow.awayTeam.name + " won the toss and chose to bat";
            }
            else
            {
                tossOutcomelabel.Text = matchToShow.tossWonByHome ? matchToShow.homeTeam.name + " won the toss and chose to bowl" : matchToShow.awayTeam.name + " won the toss and chose to bowl";
            }
            homeTeamPlayerList.DataSource = matchToShow.homeTeam.players;
            awayTeamPlayerList.DataSource = matchToShow.awayTeam.players;

            foreach (MatchPlayer p in matchToShow.homeTeam.players)
            {
                matchPlayers.Add(p.Id, p);
            }
            foreach (MatchPlayer p in matchToShow.awayTeam.players)
            {
                matchPlayers.Add(p.Id, p);
            }

            ballByBallList.DataSource = LoadFromBallString(matchToShow.ballString);
        }

        private void GridViewColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;

            switch (e.Column.Name)
            {
                case "Id":
                    e.Column.Width = 30;
                    break;

                case "firstName":
                case "surname":
                    e.Column.Width = 110;
                    break;
            }
        }

        private List<string> LoadFromBallString(string ballString)
        {
            List<string> ballList = ballString.Split('|').ToList();
            List<string> displayList = new List<string>();
            int overCount = 0;
            int inningsCount = 0;
            string overString = " ";
            List<string> wicketsStringList = new List<string>();

            foreach (string ball in ballList)
            {
                string[] splitball = ball.Split('/');
                switch (splitball[0])
                {
                    case "O":
                        displayList.Add("    " + overString.Remove(overString.Length-1));
                        overString = "";
                        foreach (string wicket in wicketsStringList)
                        {
                            displayList.Add(wicket);
                        }
                        wicketsStringList.Clear();
                        overCount++;
                        displayList.Add("OVER " + overCount + " - Batting: " + matchPlayers[int.Parse(splitball[1])].batsmanStats.batsmanName + " and " + matchPlayers[int.Parse(splitball[2])].batsmanStats.batsmanName + " - Bowling: " + matchPlayers[int.Parse(splitball[3])].bowlerStats.bowlerName);
                        break;
                    case "W":
                        overString += "W, ";
                        wicketsStringList.Add("        " + matchPlayers[int.Parse(splitball[1])].batsmanStats.batsmanName + " was " + (WicketMethod)int.Parse(splitball[2]) + " for " + matchPlayers[int.Parse(splitball[1])].batsmanStats.runsScored);
                        break;
                    case "R":
                        if (int.Parse(splitball[1]) > 0) overString += splitball[1] + ", ";
                        else overString += "·, ";
                        break;
                    case "NB":
                        overString += "nb, ";
                        break;
                    case "WI":
                        overString += "w, ";
                        break;
                    case "LB":
                        overString += splitball[1] + "lb, ";
                        break;
                    case "BB":
                        overString += splitball[1] + "b, ";
  
                        break;
                    case "I":
                        displayList.Add("    " + overString.Remove(overString.Length-1));
                        overString = " ";
                        foreach (string wicket in wicketsStringList)
                        {
                            displayList.Add(wicket);
                        }
                        wicketsStringList.Clear();
                        overCount = 0;
                        inningsCount++;
                        if (inningsCount == 1)
                        {
                            displayList.Add("----------------------------------------------------------");
                            displayList.Add("------------FIRST INNINGS COMPLETE------------");
                            displayList.Add("----------------------------------------------------------");
                        }
                        else
                        {
                            displayList.Add("----------------------------------------------------------");
                            displayList.Add("-----------SECOND INNINGS COMPLETE------------");
                            displayList.Add("----------------------------------------------------------");
                        }
                        break;
                }
            }

      
            return displayList;
        }

        private void awayTeamPlayerList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable playerData = SQLUtils.ExecuteSQL("SELECT * FROM tbl_Player WHERE PlayerID = " + awayTeamPlayerList.Rows[e.RowIndex].Cells[0].Value);
            new PlayerWindow(playerData).Show();
        }

        private void homeTeamPlayerList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable playerData = SQLUtils.ExecuteSQL("SELECT * FROM tbl_Player WHERE PlayerID = " + homeTeamPlayerList.Rows[e.RowIndex].Cells[0].Value);
            new PlayerWindow(playerData).Show();
        }
    }
}
