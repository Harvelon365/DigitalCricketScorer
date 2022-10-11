namespace DigitalCricketScorer
{
    partial class MatchWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.matchDateLabel = new System.Windows.Forms.Label();
            this.homeTeamScoreLabel = new System.Windows.Forms.Label();
            this.awayTeamScoreLabel = new System.Windows.Forms.Label();
            this.homeTeamPlayerList = new System.Windows.Forms.DataGridView();
            this.awayTeamPlayerList = new System.Windows.Forms.DataGridView();
            this.tossOutcomelabel = new System.Windows.Forms.Label();
            this.ballByBallList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.homeTeamPlayerList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.awayTeamPlayerList)).BeginInit();
            this.SuspendLayout();
            // 
            // matchDateLabel
            // 
            this.matchDateLabel.AutoSize = true;
            this.matchDateLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matchDateLabel.Location = new System.Drawing.Point(12, 9);
            this.matchDateLabel.Name = "matchDateLabel";
            this.matchDateLabel.Size = new System.Drawing.Size(118, 26);
            this.matchDateLabel.TabIndex = 0;
            this.matchDateLabel.Text = "31/12/1999";
            // 
            // homeTeamScoreLabel
            // 
            this.homeTeamScoreLabel.AutoSize = true;
            this.homeTeamScoreLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeTeamScoreLabel.Location = new System.Drawing.Point(12, 48);
            this.homeTeamScoreLabel.Name = "homeTeamScoreLabel";
            this.homeTeamScoreLabel.Size = new System.Drawing.Size(171, 23);
            this.homeTeamScoreLabel.TabIndex = 1;
            this.homeTeamScoreLabel.Text = "Home Team - 999/11";
            // 
            // awayTeamScoreLabel
            // 
            this.awayTeamScoreLabel.AutoSize = true;
            this.awayTeamScoreLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.awayTeamScoreLabel.Location = new System.Drawing.Point(13, 71);
            this.awayTeamScoreLabel.Name = "awayTeamScoreLabel";
            this.awayTeamScoreLabel.Size = new System.Drawing.Size(168, 23);
            this.awayTeamScoreLabel.TabIndex = 2;
            this.awayTeamScoreLabel.Text = "Away Team - 999/11";
            // 
            // homeTeamPlayerList
            // 
            this.homeTeamPlayerList.AllowUserToAddRows = false;
            this.homeTeamPlayerList.AllowUserToDeleteRows = false;
            this.homeTeamPlayerList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.homeTeamPlayerList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.homeTeamPlayerList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.homeTeamPlayerList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.homeTeamPlayerList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.homeTeamPlayerList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.homeTeamPlayerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.homeTeamPlayerList.EnableHeadersVisualStyles = false;
            this.homeTeamPlayerList.GridColor = System.Drawing.SystemColors.WindowText;
            this.homeTeamPlayerList.Location = new System.Drawing.Point(13, 114);
            this.homeTeamPlayerList.Margin = new System.Windows.Forms.Padding(4);
            this.homeTeamPlayerList.MultiSelect = false;
            this.homeTeamPlayerList.Name = "homeTeamPlayerList";
            this.homeTeamPlayerList.ReadOnly = true;
            this.homeTeamPlayerList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.homeTeamPlayerList.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.homeTeamPlayerList.RowHeadersVisible = false;
            this.homeTeamPlayerList.RowHeadersWidth = 30;
            this.homeTeamPlayerList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeTeamPlayerList.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.homeTeamPlayerList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.homeTeamPlayerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.homeTeamPlayerList.Size = new System.Drawing.Size(254, 270);
            this.homeTeamPlayerList.TabIndex = 14;
            this.homeTeamPlayerList.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.GridViewColumnAdded);
            // 
            // awayTeamPlayerList
            // 
            this.awayTeamPlayerList.AllowUserToAddRows = false;
            this.awayTeamPlayerList.AllowUserToDeleteRows = false;
            this.awayTeamPlayerList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.awayTeamPlayerList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.awayTeamPlayerList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.awayTeamPlayerList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.awayTeamPlayerList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.awayTeamPlayerList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.awayTeamPlayerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.awayTeamPlayerList.EnableHeadersVisualStyles = false;
            this.awayTeamPlayerList.GridColor = System.Drawing.SystemColors.WindowText;
            this.awayTeamPlayerList.Location = new System.Drawing.Point(296, 114);
            this.awayTeamPlayerList.Margin = new System.Windows.Forms.Padding(4);
            this.awayTeamPlayerList.MultiSelect = false;
            this.awayTeamPlayerList.Name = "awayTeamPlayerList";
            this.awayTeamPlayerList.ReadOnly = true;
            this.awayTeamPlayerList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.awayTeamPlayerList.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.awayTeamPlayerList.RowHeadersVisible = false;
            this.awayTeamPlayerList.RowHeadersWidth = 30;
            this.awayTeamPlayerList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.awayTeamPlayerList.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.awayTeamPlayerList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.awayTeamPlayerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.awayTeamPlayerList.Size = new System.Drawing.Size(254, 270);
            this.awayTeamPlayerList.TabIndex = 15;
            this.awayTeamPlayerList.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.GridViewColumnAdded);
            // 
            // tossOutcomelabel
            // 
            this.tossOutcomelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tossOutcomelabel.BackColor = System.Drawing.SystemColors.Control;
            this.tossOutcomelabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tossOutcomelabel.Location = new System.Drawing.Point(163, 9);
            this.tossOutcomelabel.Name = "tossOutcomelabel";
            this.tossOutcomelabel.Size = new System.Drawing.Size(388, 19);
            this.tossOutcomelabel.TabIndex = 17;
            this.tossOutcomelabel.Text = "Home Team won the toss and chose to Bat first";
            this.tossOutcomelabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ballByBallList
            // 
            this.ballByBallList.BackColor = System.Drawing.SystemColors.Control;
            this.ballByBallList.FormattingEnabled = true;
            this.ballByBallList.ItemHeight = 19;
            this.ballByBallList.Location = new System.Drawing.Point(13, 403);
            this.ballByBallList.Name = "ballByBallList";
            this.ballByBallList.Size = new System.Drawing.Size(537, 232);
            this.ballByBallList.TabIndex = 18;
            // 
            // MatchWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 647);
            this.Controls.Add(this.ballByBallList);
            this.Controls.Add(this.tossOutcomelabel);
            this.Controls.Add(this.awayTeamPlayerList);
            this.Controls.Add(this.homeTeamPlayerList);
            this.Controls.Add(this.awayTeamScoreLabel);
            this.Controls.Add(this.homeTeamScoreLabel);
            this.Controls.Add(this.matchDateLabel);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MatchWindow";
            this.Text = "Match Summary";
            this.Load += new System.EventHandler(this.MatchWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.homeTeamPlayerList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.awayTeamPlayerList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label matchDateLabel;
        private System.Windows.Forms.Label homeTeamScoreLabel;
        private System.Windows.Forms.Label awayTeamScoreLabel;
        private System.Windows.Forms.DataGridView homeTeamPlayerList;
        private System.Windows.Forms.DataGridView awayTeamPlayerList;
        private System.Windows.Forms.Label tossOutcomelabel;
        private System.Windows.Forms.ListBox ballByBallList;
    }
}