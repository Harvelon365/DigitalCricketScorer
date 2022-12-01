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
    /// Window that displays a loading bar to show the progress of data saving at the end of a match
    /// </summary>
    public partial class SavingProgressBar : Form
    {
        public SavingProgressBar()
        {
            InitializeComponent();
        }

        public void UpdateProgress(string sectionName)
        {
            savingDataProgressBar.Value += 25;
            savingDataLabel.Text = sectionName;
            this.Update();
        }
    }
}
