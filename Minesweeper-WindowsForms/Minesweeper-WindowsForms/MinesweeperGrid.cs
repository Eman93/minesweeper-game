
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper_WindowsForms
{
    class MinesweeperGrid
    {
        int numberOfMines;
        int[,] grid;
        Tuple<int, int>[] locationsOfMines;



    #region constructors

        public MinesweeperGrid()
        {
           // the default values
            this.numberOfMines = 10;
            grid = new int[9, 9];
            locationsOfMines = new Tuple<int, int>[10];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="level"> 'e' for easy, 'm' for medium and 'h' for hard </param>
        public MinesweeperGrid(char level )
        {
            if (level == 'h' || level == 'H')
            {
                this.numberOfMines = 99;
                this.grid = new int[16, 30];
                locationsOfMines = new Tuple<int, int>[99];
            }
            else if (level == 'm' || level == 'M')
            {
                this.numberOfMines = 40;
                this.grid = new int[16, 16];
                locationsOfMines = new Tuple<int, int>[40];
            }
            else
            {
                this.numberOfMines = 10;
                this.grid = new int[9, 9];
                locationsOfMines = new Tuple<int, int>[10];
            }
            

        }

        #endregion

        #region Properties


        public int NumberOfMines
        {
            get { return numberOfMines; }

        }
       public int[,] Grid
        {
            get { return grid ; }
           
        }

        public Tuple<int, int>[] LocationsOfMines
        {
            get { return locationsOfMines; }
        }


        #endregion



        /// <summary>
        /// this method distributes the mines randomly over the grid with -1 value
        /// and making sure the grid[startX, startY] is not one of them.
        /// It also calcuates the number of adjacent mines for every
        /// tile in the grid to set its value to.
        /// </summary>
        /// <param name="startX">the row index of first tile to be clicked </param>
        /// <param name="startY">the coulmn index of first tile to be clicked </param>
        /// <returns>the return is 2D matrix with values of th grid</returns>
        public int [,] distributeMines(int startX, int startY)
        {
            int mines = numberOfMines;
            Random rand = new Random();
            int r = grid.GetLength(0);
            int c = grid.GetLength(1);
            int i, j;

            ///distributing Mines randomly///
            while (mines>0)
            {
                i = rand.Next(0,r); // random row
                j = rand.Next(0,c); //random coulmn

                
                // check if it is not a mine already
                if ( !(startX ==r && startY ==c) && grid[i,j] !=-1)
                {
                    grid[i, j] = -1; // this tile represents a mine now
                    mines--;
                    locationsOfMines[mines] = new Tuple<int, int>(i, j);
                }

            }


            /// counting the adjacent mines ///
            int sum;
            for (i=0; i<r; i++)
            {
                for(j=0; j<c; j++)
                {
                    //if it is a mine skip
                    if (grid[i, j] == -1)
                        continue;

                    sum = 0;
                    // making a 3x3 window to calculate
                    for(int a= -1; a < 2; a++)
                        for (int b = -1; b < 2; b++)
                        {
                            if (i + a >= 0 && i + a < r    //to check boundaries
                                && j + b >= 0 && j + b < c
                                && grid[i + a, j + b] == -1)  

                                sum++;

                        }

                    grid[i, j] = sum;

                }



            }



            return grid;
        }




    }
}
