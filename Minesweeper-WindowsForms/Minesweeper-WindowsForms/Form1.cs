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

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void draw_Grid()
        {
           


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

            Form window = new GameBoard();
            window.Owner = this;
            window.Show();
            this.Hide();
        }

      




    }
}
