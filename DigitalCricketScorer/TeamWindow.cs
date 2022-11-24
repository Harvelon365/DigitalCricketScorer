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
    public partial class TeamWindow : Form
    {
        public TeamWindow(DataTable teamData)
        {
            InitializeComponent();

            DataRow row = teamData.Rows[0];

            teamNameLabel.Text = row[1].ToString();

            DataTable teamPlayerData = SQLUtils.ExecuteSQL("SELECT PlayerID, FirstName, Surname FROM tbl_Player WHERE TeamID = " + row[0]);
        
            teamPlayerList.DataSource = teamPlayerData;
        }

        private void teamPlayerList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable playerData = SQLUtils.ExecuteSQL("SELECT * FROM tbl_Player WHERE PlayerID = " + teamPlayerList.Rows[e.RowIndex].Cells[0].Value);
            new PlayerWindow(playerData).Show();
        }
    }
}
