using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form4 : Form
    {
        int cont = 0;
        public Form4()
        {
            InitializeComponent();
        }

        private void fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl1_Click(object sender, EventArgs e)
        {
            if(cont == 0)
            {
                lbl1.Text = "X";
                cont = 1;
            }
            else if(cont == 1)
            {
                lbl1.Text = "O";
                cont = 0;
            }

        }
    }
}
