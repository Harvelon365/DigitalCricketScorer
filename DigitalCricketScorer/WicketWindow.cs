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
    /// Window that is opened when a user declares that a wicket has occured
    /// </summary>
    public partial class WicketWindow : Form
    {
        private List<MatchPlayer> playersToShow = new List<MatchPlayer>();
        public MatchPlayer selectedPlayer { get; set; }
        public WicketMethod method;

        public WicketWindow(List<MatchPlayer> players)
        {
            playersToShow = players;
            InitializeComponent();
        }

        // Loads the players and wicket methods into their dropdowns
        private void WicketWindow_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            foreach (MatchPlayer p in playersToShow)
            {
                playerSelectDropDown.Items.Add(p.firstName + " " + p.surname);
            }
            wicketSelectDropDown.DataSource = Enum.GetValues(typeof(WicketMethod));
        }

        // Validates the choices from the user and, if correct, exits the window
        private void makeSelectionButton_Click(object sender, EventArgs e)
        {
            if (playerSelectDropDown.SelectedIndex != -1)
            {
                DialogResult = DialogResult.OK;
                selectedPlayer = playersToShow[playerSelectDropDown.SelectedIndex];
                Enum.TryParse(wicketSelectDropDown.SelectedValue.ToString(), out method);
                Close();
            }
            else
            {
                MessageBox.Show("Please select a valid player!", "Player Selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }

    // Enum listing all the methods of how a player can get out
    public enum WicketMethod
    {
        Run = 1,
        Caught = 2,
        Stumped = 4,
        LBW = 8,
        Bowled = 16,
        Retired = 32,
        Other = 64
    }
}
