using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proekt
{
    public partial class GameOver : Form
    {
        public GameOver(int score)
        {
            InitializeComponent();
            lbScore.Width = 267;
            lbScore.Text = String.Format("YOUR SCORE: {0}", score); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 game = new Form1();
            game.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
