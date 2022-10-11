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
    public partial class CustomRunSelectWindow : Form
    {
        public int amountOfRuns;

        public CustomRunSelectWindow()
        {
            InitializeComponent();
        }

        private void CustomRunSelectWindow_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

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
