using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalCricketScorer
{
    public partial class ScorerWindow : Form
    {
        private Match currentMatch;
        private BindingList<BatsmanStats> batsmanStats = new BindingList<BatsmanStats>();
        private BindingList<BowlerStats> bowlerStats = new BindingList<BowlerStats>();
        private BindingList<BatsmanStats> facingBatsmanStats = new BindingList<BatsmanStats>();
        private BindingList<BowlerStats> facingBowlerStats = new BindingList<BowlerStats>();
        private bool enableWinPredictor;

        public ScorerWindow(Match currentMatch)
        {
            this.currentMatch = currentMatch;
            MessageBox.Show("Match Created!\n" + currentMatch.homeTeam.name + " vs " + currentMatch.awayTeam.name + "\n" + currentMatch.matchDate.ToShortDateString(), "Match Creation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(WindowClosed);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            facingBatsmenGrid.Enabled = false;
            facingBowlerGrid.Enabled = false;
            batsmanDataGrid.Enabled = false;
            bowlerDataGrid.Enabled = false;

            facingBatsmenGrid.DataSource = facingBatsmanStats;
            facingBowlerGrid.DataSource = facingBowlerStats;
            batsmanDataGrid.DataSource = batsmanStats;
            bowlerDataGrid.DataSource = bowlerStats;

            UpdateScoreTexts();
        }

        private void SetupScorerWindow(object sender = null, EventArgs e = null)
        {
            facingBatsmanStats.Clear();
            facingBowlerStats.Clear();
            bowlerStats.Clear();
            batsmanStats.Clear();

            if ((currentMatch.homeBattingFirst && !currentMatch.homeCurrentlyBatting) || (!currentMatch.homeBattingFirst && currentMatch.homeCurrentlyBatting))
            {
                enableWinPredictor = true;
                winPredictorPanel.Visible = true;
            }
            else
            {
                enableWinPredictor = false;
                winPredictorPanel.Visible = false;
            }

            facingBatsmanStats.Add(currentMatch.SelectBatsman().batsmanStats);
            facingBatsmanStats.Add(currentMatch.SelectBatsman().batsmanStats);
            facingBowlerStats.Add(currentMatch.SelectBowler().bowlerStats);
            currentMatch.currentBowlerId = facingBowlerStats[0].player.Id;
            currentMatch.currentBatsmanId = facingBatsmanStats[0].player.Id;

            currentMatch.ballString += "O/" + facingBatsmanStats[0].player.Id + "/" + facingBatsmanStats[1].player.Id + "/" + currentMatch.currentBowlerId + "|";

            UpdateScoreTexts();
            SelectAllGridRows();
        }

        private void WindowClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void UpdateScoreTexts()
        {
            if (currentMatch.homeCurrentlyBatting)
            {
                battingTeamLabel.Text = currentMatch.homeTeam.name + "    " + currentMatch.homeMatchTeam.runCount + "-" + currentMatch.homeMatchTeam.wicketCount;
                bowlingTeamLabel.Text = currentMatch.awayTeam.name + "    " + currentMatch.awayMatchTeam.runCount + "-" + currentMatch.awayMatchTeam.wicketCount;
            }
            else
            {
                battingTeamLabel.Text = currentMatch.awayTeam.name + "    " + currentMatch.awayMatchTeam.runCount + "-" + currentMatch.awayMatchTeam.wicketCount;
                bowlingTeamLabel.Text = currentMatch.homeTeam.name + "    " + currentMatch.homeMatchTeam.runCount + "-" + currentMatch.homeMatchTeam.wicketCount;
            }

            currentOverLabel.Text = "Current Over: " + currentMatch.currentOver;
            oversRemainingLabel.Text = "Overs Left: " + currentMatch.oversRemaining;

            Extras teamExtras = currentMatch.homeCurrentlyBatting ? currentMatch.homeMatchTeam.extras : currentMatch.awayMatchTeam.extras;
            extrasLabel.Text = teamExtras.wide + "w " + teamExtras.noBall + "nb " + teamExtras.bye + "b " + teamExtras.legBye + "lb";

            if (enableWinPredictor && currentMatch.currentOver != 0)
            {
                bool secondTeamWin = CalculateWin(currentMatch.homeCurrentlyBatting ? currentMatch.awayMatchTeam : currentMatch.homeMatchTeam, currentMatch.homeCurrentlyBatting ? currentMatch.homeMatchTeam : currentMatch.awayMatchTeam);
            
                if (currentMatch.homeCurrentlyBatting)
                {
                    winPredictorResultLabel.Text = (secondTeamWin ? currentMatch.homeTeam.name : currentMatch.awayTeam.name) + " are likely to win";
                }
                else
                {
                    winPredictorResultLabel.Text = (secondTeamWin ? currentMatch.awayTeam.name : currentMatch.homeTeam.name) + " are likely to win";
                }
            }
        }

        private bool CalculateWin(MatchTeam firstTeam, MatchTeam secondTeam)
        {
            decimal firstTeamRunsPerOver = firstTeam.runCount / 20m;
            Console.WriteLine("1st: " + firstTeamRunsPerOver);
            decimal secondTeamRunsPerOver = secondTeam.runCount / ((currentMatch.currentOver % 1 * 10 / 6) + (currentMatch.currentOver - (currentMatch.currentOver % 1)));
            Console.WriteLine("2nd: " + secondTeamRunsPerOver);
            if (secondTeamRunsPerOver > firstTeamRunsPerOver|| secondTeam.runCount > firstTeam.runCount) return true;
            else return false;
        }

        private void SelectGridRow(DataGridView grid, int rowIndex, int highlightType)
        {
            for (int i = 0; i < grid.RowCount; i++)
            {
                if (i == rowIndex)
                {
                    switch (highlightType)
                    {
                        case 0:
                            grid.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(61, 66, 76);
                            grid.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                            break;
                        
                        case 1:
                            grid.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(169, 169, 169);
                            break;
                    }
                }
            }
        }

        private void SelectAllGridRows()
        {
            SelectGridRow(facingBatsmenGrid, facingBatsmanStats.IndexOf(facingBatsmanStats.SingleOrDefault(x => x.player.Id == currentMatch.currentBatsmanId)), 0);
            SelectGridRow(batsmanDataGrid, batsmanStats.IndexOf(batsmanStats.SingleOrDefault(x => x.player.Id == currentMatch.currentBatsmanId)), 0);
            
            SelectGridRow(batsmanDataGrid, batsmanStats.IndexOf(batsmanStats.SingleOrDefault(x => x.player.isOut)), 1);
            SelectGridRow(bowlerDataGrid, bowlerStats.IndexOf(bowlerStats.SingleOrDefault(x => x.player.isOut)), 1);
            
            SelectGridRow(facingBowlerGrid, facingBowlerStats.IndexOf(facingBowlerStats.SingleOrDefault(x => x.player.Id == currentMatch.currentBowlerId)), 0);
            SelectGridRow(bowlerDataGrid, bowlerStats.IndexOf(facingBowlerStats.SingleOrDefault(x => x.player.Id == currentMatch.currentBowlerId)), 0);
        }

        private void NewRun(int runCount, bool stopSwap = false)
        {
            if (!stopSwap) currentMatch.ballString += runCount + "/" + currentMatch.currentBatsmanId + "|";
            currentMatch.currentOver += 0.1m;

            if (currentMatch.homeCurrentlyBatting) currentMatch.homeMatchTeam.runCount += runCount;
            else { currentMatch.awayMatchTeam.runCount += runCount; }

            BatsmanStats bat = GetCurrentBatsman();
            bat.runsScored += runCount;
            if (runCount == 4) bat.fours++;
            if (runCount == 6) bat.sixes++;
            if (runCount % 2 != 0 && !stopSwap) SwapBatsmen();
            bat.balls++;

            facingBowlerStats[0].runsConceded += runCount;
            if (currentMatch.currentOver % 1 == 0.6m) facingBowlerStats[0].overs += 0.5m;
            else facingBowlerStats[0].overs += 0.1m;

            UpdateScoreTexts();
            if (currentMatch.currentOver % 1 == 0.6m) StartNewOver();
            if (currentMatch.currentOver % 1 == 0.6m) currentMatch.currentOver += 0.4m;
            UpdateScoreTexts();

            SelectAllGridRows();
        }

        private void SwapBatsmen()
        {
            foreach (BatsmanStats bat in facingBatsmanStats)
            {
                if (bat.player.Id == currentMatch.currentBatsmanId)
                {
                    currentMatch.currentBatsmanId = facingBatsmanStats.IndexOf(bat) == 0 ? facingBatsmanStats[1].player.Id : facingBatsmanStats[0].player.Id;
                    break;
                }
            }
        }

        private void StartNewOver()
        {
            string[] overs = currentMatch.ballString.Split('O');
            overs = overs.Last().Split('|');
            int totalThisOver = 0;
            for (int i = 0; i < overs.Length; i++)
            {
                if (i == 0 || i == overs.Length - 1) continue;
                switch (overs[i].Split('/')[0])
                {
                    case ("WI"):
                    case ("NB"):
                        totalThisOver++;
                        break;

                    case ("BB"):
                    case ("LB"):
                    case ("R"):
                        totalThisOver += int.Parse(overs[i].Split('/')[1]);
                        break;

                    default:
                        break;
                }
            }
            if (totalThisOver == 0) facingBowlerStats[0].maidens++;

            if (currentMatch.currentOver == 0.6m)
            {
                if (currentMatch.EndInnings(this))
                {
                    SetupScorerWindow();
                    return;
                }
                else return;
            }

            if (facingBowlerStats[0].overs != 4) facingBowlerStats[0].player.isValid = true;
            else facingBowlerStats[0].player.isOut = true;
            facingBowlerStats.Clear();
            facingBowlerStats.Add(currentMatch.SelectBowler().bowlerStats);
            currentMatch.currentBowlerId = facingBowlerStats[0].player.Id;

            SwapBatsmen();

            currentMatch.ballString += "O/" + facingBatsmanStats[0].player.Id + "/" + facingBatsmanStats[1].player.Id + "/" + currentMatch.currentBowlerId + "|";
        }

        private void GridViewClearSelection(object sender, EventArgs e)
        {
            DataGridView grid = sender as DataGridView;
            grid.ClearSelection();
        }

        private void facingBatsmenGrid_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (batsmanStats.Contains((BatsmanStats)facingBatsmenGrid.Rows[e.RowIndex].DataBoundItem))
            {
                return;
            }
            else
            {
                batsmanStats.Add((BatsmanStats)facingBatsmenGrid.Rows[e.RowIndex].DataBoundItem);
            }
        }

        private void facingBowlerGrid_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (bowlerStats.Contains((BowlerStats)facingBowlerGrid.Rows[e.RowIndex].DataBoundItem))
            {
                return;
            }
            else
            {
                bowlerStats.Add((BowlerStats)facingBowlerGrid.Rows[e.RowIndex].DataBoundItem);
            }
        }

        private void GridViewColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;

            switch (e.Column.Name)
            {
                case "batsmanName":
                case "bowlerName":
                    e.Column.Width = 150;
                    break;
                
                case "overs":
                case "maidens":
                case "runsConceded":
                case "wickets":
                case "runsScored":
                case "balls":
                case "fours":
                case "sixes":
                    e.Column.Width = 70;
                    break;
                
                case "strikeRate":
                case "rpo":
                    e.Column.Width = 80;
                    break;
                default:
                    break;
            }
        }

        private void runButton_click(object sender, EventArgs e)
        {
            currentMatch.ballString += "R/";
            switch ((sender as Button).Name)
            {
                case "dotBallButton":
                    NewRun(0);
                    break;
                case "oneRunButton":
                    NewRun(1);
                    break;
                case "twoRunButton":
                    NewRun(2);
                    break;
                case "threeRunButton":
                    NewRun(3);
                    break;
                case "fourRunButton":
                    NewRun(4);
                    break;
                case "sixRunButton":
                    NewRun(6);
                    break;
                case "customRunButton":
                    using (CustomRunSelectWindow customRunSelectWindow = new CustomRunSelectWindow())
                    {
                        if (customRunSelectWindow.ShowDialog() == DialogResult.OK)
                        {
                            NewRun(customRunSelectWindow.amountOfRuns);
                        }
                    }
                    break;

                default:
                    break;
            }
        }

        private void wicketButton_click(object sender, EventArgs e)
        {
            MatchPlayer tempPlayer = null;
            WicketMethod method = WicketMethod.Other;
            using (WicketWindow wicketWindow = new WicketWindow(new List<MatchPlayer> { facingBatsmanStats[0].player, facingBatsmanStats[1].player}))
            {
                if (wicketWindow.ShowDialog() == DialogResult.OK)
                {
                    tempPlayer = wicketWindow.selectedPlayer;
                    method = wicketWindow.method;
                }
            }
            currentMatch.currentOver += 0.1m;
            BatsmanStats bat = GetCurrentBatsman();
            bat.balls++;

            if (currentMatch.currentOver % 1 == 0.6m) facingBowlerStats[0].overs += 0.5m;
            else facingBowlerStats[0].overs += 0.1m;

            if (currentMatch.homeCurrentlyBatting) currentMatch.homeMatchTeam.wicketCount++;
            else currentMatch.awayMatchTeam.wicketCount++;

            tempPlayer.isOut = true;
            MessageBox.Show("Wicket!\n" + tempPlayer.firstName + " " + tempPlayer.surname + "\nMethod: " + method.ToString(), "Wicket", MessageBoxButtons.OK, MessageBoxIcon.Information);
            currentMatch.ballString += "W/" + tempPlayer.Id + "/" + (int)method + "|";

            facingBatsmanStats.Remove(tempPlayer.batsmanStats);
            facingBatsmanStats.Add(currentMatch.SelectBatsman().batsmanStats);
            if (currentMatch.currentBatsmanId == tempPlayer.Id)
            {
                currentMatch.currentBatsmanId = facingBatsmanStats[1].player.Id;
            }
            facingBowlerStats[0].wickets++;

            if (currentMatch.currentOver % 1 == 0.6m) StartNewOver();
            if (currentMatch.currentOver % 1 == 0.6m) currentMatch.currentOver += 0.4m;
            UpdateScoreTexts();

            SelectAllGridRows();
        }

        private BatsmanStats GetCurrentBatsman()
        {
            foreach (BatsmanStats bat in facingBatsmanStats)
            {
                if (bat.player.Id == currentMatch.currentBatsmanId)
                {
                    return bat;
                }
            }
            return null;
        }

        private void byeBallButton_Click(object sender, EventArgs e)
        {
            using (CustomRunSelectWindow customRunSelectWindow = new CustomRunSelectWindow())
            {
                if (customRunSelectWindow.ShowDialog() == DialogResult.OK)
                {
                    BatsmanStats bat = GetCurrentBatsman();
                    bat.runsScored -= customRunSelectWindow.amountOfRuns;
                    if (currentMatch.homeCurrentlyBatting) currentMatch.homeMatchTeam.extras.bye += customRunSelectWindow.amountOfRuns;
                    else currentMatch.awayMatchTeam.extras.bye += customRunSelectWindow.amountOfRuns;
                    currentMatch.ballString += "BB/";
                    NewRun(customRunSelectWindow.amountOfRuns);
                }
            }
        }
        
        private void legByeBallButton_Click(object sender, EventArgs e)
        {
            using (CustomRunSelectWindow customRunSelectWindow = new CustomRunSelectWindow())
            {
                if (customRunSelectWindow.ShowDialog() == DialogResult.OK)
                {
                    BatsmanStats bat = GetCurrentBatsman();
                    bat.runsScored -= customRunSelectWindow.amountOfRuns;
                    if (currentMatch.homeCurrentlyBatting) currentMatch.homeMatchTeam.extras.bye += customRunSelectWindow.amountOfRuns;
                    else currentMatch.awayMatchTeam.extras.legBye += customRunSelectWindow.amountOfRuns;
                    currentMatch.ballString += "LB/";
                    NewRun(customRunSelectWindow.amountOfRuns);
                }
            }
        }
        
        private void wideBallButton_Click(object sender, EventArgs e)
        {
            BatsmanStats bat = GetCurrentBatsman();
            bat.runsScored--;
            bat.balls--;
            facingBowlerStats[0].overs -= 0.1m;
            currentMatch.currentOver -= 0.1m;
            if (currentMatch.homeCurrentlyBatting) currentMatch.homeMatchTeam.extras.wide++;
            else currentMatch.awayMatchTeam.extras.wide++;
            currentMatch.ballString += "WI|";
            NewRun(1, true);
        }
        
        private void noBallButton_Click(object sender, EventArgs e)
        {
            BatsmanStats bat = GetCurrentBatsman();
            bat.runsScored--;
            facingBowlerStats[0].overs -= 0.1m;
            currentMatch.currentOver -= 0.1m;
            if (currentMatch.homeCurrentlyBatting) currentMatch.homeMatchTeam.extras.noBall++;
            else currentMatch.awayMatchTeam.extras.noBall++;
            currentMatch.ballString += "NB|";
            NewRun(1, true);
        }

        //TODO Add settings menu
    }
}
