using System;
using System.Drawing;
using System.Windows.Forms;

namespace Dama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button[,] button = new Button[5, 8];
            int top = 0;
            int left = 0;

            for (int i = 0; i < button.GetUpperBound(0); i++)
            {
                for (int j = 0; j < button.GetUpperBound(1); j++)
                {
                    button[i, j] = new Button();
                    button[i, j].Height = 50;
                    button[i, j].Width = 50;
                    button[i, j].Left = left;
                    button[i, j].Top = top;
                    button[i, j].BackColor = Color.AntiqueWhite;

                    left += 50;

                    if ((i+j)%2==0)
                    {
                        button[i, j].BackColor = Color.Red;
                    }
                    
                    this.Controls.Add(button[i, j]);
                }
                left = 0;
                top += 50;
            }

            int left2 = 355;
            int top2 = 0;

            for (int i = 0; i < button.GetUpperBound(0); i++)
            {
                for (int j = 0; j < button.GetUpperBound(1); j++)
                {
                    button[i, j] = new Button();
                    button[i, j].Height = 50;
                    button[i, j].Width = 50;
                    button[i, j].Left = left2;
                    button[i, j].Top = top2;
                    button[i, j].BackColor = Color.Gray;


                    left2 += 50;

                    if ((i + j) % 2 == 0)
                    {
                        
                        button[i, j].BackColor = Color.AntiqueWhite;
                    }

                    this.Controls.Add(button[i, j]);
                }

                left2 = 355;
                top2 += 50;
            }

            int left3 = 0;
            int top3 = 205;

            for (int i = 0; i < button.GetUpperBound(0); i++)
            {
                for (int j = 0; j < button.GetUpperBound(1); j++)
                {
                    button[i, j] = new Button();
                    button[i, j].Height = 50;
                    button[i, j].Width = 50;
                    button[i, j].Left = left3;
                    button[i, j].Top = top3;
                    button[i, j].BackColor = Color.AntiqueWhite;

                    left3 += 50;

                    if ((i + j) % 2 == 0)
                    {
                        button[i, j].BackColor = Color.Black;
                    }

                    this.Controls.Add(button[i, j]);
                }

                left3 = 0;
                top3 += 50;
            }

            int left4 = 355;
            int top4 = 205;

            for (int i = 0; i < button.GetUpperBound(0); i++)
            {
                for (int j = 0; j < button.GetUpperBound(1); j++)
                {
                    button[i, j] = new Button();
                    button[i, j].Height = 50;
                    button[i, j].Width = 50;
                    button[i, j].Left = left4;
                    button[i, j].Top = top4;
                    button[i, j].BackColor = Color.Black;

                    left4 += 50;

                    if ((i + j) % 2 == 0)
                    {
                        
                        button[i, j].BackColor = Color.AntiqueWhite;
                    }

                    this.Controls.Add(button[i, j]);
                }

                left4 = 355;
                top4 += 50;
            }







        }
    }
}
