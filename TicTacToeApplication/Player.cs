using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TicTacToeApplication
{
    class Player
    {

        //Player Properties
        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }


        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int winnings;

        public int Winnings
        {
            get { return winnings; }
            set { winnings = value; }
        }
        private int losses;

        public int Losses
        {
            get { return losses; }
            set { losses = value; }
        }
        private int matches_played;

        public int Matches_played
        {
            get { return matches_played; }
            set { matches_played = value; }
        }

        //End of Player Prperties

        public Player(string name)
        {
            this.name = name;
        }

        public void doMove(int i,int j,Grid gridRefference,bool playerturn)
        {
            gridRefference.checkSquare(playerturn, i, j);
        }
    }
}
