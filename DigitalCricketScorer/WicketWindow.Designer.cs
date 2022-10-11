namespace DigitalCricketScorer
{
    partial class WicketWindow
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
            this.makeSelectionButton = new System.Windows.Forms.Button();
            this.playerSelectDropDown = new System.Windows.Forms.ComboBox();
            this.wicketSelectDropDown = new System.Windows.Forms.ComboBox();
            this.playerSelectLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // makeSelectionButton
            // 
            this.makeSelectionButton.Location = new System.Drawing.Point(12, 97);
            this.makeSelectionButton.Name = "makeSelectionButton";
            this.makeSelectionButton.Size = new System.Drawing.Size(317, 34);
            this.makeSelectionButton.TabIndex = 4;
            this.makeSelectionButton.Text = "Done";
            this.makeSelectionButton.UseVisualStyleBackColor = true;
            this.makeSelectionButton.Click += new System.EventHandler(this.makeSelectionButton_Click);
            // 
            // playerSelectDropDown
            // 
            this.playerSelectDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.playerSelectDropDown.FormattingEnabled = true;
            this.playerSelectDropDown.Location = new System.Drawing.Point(12, 31);
            this.playerSelectDropDown.Name = "playerSelectDropDown";
            this.playerSelectDropDown.Size = new System.Drawing.Size(317, 27);
            this.playerSelectDropDown.TabIndex = 3;
            // 
            // wicketSelectDropDown
            // 
            this.wicketSelectDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.wicketSelectDropDown.FormattingEnabled = true;
            this.wicketSelectDropDown.Location = new System.Drawing.Point(12, 64);
            this.wicketSelectDropDown.Name = "wicketSelectDropDown";
            this.wicketSelectDropDown.Size = new System.Drawing.Size(317, 27);
            this.wicketSelectDropDown.TabIndex = 5;
            // 
            // playerSelectLabel
            // 
            this.playerSelectLabel.AutoSize = true;
            this.playerSelectLabel.Location = new System.Drawing.Point(12, 9);
            this.playerSelectLabel.Name = "playerSelectLabel";
            this.playerSelectLabel.Size = new System.Drawing.Size(209, 19);
            this.playerSelectLabel.TabIndex = 6;
            this.playerSelectLabel.Text = "Select a player and wicket type";
            // 
            // WicketWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 143);
            this.Controls.Add(this.playerSelectLabel);
            this.Controls.Add(this.wicketSelectDropDown);
            this.Controls.Add(this.makeSelectionButton);
            this.Controls.Add(this.playerSelectDropDown);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WicketWindow";
            this.Text = "New Wicket";
            this.Load += new System.EventHandler(this.WicketWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button makeSelectionButton;
        private System.Windows.Forms.ComboBox playerSelectDropDown;
        private System.Windows.Forms.ComboBox wicketSelectDropDown;
        private System.Windows.Forms.Label playerSelectLabel;
    }
}