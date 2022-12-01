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
    /// Window that displays all data relating to a specified player
    /// </summary>
    public partial class PlayerWindow : Form
    {
        public PlayerWindow(DataTable playerData)
        {
            InitializeComponent();

            DataRow row = playerData.Rows[0];

            playerNameLabel.Text = row[1].ToString() + " " + row[2].ToString();
            playerTeamNameLabel.Text = SQLUtils.ExecuteSQL("SELECT Name FROM tbl_Team WHERE TeamID = " + row[3].ToString()).Rows[0][0].ToString(); ;

            playerBowlStatsList.Items.Add("Runs Conceded - " + row[9]);
            playerBowlStatsList.Items.Add("Overs Bowled - " + row[10]);
            playerBowlStatsList.Items.Add("Runs Per Over - " + row[11]);
            playerBowlStatsList.Items.Add("Wickets - " + row[12]);
            playerBowlStatsList.Items.Add("Maidens - " + row[13]);
            playerBatStatsList.Items.Add("Runs Scored - " + row[4]);
            playerBatStatsList.Items.Add("Balls Faced - " + row[5]);
            playerBatStatsList.Items.Add("Strike Rate - " + row[6]);
            playerBatStatsList.Items.Add("Fours - " + row[7]);
            playerBatStatsList.Items.Add("Sixes - " + row[8]);
        }
    }
}
