using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeApplication
{
    public partial class GridForm : Form
    {
        Controller GameController;
        MainForm m;

        public MainForm M
        {
            get { return m; }
            set { m = value; }
        }
        public GridForm()
        {
            InitializeComponent();
        }

        private void GridForm_Load(object sender, EventArgs e)
        {
            GameController = new Controller();
            GameController.Bam = thisformclose;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (GameController.GameStatus)
            {
                GameController.doAcion(0, 0, ((Button) sender));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (GameController.GameStatus)
            {
                GameController.doAcion(0, 1, ((Button)sender));
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (GameController.GameStatus)
            {
                GameController.doAcion(0, 2, ((Button)sender));
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (GameController.GameStatus)
            {
                GameController.doAcion(1, 2, ((Button)sender));
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (GameController.GameStatus)
            {
                GameController.doAcion(1, 1, ((Button)sender));
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (GameController.GameStatus)
            {
                GameController.doAcion(1, 0, ((Button)sender));
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (GameController.GameStatus)
            {
                GameController.doAcion(2, 0, ((Button)sender));
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (GameController.GameStatus)
            {
                GameController.doAcion(2, 1, ((Button)sender));
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (GameController.GameStatus)
            {
                GameController.doAcion(2, 2, ((Button)sender));
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //if game has not started yet
            if (!(GameController.GameStatus))
            {
                //if text boxes are empty handle the exception
                if (txtboxplayer1.Text == "" || txtboxplayer2.Text == "")
	            {
                    MessageBox.Show("Enter player Names");    
	            }
                else
                {
                    GameController.GameStatus = true;
                    GameController.newPlayers(txtboxplayer1.Text, txtboxplayer2.Text);
                    txtboxplayer1.Enabled = false;
                    txtboxplayer2.Enabled = false;
                }
            }
            else
            {
                //do nothing
            }
        }
        public void thisformclose()
        {
            m.Show();
            this.Close();
        }
        
    }
}
