﻿using System;
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
    public partial class SetupWindow
    {
        private DataTable teamData;

        public SetupWindow()
        {
            InitializeComponent();
        }

        private void SetupWindow_Load(object sender, EventArgs e)
        {
            SQLUtils.CreateDatabase();

            GetTeams();
        }

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

            // TODO check if date already exists in database

            bool hBattingFirst = (tossWonDropDown.SelectedIndex == 0 && tossChoiceDropDown.SelectedIndex == 0) || (tossWonDropDown.SelectedIndex == 1 && tossChoiceDropDown.SelectedIndex == 1);

            Match currentMatch = new Match((int)teamData.Rows[homeTeamDropDown.SelectedIndex][0], (int)teamData.Rows[awayTeamDropDown.SelectedIndex][0], matchDateCalendar.SelectionStart.Date, tossWonDropDown.SelectedIndex == 0, hBattingFirst);
            new ScorerWindow(currentMatch).Show();
            Hide();
        }

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

        private void setupWindowTabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            GetTeams();
        }

        private void findMatchButton_Click(object sender, EventArgs e)
        {
            DataTable matchData = SQLUtils.ExecuteSQL("SELECT * FROM tbl_Match WHERE MatchDay == " + findMatchCalendar.SelectionStart.Date.ToShortDateString());
            if (matchData == null) MessageBox.Show("No match found!", "Match Finding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
            //TODO convert from datatable into match class and open match info window
        }

        // TODO add tabs for adding new teams and players
        // TODO add button to open player and match records drawn from database
    }
}
