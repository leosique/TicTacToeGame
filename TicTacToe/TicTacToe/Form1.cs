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
    public partial class Form1 : Form
    {
        int cont = 0;
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public Form1()
        {
            InitializeComponent();
        }

        private void fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {           
            player = new System.Media.SoundPlayer(Properties.Resources.somFundo);
            player.Load();
            player.Play();            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(cont % 2 == 0)
            {
                player.Stop();
            }
            else if(cont % 2 != 0)
            {
                player.Play();
            }
            cont++;
        }
    }
}
