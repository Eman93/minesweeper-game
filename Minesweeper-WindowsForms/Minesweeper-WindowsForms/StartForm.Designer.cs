namespace Minesweeper_WindowsForms
{
    partial class startForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.easy_label = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.easyRB.CheckedChanged += new System.EventHandler(this.easyRB_CheckedChanged);
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
            this.playButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.easy_label);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.playButton);
            this.panel1.Controls.Add(this.hardRB);
            this.panel1.Controls.Add(this.mediumRB);
            this.panel1.Controls.Add(this.easyRB);
            this.panel1.Location = new System.Drawing.Point(12, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 215);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "99\r\n16 x 30 Grid tiles";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Minesweeper_WindowsForms.Properties.Resources.Mine;
            this.pictureBox3.Location = new System.Drawing.Point(117, 127);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "40\r\n16 x 16 Grid tiles";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Minesweeper_WindowsForms.Properties.Resources.Mine;
            this.pictureBox1.Location = new System.Drawing.Point(117, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // easy_label
            // 
            this.easy_label.AutoSize = true;
            this.easy_label.BackColor = System.Drawing.SystemColors.Control;
            this.easy_label.Location = new System.Drawing.Point(159, 44);
            this.easy_label.Name = "easy_label";
            this.easy_label.Size = new System.Drawing.Size(73, 26);
            this.easy_label.TabIndex = 5;
            this.easy_label.Text = "10\r\n9 x 9 Grid tiles";
            this.easy_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Minesweeper_WindowsForms.Properties.Resources.Mine;
            this.pictureBox2.Location = new System.Drawing.Point(117, 42);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // startForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(297, 261);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "startForm";
            this.Text = "Minesweeper (choose level)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.Label easy_label;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

