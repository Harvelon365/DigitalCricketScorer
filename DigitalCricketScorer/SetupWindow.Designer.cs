using System.Windows.Forms;

namespace DigitalCricketScorer
{
    partial class SetupWindow : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.homeTeamLabel = new System.Windows.Forms.Label();
            this.homeTeamDropDown = new System.Windows.Forms.ComboBox();
            this.awayTeamLabel = new System.Windows.Forms.Label();
            this.awayTeamDropDown = new System.Windows.Forms.ComboBox();
            this.matchDateLabel = new System.Windows.Forms.Label();
            this.matchDateCalendar = new System.Windows.Forms.MonthCalendar();
            this.beginButton = new System.Windows.Forms.Button();
            this.tossWonLabel = new System.Windows.Forms.Label();
            this.tossWonDropDown = new System.Windows.Forms.ComboBox();
            this.tossChoiceDropDown = new System.Windows.Forms.ComboBox();
            this.choiceLabel = new System.Windows.Forms.Label();
            this.setupWindowTabControl = new System.Windows.Forms.TabControl();
            this.newMatchTab = new System.Windows.Forms.TabPage();
            this.createAMatchLabel = new System.Windows.Forms.Label();
            this.addPlayerTab = new System.Windows.Forms.TabPage();
            this.addPlayerButton = new System.Windows.Forms.Button();
            this.playerTeamDropdown = new System.Windows.Forms.ComboBox();
            this.playerTeamLabel = new System.Windows.Forms.Label();
            this.playerSurnameTextbox = new System.Windows.Forms.TextBox();
            this.playerSurnameLabel = new System.Windows.Forms.Label();
            this.playerFirstNameLabel = new System.Windows.Forms.Label();
            this.playerFirstNameTextbox = new System.Windows.Forms.TextBox();
            this.createPlayerLabel = new System.Windows.Forms.Label();
            this.addTeamTab = new System.Windows.Forms.TabPage();
            this.addTeamButton = new System.Windows.Forms.Button();
            this.teamNameLabel = new System.Windows.Forms.Label();
            this.teamNameTextbox = new System.Windows.Forms.TextBox();
            this.createTeamLabel = new System.Windows.Forms.Label();
            this.findMatchTab = new System.Windows.Forms.TabPage();
            this.findTeamTab = new System.Windows.Forms.TabPage();
            this.findPlayerTab = new System.Windows.Forms.TabPage();
            this.findMatchDateLabel = new System.Windows.Forms.Label();
            this.findMatchTitle = new System.Windows.Forms.Label();
            this.findMatchCalendar = new System.Windows.Forms.MonthCalendar();
            this.findMatchButton = new System.Windows.Forms.Button();
            this.setupWindowTabControl.SuspendLayout();
            this.newMatchTab.SuspendLayout();
            this.addPlayerTab.SuspendLayout();
            this.addTeamTab.SuspendLayout();
            this.findMatchTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // homeTeamLabel
            // 
            this.homeTeamLabel.AutoSize = true;
            this.homeTeamLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeTeamLabel.Location = new System.Drawing.Point(4, 42);
            this.homeTeamLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.homeTeamLabel.Name = "homeTeamLabel";
            this.homeTeamLabel.Size = new System.Drawing.Size(86, 19);
            this.homeTeamLabel.TabIndex = 1;
            this.homeTeamLabel.Text = "Home Team";
            // 
            // homeTeamDropDown
            // 
            this.homeTeamDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.homeTeamDropDown.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeTeamDropDown.FormattingEnabled = true;
            this.homeTeamDropDown.Location = new System.Drawing.Point(8, 65);
            this.homeTeamDropDown.Margin = new System.Windows.Forms.Padding(4);
            this.homeTeamDropDown.Name = "homeTeamDropDown";
            this.homeTeamDropDown.Size = new System.Drawing.Size(696, 27);
            this.homeTeamDropDown.TabIndex = 2;
            // 
            // awayTeamLabel
            // 
            this.awayTeamLabel.AutoSize = true;
            this.awayTeamLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.awayTeamLabel.Location = new System.Drawing.Point(4, 108);
            this.awayTeamLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.awayTeamLabel.Name = "awayTeamLabel";
            this.awayTeamLabel.Size = new System.Drawing.Size(83, 19);
            this.awayTeamLabel.TabIndex = 3;
            this.awayTeamLabel.Text = "Away Team";
            // 
            // awayTeamDropDown
            // 
            this.awayTeamDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.awayTeamDropDown.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.awayTeamDropDown.FormattingEnabled = true;
            this.awayTeamDropDown.Location = new System.Drawing.Point(8, 131);
            this.awayTeamDropDown.Margin = new System.Windows.Forms.Padding(4);
            this.awayTeamDropDown.Name = "awayTeamDropDown";
            this.awayTeamDropDown.Size = new System.Drawing.Size(696, 27);
            this.awayTeamDropDown.TabIndex = 4;
            // 
            // matchDateLabel
            // 
            this.matchDateLabel.AutoSize = true;
            this.matchDateLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matchDateLabel.Location = new System.Drawing.Point(7, 249);
            this.matchDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.matchDateLabel.Name = "matchDateLabel";
            this.matchDateLabel.Size = new System.Drawing.Size(85, 19);
            this.matchDateLabel.TabIndex = 5;
            this.matchDateLabel.Text = "Match Date";
            // 
            // matchDateCalendar
            // 
            this.matchDateCalendar.Location = new System.Drawing.Point(9, 277);
            this.matchDateCalendar.MaxSelectionCount = 1;
            this.matchDateCalendar.Name = "matchDateCalendar";
            this.matchDateCalendar.TabIndex = 6;
            // 
            // beginButton
            // 
            this.beginButton.Location = new System.Drawing.Point(543, 390);
            this.beginButton.Name = "beginButton";
            this.beginButton.Size = new System.Drawing.Size(162, 55);
            this.beginButton.TabIndex = 7;
            this.beginButton.Text = "Begin Scoring";
            this.beginButton.UseVisualStyleBackColor = true;
            this.beginButton.Click += new System.EventHandler(this.beginButton_Click);
            // 
            // tossWonLabel
            // 
            this.tossWonLabel.AutoSize = true;
            this.tossWonLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tossWonLabel.Location = new System.Drawing.Point(4, 173);
            this.tossWonLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tossWonLabel.Name = "tossWonLabel";
            this.tossWonLabel.Size = new System.Drawing.Size(88, 19);
            this.tossWonLabel.TabIndex = 8;
            this.tossWonLabel.Text = "Toss won by";
            // 
            // tossWonDropDown
            // 
            this.tossWonDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tossWonDropDown.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tossWonDropDown.FormattingEnabled = true;
            this.tossWonDropDown.Items.AddRange(new object[] {
            "Home",
            "Away"});
            this.tossWonDropDown.Location = new System.Drawing.Point(8, 196);
            this.tossWonDropDown.Margin = new System.Windows.Forms.Padding(4);
            this.tossWonDropDown.Name = "tossWonDropDown";
            this.tossWonDropDown.Size = new System.Drawing.Size(350, 27);
            this.tossWonDropDown.TabIndex = 9;
            // 
            // tossChoiceDropDown
            // 
            this.tossChoiceDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tossChoiceDropDown.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tossChoiceDropDown.FormattingEnabled = true;
            this.tossChoiceDropDown.Items.AddRange(new object[] {
            "Batting",
            "Bowling"});
            this.tossChoiceDropDown.Location = new System.Drawing.Point(366, 196);
            this.tossChoiceDropDown.Margin = new System.Windows.Forms.Padding(4);
            this.tossChoiceDropDown.Name = "tossChoiceDropDown";
            this.tossChoiceDropDown.Size = new System.Drawing.Size(338, 27);
            this.tossChoiceDropDown.TabIndex = 10;
            // 
            // choiceLabel
            // 
            this.choiceLabel.AutoSize = true;
            this.choiceLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choiceLabel.Location = new System.Drawing.Point(362, 173);
            this.choiceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.choiceLabel.Name = "choiceLabel";
            this.choiceLabel.Size = new System.Drawing.Size(53, 19);
            this.choiceLabel.TabIndex = 11;
            this.choiceLabel.Text = "Choice";
            // 
            // setupWindowTabControl
            // 
            this.setupWindowTabControl.Controls.Add(this.newMatchTab);
            this.setupWindowTabControl.Controls.Add(this.addPlayerTab);
            this.setupWindowTabControl.Controls.Add(this.addTeamTab);
            this.setupWindowTabControl.Controls.Add(this.findMatchTab);
            this.setupWindowTabControl.Controls.Add(this.findTeamTab);
            this.setupWindowTabControl.Controls.Add(this.findPlayerTab);
            this.setupWindowTabControl.Location = new System.Drawing.Point(12, 12);
            this.setupWindowTabControl.Name = "setupWindowTabControl";
            this.setupWindowTabControl.SelectedIndex = 0;
            this.setupWindowTabControl.Size = new System.Drawing.Size(719, 483);
            this.setupWindowTabControl.TabIndex = 12;
            this.setupWindowTabControl.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.setupWindowTabControl_Selecting);
            // 
            // newMatchTab
            // 
            this.newMatchTab.Controls.Add(this.createAMatchLabel);
            this.newMatchTab.Controls.Add(this.choiceLabel);
            this.newMatchTab.Controls.Add(this.homeTeamLabel);
            this.newMatchTab.Controls.Add(this.tossChoiceDropDown);
            this.newMatchTab.Controls.Add(this.homeTeamDropDown);
            this.newMatchTab.Controls.Add(this.tossWonDropDown);
            this.newMatchTab.Controls.Add(this.awayTeamLabel);
            this.newMatchTab.Controls.Add(this.tossWonLabel);
            this.newMatchTab.Controls.Add(this.awayTeamDropDown);
            this.newMatchTab.Controls.Add(this.beginButton);
            this.newMatchTab.Controls.Add(this.matchDateLabel);
            this.newMatchTab.Controls.Add(this.matchDateCalendar);
            this.newMatchTab.Location = new System.Drawing.Point(4, 28);
            this.newMatchTab.Name = "newMatchTab";
            this.newMatchTab.Padding = new System.Windows.Forms.Padding(3);
            this.newMatchTab.Size = new System.Drawing.Size(711, 451);
            this.newMatchTab.TabIndex = 0;
            this.newMatchTab.Text = "New Match";
            this.newMatchTab.UseVisualStyleBackColor = true;
            // 
            // createAMatchLabel
            // 
            this.createAMatchLabel.AutoSize = true;
            this.createAMatchLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAMatchLabel.Location = new System.Drawing.Point(7, 7);
            this.createAMatchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.createAMatchLabel.Name = "createAMatchLabel";
            this.createAMatchLabel.Size = new System.Drawing.Size(98, 23);
            this.createAMatchLabel.TabIndex = 0;
            this.createAMatchLabel.Text = "New Match";
            // 
            // addPlayerTab
            // 
            this.addPlayerTab.Controls.Add(this.addPlayerButton);
            this.addPlayerTab.Controls.Add(this.playerTeamDropdown);
            this.addPlayerTab.Controls.Add(this.playerTeamLabel);
            this.addPlayerTab.Controls.Add(this.playerSurnameTextbox);
            this.addPlayerTab.Controls.Add(this.playerSurnameLabel);
            this.addPlayerTab.Controls.Add(this.playerFirstNameLabel);
            this.addPlayerTab.Controls.Add(this.playerFirstNameTextbox);
            this.addPlayerTab.Controls.Add(this.createPlayerLabel);
            this.addPlayerTab.Location = new System.Drawing.Point(4, 28);
            this.addPlayerTab.Name = "addPlayerTab";
            this.addPlayerTab.Padding = new System.Windows.Forms.Padding(3);
            this.addPlayerTab.Size = new System.Drawing.Size(711, 451);
            this.addPlayerTab.TabIndex = 1;
            this.addPlayerTab.Text = "Add Player";
            this.addPlayerTab.UseVisualStyleBackColor = true;
            // 
            // addPlayerButton
            // 
            this.addPlayerButton.Location = new System.Drawing.Point(543, 390);
            this.addPlayerButton.Name = "addPlayerButton";
            this.addPlayerButton.Size = new System.Drawing.Size(162, 55);
            this.addPlayerButton.TabIndex = 8;
            this.addPlayerButton.Text = "Add Player";
            this.addPlayerButton.UseVisualStyleBackColor = true;
            this.addPlayerButton.Click += new System.EventHandler(this.addPlayerButton_Click);
            // 
            // playerTeamDropdown
            // 
            this.playerTeamDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.playerTeamDropdown.FormattingEnabled = true;
            this.playerTeamDropdown.Location = new System.Drawing.Point(8, 195);
            this.playerTeamDropdown.Name = "playerTeamDropdown";
            this.playerTeamDropdown.Size = new System.Drawing.Size(697, 27);
            this.playerTeamDropdown.TabIndex = 7;
            // 
            // playerTeamLabel
            // 
            this.playerTeamLabel.AutoSize = true;
            this.playerTeamLabel.Location = new System.Drawing.Point(4, 173);
            this.playerTeamLabel.Name = "playerTeamLabel";
            this.playerTeamLabel.Size = new System.Drawing.Size(44, 19);
            this.playerTeamLabel.TabIndex = 6;
            this.playerTeamLabel.Text = "Team";
            // 
            // playerSurnameTextbox
            // 
            this.playerSurnameTextbox.Location = new System.Drawing.Point(8, 130);
            this.playerSurnameTextbox.Name = "playerSurnameTextbox";
            this.playerSurnameTextbox.Size = new System.Drawing.Size(697, 27);
            this.playerSurnameTextbox.TabIndex = 5;
            // 
            // playerSurnameLabel
            // 
            this.playerSurnameLabel.AutoSize = true;
            this.playerSurnameLabel.Location = new System.Drawing.Point(4, 108);
            this.playerSurnameLabel.Name = "playerSurnameLabel";
            this.playerSurnameLabel.Size = new System.Drawing.Size(65, 19);
            this.playerSurnameLabel.TabIndex = 4;
            this.playerSurnameLabel.Text = "Surname";
            // 
            // playerFirstNameLabel
            // 
            this.playerFirstNameLabel.AutoSize = true;
            this.playerFirstNameLabel.Location = new System.Drawing.Point(4, 42);
            this.playerFirstNameLabel.Name = "playerFirstNameLabel";
            this.playerFirstNameLabel.Size = new System.Drawing.Size(79, 19);
            this.playerFirstNameLabel.TabIndex = 3;
            this.playerFirstNameLabel.Text = "First Name";
            // 
            // playerFirstNameTextbox
            // 
            this.playerFirstNameTextbox.Location = new System.Drawing.Point(8, 65);
            this.playerFirstNameTextbox.Name = "playerFirstNameTextbox";
            this.playerFirstNameTextbox.Size = new System.Drawing.Size(697, 27);
            this.playerFirstNameTextbox.TabIndex = 2;
            // 
            // createPlayerLabel
            // 
            this.createPlayerLabel.AutoSize = true;
            this.createPlayerLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPlayerLabel.Location = new System.Drawing.Point(7, 7);
            this.createPlayerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.createPlayerLabel.Name = "createPlayerLabel";
            this.createPlayerLabel.Size = new System.Drawing.Size(93, 23);
            this.createPlayerLabel.TabIndex = 1;
            this.createPlayerLabel.Text = "Add Player";
            // 
            // addTeamTab
            // 
            this.addTeamTab.Controls.Add(this.addTeamButton);
            this.addTeamTab.Controls.Add(this.teamNameLabel);
            this.addTeamTab.Controls.Add(this.teamNameTextbox);
            this.addTeamTab.Controls.Add(this.createTeamLabel);
            this.addTeamTab.Location = new System.Drawing.Point(4, 28);
            this.addTeamTab.Name = "addTeamTab";
            this.addTeamTab.Padding = new System.Windows.Forms.Padding(3);
            this.addTeamTab.Size = new System.Drawing.Size(711, 451);
            this.addTeamTab.TabIndex = 2;
            this.addTeamTab.Text = "Add Team";
            this.addTeamTab.UseVisualStyleBackColor = true;
            // 
            // addTeamButton
            // 
            this.addTeamButton.Location = new System.Drawing.Point(544, 389);
            this.addTeamButton.Name = "addTeamButton";
            this.addTeamButton.Size = new System.Drawing.Size(162, 55);
            this.addTeamButton.TabIndex = 12;
            this.addTeamButton.Text = "Add Team";
            this.addTeamButton.UseVisualStyleBackColor = true;
            this.addTeamButton.Click += new System.EventHandler(this.addTeamButton_Click);
            // 
            // teamNameLabel
            // 
            this.teamNameLabel.AutoSize = true;
            this.teamNameLabel.Location = new System.Drawing.Point(5, 41);
            this.teamNameLabel.Name = "teamNameLabel";
            this.teamNameLabel.Size = new System.Drawing.Size(47, 19);
            this.teamNameLabel.TabIndex = 11;
            this.teamNameLabel.Text = "Name";
            // 
            // teamNameTextbox
            // 
            this.teamNameTextbox.Location = new System.Drawing.Point(9, 64);
            this.teamNameTextbox.Name = "teamNameTextbox";
            this.teamNameTextbox.Size = new System.Drawing.Size(697, 27);
            this.teamNameTextbox.TabIndex = 10;
            // 
            // createTeamLabel
            // 
            this.createTeamLabel.AutoSize = true;
            this.createTeamLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTeamLabel.Location = new System.Drawing.Point(7, 7);
            this.createTeamLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.createTeamLabel.Name = "createTeamLabel";
            this.createTeamLabel.Size = new System.Drawing.Size(85, 23);
            this.createTeamLabel.TabIndex = 2;
            this.createTeamLabel.Text = "Add Team";
            // 
            // findMatchTab
            // 
            this.findMatchTab.Controls.Add(this.findMatchButton);
            this.findMatchTab.Controls.Add(this.findMatchCalendar);
            this.findMatchTab.Controls.Add(this.findMatchDateLabel);
            this.findMatchTab.Controls.Add(this.findMatchTitle);
            this.findMatchTab.Location = new System.Drawing.Point(4, 28);
            this.findMatchTab.Name = "findMatchTab";
            this.findMatchTab.Padding = new System.Windows.Forms.Padding(3);
            this.findMatchTab.Size = new System.Drawing.Size(711, 451);
            this.findMatchTab.TabIndex = 3;
            this.findMatchTab.Text = "Find Match";
            this.findMatchTab.UseVisualStyleBackColor = true;
            // 
            // findTeamTab
            // 
            this.findTeamTab.Location = new System.Drawing.Point(4, 28);
            this.findTeamTab.Name = "findTeamTab";
            this.findTeamTab.Padding = new System.Windows.Forms.Padding(3);
            this.findTeamTab.Size = new System.Drawing.Size(711, 451);
            this.findTeamTab.TabIndex = 4;
            this.findTeamTab.Text = "Find Team";
            this.findTeamTab.UseVisualStyleBackColor = true;
            // 
            // findPlayerTab
            // 
            this.findPlayerTab.Location = new System.Drawing.Point(4, 28);
            this.findPlayerTab.Name = "findPlayerTab";
            this.findPlayerTab.Padding = new System.Windows.Forms.Padding(3);
            this.findPlayerTab.Size = new System.Drawing.Size(711, 451);
            this.findPlayerTab.TabIndex = 5;
            this.findPlayerTab.Text = "Find Player";
            this.findPlayerTab.UseVisualStyleBackColor = true;
            // 
            // findMatchDateLabel
            // 
            this.findMatchDateLabel.AutoSize = true;
            this.findMatchDateLabel.Location = new System.Drawing.Point(5, 41);
            this.findMatchDateLabel.Name = "findMatchDateLabel";
            this.findMatchDateLabel.Size = new System.Drawing.Size(40, 19);
            this.findMatchDateLabel.TabIndex = 14;
            this.findMatchDateLabel.Text = "Date";
            // 
            // findMatchTitle
            // 
            this.findMatchTitle.AutoSize = true;
            this.findMatchTitle.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findMatchTitle.Location = new System.Drawing.Point(7, 7);
            this.findMatchTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.findMatchTitle.Name = "findMatchTitle";
            this.findMatchTitle.Size = new System.Drawing.Size(96, 23);
            this.findMatchTitle.TabIndex = 13;
            this.findMatchTitle.Text = "Find Match";
            // 
            // findMatchCalendar
            // 
            this.findMatchCalendar.Location = new System.Drawing.Point(9, 69);
            this.findMatchCalendar.MaxSelectionCount = 1;
            this.findMatchCalendar.Name = "findMatchCalendar";
            this.findMatchCalendar.TabIndex = 12;
            // 
            // findMatchButton
            // 
            this.findMatchButton.Location = new System.Drawing.Point(543, 390);
            this.findMatchButton.Name = "findMatchButton";
            this.findMatchButton.Size = new System.Drawing.Size(162, 55);
            this.findMatchButton.TabIndex = 13;
            this.findMatchButton.Text = "Find match";
            this.findMatchButton.UseVisualStyleBackColor = true;
            this.findMatchButton.Click += new System.EventHandler(this.findMatchButton_Click);
            // 
            // SetupWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(743, 507);
            this.Controls.Add(this.setupWindowTabControl);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SetupWindow";
            this.Text = "SetupWindow";
            this.Load += new System.EventHandler(this.SetupWindow_Load);
            this.setupWindowTabControl.ResumeLayout(false);
            this.newMatchTab.ResumeLayout(false);
            this.newMatchTab.PerformLayout();
            this.addPlayerTab.ResumeLayout(false);
            this.addPlayerTab.PerformLayout();
            this.addTeamTab.ResumeLayout(false);
            this.addTeamTab.PerformLayout();
            this.findMatchTab.ResumeLayout(false);
            this.findMatchTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label homeTeamLabel;
        private System.Windows.Forms.ComboBox homeTeamDropDown;
        private System.Windows.Forms.Label awayTeamLabel;
        private System.Windows.Forms.ComboBox awayTeamDropDown;
        private System.Windows.Forms.Label matchDateLabel;
        private System.Windows.Forms.MonthCalendar matchDateCalendar;
        private System.Windows.Forms.Button beginButton;
        private System.Windows.Forms.Label tossWonLabel;
        private System.Windows.Forms.ComboBox tossWonDropDown;
        private System.Windows.Forms.ComboBox tossChoiceDropDown;
        private System.Windows.Forms.Label choiceLabel;
        private System.Windows.Forms.TabControl setupWindowTabControl;
        private System.Windows.Forms.TabPage newMatchTab;
        private System.Windows.Forms.TabPage addPlayerTab;
        private System.Windows.Forms.TabPage addTeamTab;
        private System.Windows.Forms.TabPage findMatchTab;
        private System.Windows.Forms.TabPage findTeamTab;
        private System.Windows.Forms.TabPage findPlayerTab;
        private System.Windows.Forms.Label createAMatchLabel;
        private System.Windows.Forms.Label createPlayerLabel;
        private System.Windows.Forms.Label createTeamLabel;
        private System.Windows.Forms.TextBox playerFirstNameTextbox;
        private System.Windows.Forms.TextBox playerSurnameTextbox;
        private System.Windows.Forms.Label playerSurnameLabel;
        private System.Windows.Forms.Label playerFirstNameLabel;
        private System.Windows.Forms.ComboBox playerTeamDropdown;
        private System.Windows.Forms.Label playerTeamLabel;
        private System.Windows.Forms.Button addPlayerButton;
        private System.Windows.Forms.Button addTeamButton;
        private System.Windows.Forms.Label teamNameLabel;
        private System.Windows.Forms.TextBox teamNameTextbox;
        private System.Windows.Forms.Button findMatchButton;
        private System.Windows.Forms.MonthCalendar findMatchCalendar;
        private System.Windows.Forms.Label findMatchDateLabel;
        private System.Windows.Forms.Label findMatchTitle;
    }
}