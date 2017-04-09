using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Minesweeper_WindowsForms
{

    public partial class startForm : Form
    {
        public startForm()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void playButton_Click(object sender, EventArgs e)
        {
            char level = 'e'; // n for nothing
            if (hardRB.Checked == true) level = 'h';
            else if (mediumRB.Checked == true) level = 'm';

            SharedData.mGrid = new MinesweeperGrid(level);
            SharedData.startFlag = false; // the first click hasn't happened yet
            SharedData.numberOfRevealedTiles = 0;
            SharedData.numberOfRemainingFlags = SharedData.mGrid.NumberOfMines;

            Form window = new GameBoard();
            window.Owner = this;
            window.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void easyRB_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
