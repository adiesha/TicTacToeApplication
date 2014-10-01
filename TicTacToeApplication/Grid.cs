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
        //status of the grid
        private bool isfinished = false;
        private short[,] playGrid = null;
        public Grid()
        {
            // -1 means not assigned values
            //when creating apply -1 to all of the 
            playGrid = new short[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    playGrid[i, j] = 0;
                }
            }
        }

        //checks the winner
        //true if there is no possible moves
        public bool checktheGrid()
        {
            //checking for horizontal lines
            for (int i = 0; i < 3; i++)
            {
                int temp = 0;
                for (int j = 0; j < 3; j++)
                {
                    temp = temp + playGrid[i, j];
                }
                if (temp == 3 || temp == -3)
                {
                    return true;
                }
            }
            //checking for verticle lines
            for (int j = 0; j < 3; j++)
            {
                int temp = 0;
                for (int i = 0; i < 3; i++)
                {
                    temp = temp + playGrid[i, j];   
                }
                if (temp == 3 || temp == -3)
                {
                    return true;
                }
            }


            //checking diagonal lines
                //checking  \ diagonal
            int temp1 = 0;
            for (int i = 0; i < 3; i++)
            {
                temp1 += playGrid[i, i];
            }
            if ((temp1 == -3) || (temp1 == 3))
            {
                return true;    
            }

                //checking / diagonal
            int temp2 = 0;
            int y = 2;
            for (int i = 0; i < 3; i++)
            {
                temp2 += playGrid[i, y];
                y--;
            }
            if ((temp2 == -3) || (temp2 == 3))
            {
                return true;
            }


            // checking whether game is finished beacuse there is no free squares
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (playGrid[i, j] == 0)
                        return false;
                }
            }

            return true;

        }
        //put the choice in the square
        public void checkSquare(bool playerturn, int i, int j)
        {

            playGrid[i, j] = Rules.trueFalseToInteger(playerturn);
        }

        //check the validity of given i,j values - whether the given grid square is available
        public bool checkValidity(int i,int j)
        {
            if(playGrid[i,j] == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



    }
}
