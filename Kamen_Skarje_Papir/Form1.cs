﻿using System;
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

        public class HelperClass
        {
            static Random rand = new Random();

            static public int GetState()
            {
                int randomizor = rand.Next(0, 2); //0,1,2
                MessageBox.Show(Convert.ToString(randomizor));
                return randomizor;
            }
        }

        public class Game
        {
            public int P1Score { get; set; }
            public int P2Score { get; set; }
            public int P1State { get; set; }
            public int P2State { get; set; }
            public static int P1HScore { get; set; }
            public static int P2HScore { get; set; }

            public int Play()
            {
                P1State = HelperClass.GetState();
                P2State = HelperClass.GetState();
                
                /*NEEDS ADJUSTMENTS*/
                if(P1State == rock)
                {
                    if(P2State == scissors)
                    {
                        return 1;
                    }
                    else if(P2State == paper)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
                else if(P1State == scissors)
                {
                    if(P2State == rock)
                    {
                        return 2;
                    }
                    else if(P2State == paper)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
                else if(P1State == paper)
                {
                    if(P2State == rock)
                    {
                        return 1;
                    }
                    else if(P2State == scissors)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    return 0;
                }
                
            }
        }
        
        public void ShowPictures()
        {
            MessageBox.Show(Convert.ToString(igra.P1State) + " : " + Convert.ToString(igra.P2State));
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
            if (igra.Play() == 1)
            {
                MessageBox.Show("Winner: player 1.");
                igra.P1Score++;
                if (igra.P1Score > Game.P1HScore)
                {
                    Game.P1HScore = igra.P1Score;
                    player1_highscore.Text = Convert.ToString(Game.P1HScore);
                }
                player1_score.Text = Convert.ToString(igra.P1Score);
            }
            else if (igra.Play() == 2)
            {
                MessageBox.Show("Winner: player 2.");
                igra.P2Score++;
                if (igra.P2Score > Game.P2HScore)
                {
                    Game.P2HScore = igra.P2Score;
                    player2_highscore.Text = Convert.ToString(Game.P2HScore);
                }
                player2_score.Text = Convert.ToString(igra.P2Score);
            }
            else
            {
                MessageBox.Show("DRAW");
            }
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