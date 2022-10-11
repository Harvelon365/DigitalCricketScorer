namespace DigitalCricketScorer
{
    partial class CustomRunSelectWindow
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
            this.runAmountTexbox = new System.Windows.Forms.TextBox();
            this.inputRunAmountLabel = new System.Windows.Forms.Label();
            this.chooseAmountButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // runAmountTexbox
            // 
            this.runAmountTexbox.Location = new System.Drawing.Point(13, 32);
            this.runAmountTexbox.Margin = new System.Windows.Forms.Padding(4);
            this.runAmountTexbox.Name = "runAmountTexbox";
            this.runAmountTexbox.Size = new System.Drawing.Size(312, 27);
            this.runAmountTexbox.TabIndex = 0;
            // 
            // inputRunAmountLabel
            // 
            this.inputRunAmountLabel.AutoSize = true;
            this.inputRunAmountLabel.Location = new System.Drawing.Point(12, 9);
            this.inputRunAmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inputRunAmountLabel.Name = "inputRunAmountLabel";
            this.inputRunAmountLabel.Size = new System.Drawing.Size(124, 19);
            this.inputRunAmountLabel.TabIndex = 1;
            this.inputRunAmountLabel.Text = "Input run amount:";
            // 
            // chooseAmountButton
            // 
            this.chooseAmountButton.Location = new System.Drawing.Point(13, 67);
            this.chooseAmountButton.Margin = new System.Windows.Forms.Padding(4);
            this.chooseAmountButton.Name = "chooseAmountButton";
            this.chooseAmountButton.Size = new System.Drawing.Size(312, 31);
            this.chooseAmountButton.TabIndex = 3;
            this.chooseAmountButton.Text = "Done";
            this.chooseAmountButton.UseVisualStyleBackColor = true;
            this.chooseAmountButton.Click += new System.EventHandler(this.ChooseAmountButton_click);
            // 
            // CustomRunSelectWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 111);
            this.Controls.Add(this.chooseAmountButton);
            this.Controls.Add(this.inputRunAmountLabel);
            this.Controls.Add(this.runAmountTexbox);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustomRunSelectWindow";
            this.Text = "Custom Run Amount";
            this.Load += new System.EventHandler(this.CustomRunSelectWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox runAmountTexbox;
        private System.Windows.Forms.Label inputRunAmountLabel;
        private System.Windows.Forms.Button chooseAmountButton;
    }
}