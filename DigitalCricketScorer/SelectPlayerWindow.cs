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

        private void SelectPlayerWindow_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            foreach (MatchPlayer p in teamToShow.players)
            {
                playerSelectDropDown.Items.Add(p.firstName + " " + p.surname);
            }
        }

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
