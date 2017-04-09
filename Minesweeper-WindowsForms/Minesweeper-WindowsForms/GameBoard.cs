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
    public partial class GameBoard : Form
    {

        Button[,] buttons;

        public GameBoard()
        {
            InitializeComponent();
            mines_label.Text = SharedData.numberOfRemainingFlags.ToString();
            DrowGrid();

        }


        private void GameBoard_Load(object sender, EventArgs e)
        {

        }


        private void grid_Tile_Click(object sender, EventArgs e)
        {
            Button tile = (sender as Button);

            // do nothing if it is flagged 
            if (tile.Image != null)
                return;

            // getting the row and coulmn of the tile 
            var pos = tile.Name.Substring(8);
            int commaIndex = pos.IndexOf(',');
            int i = Int32.Parse(pos.Substring(0, commaIndex));
            int j = Int32.Parse(pos.Substring(commaIndex + 1));

            if (!SharedData.startFlag) //first click
            {
                SharedData.startFlag = true;
                SharedData.mGrid.distributeMines(i, j);
            }

            show_Tile(i, j, SharedData.mGrid.Grid[i, j]);


        }


        private void show_Tile(int i, int j, int tileValue)
        {
            
            buttons[i, j].Enabled = false;

            // if it is mine
            if (tileValue == -1)
            {
                //TODO end the game with losing
            }
            else if (tileValue == 0)
            {
                int r = buttons.GetLength(0);
                int c = buttons.GetLength(1);

                // show the tile
                buttons[i, j].BackColor = Color.WhiteSmoke;


                // revealing adjacent tiles 
                for (int a = -1; a < 2; a++)
                    for (int b = -1; b < 2; b++)
                    {
                        if (!(a == 0 && b == 0)   // not the same tile
                            && i + a >= 0 && i + a < r    //to check boundaries
                            && j + b >= 0 && j + b < c
                            && buttons[i + a, j + b].Enabled  // not visited
                            && buttons[i + a, j + b].Image ==null) // not a flag
                            show_Tile(i + a, j + b, SharedData.mGrid.Grid[i + a, j + b]);

                    }

            }
            else
            {

                buttons[i, j].BackColor = Color.WhiteSmoke;
                buttons[i, j].Text = tileValue.ToString();

            }
        }


        private void DrowGrid()
        {
            try
            {
                int i, j;
                buttons = new Button[SharedData.mGrid.Grid.GetLength(0), SharedData.mGrid.Grid.GetLength(1)];

                for (i = 0; i < buttons.GetLength(0); i++)
                {
                    for (j = 0; j < buttons.GetLength(1); j++)
                    {
                        buttons[i, j] = new Button(); //Creating the chess object//
                        buttons[i, j].BackColor = System.Drawing.SystemColors.ActiveCaption;
                        buttons[i, j].Location = new System.Drawing.Point(2 + i * 25, 70 + j * 25);
                        buttons[i, j].Name = "gridTile" + i.ToString() + "," + j.ToString();
                        buttons[i, j].Size = new System.Drawing.Size(25, 25);
                        buttons[i, j].TabIndex = 2;
                        buttons[i, j].TabStop = false;
                        buttons[i, j].Click += new EventHandler(grid_Tile_Click);
                        buttons[i, j].MouseDown += new MouseEventHandler(right_Mouse_Click);
                        this.Controls.Add(this.buttons[i, j]);

                    }
                }

            }
            catch (Exception)
            {

                throw;
            }

        }

        /// <summary>
        /// this method is fired in case of a right click event to add or 
        /// remove flags 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void right_Mouse_Click(object sender, MouseEventArgs e)
        {
            Button tile = sender as Button;
            if (e.Button == MouseButtons.Right)
            {
                if (tile.Image != null)
                {
                    tile.Image = null;
                    SharedData.numberOfRemainingFlags++;
                    mines_label.Text = SharedData.numberOfRemainingFlags.ToString();

                }
                else
                {
                    SharedData.numberOfRemainingFlags--;
                    mines_label.Text = SharedData.numberOfRemainingFlags.ToString();
                    tile.Image = Properties.Resources.FlaggedCell;
                }
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
