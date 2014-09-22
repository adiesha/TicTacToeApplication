using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace TicTacToeApplication
{
    class Grid
    {
        Square[,] playGrid = null;
        public Grid()
        {
            playGrid = new Square[3,3];
        }


        public bool checktheGrid()
        {
            return false;
        }

        public void checkSquare(bool playerturn, int i, int j,Controller c1)
        {
            playGrid[i, j].Status = playerturn;
            
        }
    }
}
