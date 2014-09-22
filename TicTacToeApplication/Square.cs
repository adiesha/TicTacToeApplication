using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeApplication
{
    class Square
    {
        private bool? status = null;

        public bool? Status
        {
            get { return status; }
            set { status = value; }
        }

        //creating null square object
        public Square()
        {
            this.status = null;
        }

    }
}
