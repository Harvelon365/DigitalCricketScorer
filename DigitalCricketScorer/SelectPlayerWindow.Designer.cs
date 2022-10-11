namespace DigitalCricketScorer
{
    partial class SelectPlayerWindow
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
            this.playerSelectDropDown = new System.Windows.Forms.ComboBox();
            this.playerSelectLabel = new System.Windows.Forms.Label();
            this.makeSelectionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playerSelectDropDown
            // 
            this.playerSelectDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.playerSelectDropDown.FormattingEnabled = true;
            this.playerSelectDropDown.Location = new System.Drawing.Point(12, 31);
            this.playerSelectDropDown.Name = "playerSelectDropDown";
            this.playerSelectDropDown.Size = new System.Drawing.Size(317, 27);
            this.playerSelectDropDown.TabIndex = 0;
            // 
            // playerSelectLabel
            // 
            this.playerSelectLabel.AutoSize = true;
            this.playerSelectLabel.Location = new System.Drawing.Point(12, 9);
            this.playerSelectLabel.Name = "playerSelectLabel";
            this.playerSelectLabel.Size = new System.Drawing.Size(104, 19);
            this.playerSelectLabel.TabIndex = 1;
            this.playerSelectLabel.Text = "Select a player";
            // 
            // makeSelectionButton
            // 
            this.makeSelectionButton.Location = new System.Drawing.Point(12, 65);
            this.makeSelectionButton.Name = "makeSelectionButton";
            this.makeSelectionButton.Size = new System.Drawing.Size(317, 34);
            this.makeSelectionButton.TabIndex = 2;
            this.makeSelectionButton.Text = "Done";
            this.makeSelectionButton.UseVisualStyleBackColor = true;
            this.makeSelectionButton.Click += new System.EventHandler(this.makeSelectionButton_Click);
            // 
            // SelectPlayerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 111);
            this.Controls.Add(this.makeSelectionButton);
            this.Controls.Add(this.playerSelectLabel);
            this.Controls.Add(this.playerSelectDropDown);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SelectPlayerWindow";
            this.Text = "Select a Player";
            this.Load += new System.EventHandler(this.SelectPlayerWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox playerSelectDropDown;
        private System.Windows.Forms.Label playerSelectLabel;
        private System.Windows.Forms.Button makeSelectionButton;
    }
}