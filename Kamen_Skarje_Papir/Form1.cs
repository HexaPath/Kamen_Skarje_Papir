using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kamen_Skarje_Papir
{
    
    public partial class KamenSkarjePapir : Form
    {
        public KamenSkarjePapir()
        {
            InitializeComponent();
        }

        public const int rock = 0;
        public const int scissors = 1;
        public const int paper = 2;

        Game igra = new Game();
        
        public void ShowPictures()
        {
            switch (igra.P1State)
            {
                case rock:
                    pictureBox1.Image = Properties.Resources.kamen; 
                    break;
                case scissors:
                    pictureBox1.Image = Properties.Resources.skarje;
                    break;
                case paper:
                    pictureBox1.Image = Properties.Resources.papir;
                    break;
            }
            switch (igra.P2State)
            {
                case rock:
                    pictureBox2.Image = Properties.Resources.kamen;
                    break;
                case scissors:
                    pictureBox2.Image = Properties.Resources.skarje;
                    break;
                case paper:
                    pictureBox2.Image = Properties.Resources.papir;
                    break;
            }
        }

        private void PlayBtn_Click(object sender, EventArgs e)
        {
            switch(igra.Play())
            {
                case 1:
                    igra.P1Score++;
                    if (igra.P1Score > Game.P1HScore)
                    {
                        Game.P1HScore = igra.P1Score;
                    }
                    break;
                case 2:
                    igra.P2Score++;
                    if (igra.P2Score > Game.P2HScore)
                    {
                        Game.P2HScore = igra.P2Score;
                    }
                    break;
                case 3:
                    /*DRAW*/
                    break;
            }
            updater();
        }

        private void updater()
        { 
            player2_highscore.Text = Convert.ToString(Game.P2HScore);
            player1_highscore.Text = Convert.ToString(Game.P1HScore);
            player1_score.Text = Convert.ToString(igra.P1Score);
            player2_score.Text = Convert.ToString(igra.P2Score);
            ShowPictures();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            igra.P1Score = 0;
            igra.P2Score = 0;
            player1_score.Text = Convert.ToString(igra.P1Score);
            player2_score.Text = Convert.ToString(igra.P2Score);
        }
    }
}
