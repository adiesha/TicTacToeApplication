﻿using System;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GridForm NewGrid = new GridForm();
            this.Visible = false;
            NewGrid.Show();

            
        }

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        
    }
}
