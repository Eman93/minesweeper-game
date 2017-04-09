using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper_WindowsForms
{
    class SharedData
    {
        public static MinesweeperGrid mGrid;
        public static bool startFlag;
        public static int numberOfRevealedTiles;
        public static int numberOfRemainingFlags;
    }
}
