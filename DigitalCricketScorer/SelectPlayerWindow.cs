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
    /// Window used to allow the user to select a player for use in the match
    /// </summary>
    public partial class SelectPlayerWindow : Form
    {
        private Team teamToShow;
        public MatchPlayer selectedPlayer;

        public SelectPlayerWindow(Team team, string windowTitle)
        {
            teamToShow = team;
            InitializeComponent();
            Text = windowTitle;
        }

        // Loads the players from teh specified team into the dropdown box
        private void SelectPlayerWindow_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            foreach (MatchPlayer p in teamToShow.players)
            {
                playerSelectDropDown.Items.Add(p.firstName + " " + p.surname);
            }
        }

        // Validates that the player selected is not already in user and, if correct, closes the window
        private void makeSelectionButton_Click(object sender, EventArgs e)
        {
            if (playerSelectDropDown.SelectedIndex != -1)
            {
                if (teamToShow.players[playerSelectDropDown.SelectedIndex].isValid)
                {
                    DialogResult = DialogResult.OK;
                    selectedPlayer = teamToShow.players[playerSelectDropDown.SelectedIndex];
                    teamToShow.players[playerSelectDropDown.SelectedIndex].isValid = false;
                    Close();
                }
                else
                {
                    MessageBox.Show("Player already in use!", "Player Selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Please select a valid player!", "Player Selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
