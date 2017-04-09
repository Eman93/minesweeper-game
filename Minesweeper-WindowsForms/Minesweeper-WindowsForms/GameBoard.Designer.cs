namespace Minesweeper_WindowsForms
{
    partial class GameBoard
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mines_label = new System.Windows.Forms.Label();
            this.time_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Minesweeper_WindowsForms.Properties.Resources.Mine;
            this.pictureBox2.Location = new System.Drawing.Point(140, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Minesweeper_WindowsForms.Properties.Resources.clock_bw;
            this.pictureBox1.Location = new System.Drawing.Point(30, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // mines_label
            // 
            this.mines_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mines_label.Location = new System.Drawing.Point(172, 36);
            this.mines_label.Name = "mines_label";
            this.mines_label.Size = new System.Drawing.Size(50, 18);
            this.mines_label.TabIndex = 3;
            this.mines_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // time_label
            // 
            this.time_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.time_label.Location = new System.Drawing.Point(62, 35);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(50, 18);
            this.time_label.TabIndex = 4;
            // 
            // GameBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(0, 10);
            this.AutoScrollMinSize = new System.Drawing.Size(10, 10);
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.time_label);
            this.Controls.Add(this.mines_label);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GameBoard";
            this.Padding = new System.Windows.Forms.Padding(10, 10, 25, 10);
            this.Text = "GameBoard";
            this.Load += new System.EventHandler(this.GameBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label mines_label;
        private System.Windows.Forms.Label time_label;
    }
}