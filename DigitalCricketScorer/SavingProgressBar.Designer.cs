namespace DigitalCricketScorer
{
    partial class SavingProgressBar
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
            this.components = new System.ComponentModel.Container();
            this.savingDataProgressBar = new System.Windows.Forms.ProgressBar();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.savingDataLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // savingDataProgressBar
            // 
            this.savingDataProgressBar.Location = new System.Drawing.Point(12, 31);
            this.savingDataProgressBar.Name = "savingDataProgressBar";
            this.savingDataProgressBar.Size = new System.Drawing.Size(325, 23);
            this.savingDataProgressBar.Step = 25;
            this.savingDataProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.savingDataProgressBar.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // savingDataLabel
            // 
            this.savingDataLabel.AutoSize = true;
            this.savingDataLabel.Location = new System.Drawing.Point(12, 9);
            this.savingDataLabel.Name = "savingDataLabel";
            this.savingDataLabel.Size = new System.Drawing.Size(140, 19);
            this.savingDataLabel.TabIndex = 1;
            this.savingDataLabel.Text = "Saving match data...";
            // 
            // SavingProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 68);
            this.Controls.Add(this.savingDataLabel);
            this.Controls.Add(this.savingDataProgressBar);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SavingProgressBar";
            this.Text = "Saving Data";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar savingDataProgressBar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label savingDataLabel;
    }
}