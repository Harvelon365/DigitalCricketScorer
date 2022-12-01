using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalCricketScorer
{
    /// <summary>
    /// This is the first window that opens in the program
    /// It allows the user to: Start a match, Create new players and teams and View old matches, players and teams
    /// </summary>
    public partial class SetupWindow
    {
        private DataTable teamData { get; set; }

        public SetupWindow()
        {
            InitializeComponent();
        }

        private void SetupWindow_Load(object sender, EventArgs e)
        {
            SQLUtils.CreateDatabase();

            GetTeams();
        }

        // Gets the names of the teams from the database and displays them in the dropdown menu
        private void GetTeams()
        {
            teamData = SQLUtils.ExecuteSQL("SELECT * FROM tbl_Team");
            homeTeamDropDown.Items.Clear();
            awayTeamDropDown.Items.Clear();
            playerTeamDropdown.Items.Clear();

            foreach (DataRow row in teamData.Rows)
            {
                homeTeamDropDown.Items.Add(row[1]);
                awayTeamDropDown.Items.Add(row[1]);
                playerTeamDropdown.Items.Add(row[1]);
            }
        }

        // Validates all data input by the user and, if correct, starts the match
        private void beginButton_Click(object sender, EventArgs e)
        {
            if (homeTeamDropDown.SelectedIndex == awayTeamDropDown.SelectedIndex)
            {
                MessageBox.Show("The home and away teams must not be the same!", "Match Creation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (homeTeamDropDown.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a valid home team!", "Match Creation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (awayTeamDropDown.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a valid away team!", "Match Creation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (tossWonDropDown.SelectedIndex == -1 || tossChoiceDropDown.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the toss outcome!", "Match Creation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (SQLUtils.ExecuteSQL("SELECT MatchDay FROM tbl_Match WHERE MatchDay = #" + matchDateCalendar.SelectionStart.Date.ToString("yyyy/MM/dd") + "#").Rows.Count > 0)
            {
                MessageBox.Show("Match date overlap! Please select a new date!", "Match Creation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            bool hBattingFirst = (tossWonDropDown.SelectedIndex == 0 && tossChoiceDropDown.SelectedIndex == 0) || (tossWonDropDown.SelectedIndex == 1 && tossChoiceDropDown.SelectedIndex == 1);

            Match currentMatch = new Match((int)teamData.Rows[homeTeamDropDown.SelectedIndex][0], (int)teamData.Rows[awayTeamDropDown.SelectedIndex][0], matchDateCalendar.SelectionStart.Date, tossWonDropDown.SelectedIndex == 0, hBattingFirst);
            new ScorerWindow(currentMatch).Show();
            Hide();
        }

        // Validates all data input by the user and, if correct, creates a new player
        private void addPlayerButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(playerFirstNameTextbox.Text))
            {
                MessageBox.Show("Please enter a first name!", "Player Creation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(playerSurnameTextbox.Text))
            {
                MessageBox.Show("Please enter a surname!", "Player Creation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (playerTeamDropdown.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a team!", "Player Creation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            SQLUtils.ExecuteSQL("INSERT INTO tbl_Player (FirstName, Surname, TeamID) VALUES ('" + playerFirstNameTextbox.Text + "', '" + playerSurnameTextbox.Text + "', " + (int)teamData.Rows[playerTeamDropdown.SelectedIndex][0] + ")");
            MessageBox.Show("Player created!", "Player Creation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            playerTeamDropdown.SelectedIndex = -1;
            playerSurnameTextbox.Text = null;
            playerFirstNameTextbox.Text = null;
        }

        // Validates all data input by the user and, if correct, creates a new team
        private void addTeamButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(teamNameTextbox.Text))
            {
                MessageBox.Show("Please enter a team name!", "Team Creation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            SQLUtils.ExecuteSQL("INSERT INTO tbl_Team (Name) VALUES ('" + teamNameTextbox.Text + "')");
            MessageBox.Show("Team created!", "Team Creation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            teamNameTextbox.Text = null;
        }

        // Refreshes team lists when tab is changed
        private void setupWindowTabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            GetTeams();
        }

        // Gets the match from the database for the date selected by the user and displays the data in a window
        private void findMatchButton_Click(object sender, EventArgs e)
        {
            DataTable matchData = SQLUtils.ExecuteSQL("SELECT * FROM tbl_Match WHERE MatchDay = #" + findMatchCalendar.SelectionStart.Date.ToString("yyyy/MM/dd") + "#");
            if (matchData.Rows.Count == 0)
            {
                MessageBox.Show("No match found!", "Match Finding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            DataRow row = matchData.Rows[0];
            bool homebattingfirst;
            if ((bool)row[10] && (bool)row[11] || !(bool)row[10] && !(bool)row[11]) homebattingfirst = true;
            else homebattingfirst = false;
            Match viewingMatch = new Match((int)row[2], (int)row[6], (DateTime)row[1], (bool)row[10], homebattingfirst)
            {
                ballString = row[12].ToString(),
                homeMatchTeam = new MatchTeam { runCount = (int)row[3], wicketCount = (int)row[4] },
                awayMatchTeam = new MatchTeam { runCount = (int)row[7], wicketCount = (int)row[8] },
            };

            new MatchWindow(viewingMatch, false).Show();
        }

        // Gets the list of players from the database for the name input by the user and displays the output
        private void searchPlayerButton_Click(object sender, EventArgs e)
        {
            DataTable playerReturnData = SQLUtils.ExecuteSQL("SELECT PlayerID, FirstName, Surname FROM tbl_Player WHERE FirstName LIKE '%" + playerSearchFirstnameTextbox.Text + "%' AND Surname LIKE '%" + playerSearchSurnameTextbox.Text + "%'");
            if (playerReturnData.Rows.Count == 0)
            {
                MessageBox.Show("No players found!", "Player Finding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (playerSortModeBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a sort mode!", "Player Finding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            playerSearchReturnList.DataSource = SQLUtils.BubbleSort(playerReturnData, playerSortModeBox.SelectedIndex);
        }

        // Opens information about a player if their name is clicked
        private void playerSearchReturnList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable playerData = SQLUtils.ExecuteSQL("SELECT * FROM tbl_Player WHERE PlayerID = " + playerSearchReturnList.Rows[e.RowIndex].Cells[0].Value);
            new PlayerWindow(playerData).Show();
        }

        // Gets the list of teams from the database for the name input by the user and displays the output
        private void teamSearchButton_Click(object sender, EventArgs e)
        {
            DataTable teamReturnData = SQLUtils.ExecuteSQL("SELECT * FROM tbl_Team WHERE Name LIKE '%" + teamSearchNameTextbox.Text + "%'");
            if (teamReturnData.Rows.Count == 0)
            {
                MessageBox.Show("No teams found!", "Team Finding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (teamSortModeBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a sort mode!", "Team Finding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            teamSearchReturnList.DataSource = SQLUtils.BubbleSort(teamReturnData, teamSortModeBox.SelectedIndex);
        }

        // Opens information about a team if their name is clicked
        private void teamSearchReturnList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable teamData = SQLUtils.ExecuteSQL("SELECT * FROM tbl_Team WHERE TeamID = " + teamSearchReturnList.Rows[e.RowIndex].Cells[0].Value);
            new TeamWindow(teamData).Show();
        }
    }
}
