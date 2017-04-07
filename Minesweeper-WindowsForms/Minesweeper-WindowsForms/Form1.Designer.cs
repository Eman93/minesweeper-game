namespace Minesweeper_WindowsForms
{
    partial class Form1
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.easyRB = new System.Windows.Forms.RadioButton();
            this.mediumRB = new System.Windows.Forms.RadioButton();
            this.hardRB = new System.Windows.Forms.RadioButton();
            this.playButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Location = new System.Drawing.Point(2, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 0);
            this.panel2.TabIndex = 1;
            // 
            // easyRB
            // 
            this.easyRB.AutoSize = true;
            this.easyRB.Checked = true;
            this.easyRB.Location = new System.Drawing.Point(22, 42);
            this.easyRB.Name = "easyRB";
            this.easyRB.Size = new System.Drawing.Size(48, 17);
            this.easyRB.TabIndex = 0;
            this.easyRB.TabStop = true;
            this.easyRB.Text = "Easy";
            this.easyRB.UseVisualStyleBackColor = true;
            // 
            // mediumRB
            // 
            this.mediumRB.AutoSize = true;
            this.mediumRB.Location = new System.Drawing.Point(22, 85);
            this.mediumRB.Name = "mediumRB";
            this.mediumRB.Size = new System.Drawing.Size(62, 17);
            this.mediumRB.TabIndex = 1;
            this.mediumRB.Text = "Medium";
            this.mediumRB.UseVisualStyleBackColor = true;
            // 
            // hardRB
            // 
            this.hardRB.AutoSize = true;
            this.hardRB.Location = new System.Drawing.Point(22, 129);
            this.hardRB.Name = "hardRB";
            this.hardRB.Size = new System.Drawing.Size(48, 17);
            this.hardRB.TabIndex = 2;
            this.hardRB.Text = "Hard";
            this.hardRB.UseVisualStyleBackColor = true;
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(80, 177);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(75, 23);
            this.playButton.TabIndex = 3;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.playButton);
            this.panel1.Controls.Add(this.hardRB);
            this.panel1.Controls.Add(this.mediumRB);
            this.panel1.Controls.Add(this.easyRB);
            this.panel1.Location = new System.Drawing.Point(12, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 215);
            this.panel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(297, 261);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Minesweeper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton easyRB;
        private System.Windows.Forms.RadioButton mediumRB;
        private System.Windows.Forms.RadioButton hardRB;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Panel panel1;
    }
}

