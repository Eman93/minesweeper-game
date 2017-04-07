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

            try
            {
                int i, j, count = 0;
                buttons = new Button[SharedData.mGrid.Grid.GetLength(0), SharedData.mGrid.Grid.GetLength(1)];

                for (i = 0; i < buttons.GetLength(0); i++)
                {
                    for (j = 0; j < buttons.GetLength(1); j++)
                    {
                        buttons[i, j] = new Button(); //Creating the chess object//
                        buttons[i, j].BackColor = System.Drawing.SystemColors.ActiveCaption;
                        buttons[i, j].Location = new System.Drawing.Point(2 + i * 25, 70 + j * 25);
                        buttons[i, j].Name = "gridTile" + count.ToString();
                        buttons[i, j].Size = new System.Drawing.Size(25, 25);
                        buttons[i, j].TabIndex = count;
                        buttons[i, j].TabStop = false;
                       this.Controls.Add(this.buttons[i, j]);
                        count++;
                    }
                }




            }
            catch (Exception)
            {

                throw;
            }

        }

        private void GameBoard_Load(object sender, EventArgs e)
        {

        }
    }
}
