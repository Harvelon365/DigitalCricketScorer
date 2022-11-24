namespace DigitalCricketScorer
{
    partial class PlayerWindow
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
            this.playerNameLabel = new System.Windows.Forms.Label();
            this.playerTeamNameLabel = new System.Windows.Forms.Label();
            this.playerBowlStatsList = new System.Windows.Forms.ListBox();
            this.playerBatStatsList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.AutoSize = true;
            this.playerNameLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerNameLabel.Location = new System.Drawing.Point(12, 9);
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.Size = new System.Drawing.Size(170, 26);
            this.playerNameLabel.TabIndex = 1;
            this.playerNameLabel.Text = "Player Name Here";
            // 
            // playerTeamNameLabel
            // 
            this.playerTeamNameLabel.AutoSize = true;
            this.playerTeamNameLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerTeamNameLabel.Location = new System.Drawing.Point(13, 35);
            this.playerTeamNameLabel.Name = "playerTeamNameLabel";
            this.playerTeamNameLabel.Size = new System.Drawing.Size(136, 23);
            this.playerTeamNameLabel.TabIndex = 3;
            this.playerTeamNameLabel.Text = "Team name here";
            // 
            // playerBowlStatsList
            // 
            this.playerBowlStatsList.BackColor = System.Drawing.SystemColors.Control;
            this.playerBowlStatsList.FormattingEnabled = true;
            this.playerBowlStatsList.ItemHeight = 19;
            this.playerBowlStatsList.Location = new System.Drawing.Point(13, 61);
            this.playerBowlStatsList.Name = "playerBowlStatsList";
            this.playerBowlStatsList.Size = new System.Drawing.Size(537, 99);
            this.playerBowlStatsList.TabIndex = 19;
            // 
            // playerBatStatsList
            // 
            this.playerBatStatsList.BackColor = System.Drawing.SystemColors.Control;
            this.playerBatStatsList.FormattingEnabled = true;
            this.playerBatStatsList.ItemHeight = 19;
            this.playerBatStatsList.Location = new System.Drawing.Point(14, 166);
            this.playerBatStatsList.Name = "playerBatStatsList";
            this.playerBatStatsList.Size = new System.Drawing.Size(537, 99);
            this.playerBatStatsList.TabIndex = 20;
            // 
            // PlayerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 280);
            this.Controls.Add(this.playerBatStatsList);
            this.Controls.Add(this.playerBowlStatsList);
            this.Controls.Add(this.playerTeamNameLabel);
            this.Controls.Add(this.playerNameLabel);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PlayerWindow";
            this.Text = "Player Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playerNameLabel;
        private System.Windows.Forms.Label playerTeamNameLabel;
        private System.Windows.Forms.ListBox playerBowlStatsList;
        private System.Windows.Forms.ListBox playerBatStatsList;
    }
}