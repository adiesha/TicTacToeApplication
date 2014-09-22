using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeApplication
{
    class Controller
    {
        private Player player1 = null;
        private Player player2 = null;
        private bool player_turn = true;    // true if player 1 false if player 2
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

    }
}
