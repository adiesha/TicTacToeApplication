using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeApplication
{
    class Controller
    {
        //Game is start? finished ?
        private bool gameStatus = false;
        private Player winner = null;
        Action bam;

        public Action Bam
        {
            get { return bam; }
            set { bam = value; }
        }
        public bool GameStatus
        {
            get { return gameStatus; }
            set { gameStatus = value; }
        }
        //Gamefield
        private Grid playGrid;
        private Player player1 = null;
        private Player player2 = null;
        private Player currentPlayer;
        private bool player_turn = true;    // true if player 1(X) false (o) if player 2
        //encapsulate fields
        internal Player Player1
        {
            get { return player1; }
            set { player1 = value; }
        }
        internal Player Player2
        {
            get { return player2; }
            set { player2 = value; }
        }
        public bool Player_turn
        {
            get { return player_turn; }
            set { player_turn = value; }
        }
        //end of encapsulate fields

        public Controller()
        {
            playGrid = new Grid();
            
        }

        //Methods
        //Assign new Players to the Contrller Class
        public void newPlayers(string p1, string p2)
        {
            player1 = new Player(p1);
            player2 = new Player(p2);
            currentPlayer = player1;
            
        }

        //send the signal to grid to check off the square

        public void doAcion(int i, int j, Button buttonclicked)
        {
            //if game is not finished.
            if (this.gameStatus)
            {
                //passing the message to grid
               //checking the grid for availability of the i,j squrae
                if(playGrid.checkValidity(i,j))
                {
                    //if available pass the refference to current player to do the move
                    currentPlayer.doMove(i, j, playGrid, player_turn); 
                }
                //send the player symbol to the button to change its property
                buttonclicked.Text = Rules.playerSymbol(player_turn);
                //turning the player turn
                player_turn = (!player_turn);
                //turning the player refference
                if (currentPlayer == player1)
                {
                    currentPlayer = player2;
                }
                else
                {
                    currentPlayer = player1;
                }
                //dissabling the button
                buttonclicked.Enabled = false;
                if (playGrid.checktheGrid())
                {
                    MessageBox.Show("Game Over");
                    
                    //checking the winner
                    if ((!player_turn))
                    {
                        winner = player1;   
                    }
                    else
                    {
                        winner = player2;
                    }

                    MessageBox.Show("Winner is " + winner.Name);
                    bam();
                }

                

            }
            else
            {
                MessageBox.Show("I think game is over");
            }
        }

        public void winGame()
        {
            this.gameStatus = false;  
        }
    }
}
