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
    /// <summary>
    /// Window to display a fully overview of all data relating to the specific match
    /// Showing Ball-By-Ball summary, scores, players in the teams, toss outcome
    /// </summary>
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

        // Loads all the data into their respective elements in the window
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

        // Set the column width in the player displays
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

        // Interprets the ball string from a match into a readble format
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
                    case "O": // O repersents the start of an Over
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

                    case "W": // W represents a Wicket event
                        overString += "W, ";
                        wicketsStringList.Add("        " + matchPlayers[int.Parse(splitball[1])].batsmanStats.batsmanName + " was " + (WicketMethod)int.Parse(splitball[2]) + " for " + matchPlayers[int.Parse(splitball[1])].batsmanStats.runsScored);
                        break;
                    case "R": // R represents an amount of Runs scored
                        if (int.Parse(splitball[1]) > 0) overString += splitball[1] + ", ";
                        else overString += "·, ";
                        break;

                    case "NB": // NB represents a No Ball event
                        overString += "nb, ";
                        break;
                    case "WI": // WI represents a Wide event
                        overString += "w, ";
                        break;
                    case "LB": // LB represents a Leg Bye event
                        overString += splitball[1] + "lb, ";
                        break;
                    case "BB": // BB represents a Bye event
                        overString += splitball[1] + "b, ";
                        break;

                    case "I": // I represents the end of an Innings
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

        // Opens a window to display away player stats when clicked
        private void awayTeamPlayerList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable playerData = SQLUtils.ExecuteSQL("SELECT * FROM tbl_Player WHERE PlayerID = " + awayTeamPlayerList.Rows[e.RowIndex].Cells[0].Value);
            new PlayerWindow(playerData).Show();
        }

        // Opens a window to display home player stats when clicked
        private void homeTeamPlayerList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable playerData = SQLUtils.ExecuteSQL("SELECT * FROM tbl_Player WHERE PlayerID = " + homeTeamPlayerList.Rows[e.RowIndex].Cells[0].Value);
            new PlayerWindow(playerData).Show();
        }
    }
}
