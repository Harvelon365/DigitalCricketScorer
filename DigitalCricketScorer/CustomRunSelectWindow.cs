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
    /// Window used to allow the user to input a custom amount of runs scored
    /// </summary>
    public partial class CustomRunSelectWindow : Form
    {
        public int amountOfRuns { get; set; }

        public CustomRunSelectWindow()
        {
            InitializeComponent();
        }

        private void CustomRunSelectWindow_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        // Validates that the amount entered by the user is valid and, if correct, exits the window
        private void ChooseAmountButton_click(object sender, EventArgs e)
        {
            int num;
            if (!int.TryParse(runAmountTexbox.Text, out num))
            {
                MessageBox.Show("Please enter a positive integer!", "Run Count", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (num > 0)
            {
                DialogResult = DialogResult.OK;
                amountOfRuns = num;
                Close();
            }
            else
            {
                MessageBox.Show("Please enter a positive integer!", "Run Count", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
