using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe_Exam
{
    public partial class Form1 : Form
    {
           // int pointX;
           // int pointO;
            bool xClick = true;
            bool GameStart;
            static int count = 0;
        

        void Write(Button press)
        {
            string writePath = @"D:\\score.txt";
            
            try
            {
                using (StreamWriter sw = new StreamWriter(writePath, true, Encoding.Default))
                {
                    if (button1.Text == button2.Text && button2.Text == button3.Text && button2.Enabled == false ||
                    button4.Text == button5.Text && button5.Text == button6.Text && button5.Enabled == false ||
                    button7.Text == button8.Text && button8.Text == button9.Text && button8.Enabled == false ||
                    button1.Text == button4.Text && button4.Text == button7.Text && button4.Enabled == false ||
                    button2.Text == button5.Text && button5.Text == button8.Text && button5.Enabled == false ||
                    button3.Text == button6.Text && button6.Text == button9.Text && button6.Enabled == false ||
                    button1.Text == button5.Text && button5.Text == button9.Text && button5.Enabled == false ||
                    button3.Text == button5.Text && button5.Text == button7.Text && button5.Enabled == false)
                    {

                        if(xClick == true)
                        {
                           // pointO =  pointO + 1;
                            sw.WriteLine(press.Text + " won in " + count + " steps"/* + " with score " + pointX + ":" + pointO*/);
                        }
                        if (xClick == false)
                        {
                            //pointX = pointX + 1;
                            sw.WriteLine(press.Text + " won in " + count + " steps"/* + " with score " + pointX + ":" + pointO*/);
                        }

                    }
                    if(count == 9)
                    {
                        sw.WriteLine("DRAW");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();



        }
        public Form1()
            {
                InitializeComponent();
            }

            private void creatorToolStripMenuItem_Click(object sender, EventArgs e)
            {

            }

            private void Button_Click(object sender, EventArgs e)
            {
                Button senderButton = (Button)sender;
                if (xClick == true)
                {
                    senderButton.Text = "X";
                }
                else
                {
                    senderButton.Text = "O";
                }
                xClick = !xClick;
                count = count + 1;  //amount of steps
                senderButton.Enabled = false;
                GameStart = true;

                CheckWin(senderButton);
            }
            void CheckWin(Button press)
            {

                if (button1.Text == button2.Text && button2.Text == button3.Text && button2.Enabled == false ||
                    button4.Text == button5.Text && button5.Text == button6.Text && button5.Enabled == false ||
                    button7.Text == button8.Text && button8.Text == button9.Text && button8.Enabled == false ||
                    button1.Text == button4.Text && button4.Text == button7.Text && button4.Enabled == false ||
                    button2.Text == button5.Text && button5.Text == button8.Text && button5.Enabled == false ||
                    button3.Text == button6.Text && button6.Text == button9.Text && button6.Enabled == false ||
                    button1.Text == button5.Text && button5.Text == button9.Text && button5.Enabled == false ||
                    button3.Text == button5.Text && button5.Text == button7.Text && button5.Enabled == false)
                {
                    MessageBox.Show(press.Text + " won!");
                    Application.Restart();
                    Write(press);
                    count = 0;
                }
                if (count == 9)  //1 sposob draw
                {
                    MessageBox.Show("DRAW!");
                    Application.Restart();
                    count = 0;
                }


                /*if ((button1.Text == button2.Text && button2.Text != button3.Text || button1.Text != button2.Text && button2.Text == button3.Text || button1.Text != button2.Text && button2.Text != button3.Text && button3.Enabled == false) &&
                    (button4.Text == button5.Text && button5.Text != button6.Text || button4.Text != button5.Text && button5.Text == button6.Text || button4.Text != button5.Text && button5.Text != button6.Text && button6.Enabled == false) &&
                    (button7.Text == button8.Text && button8.Text != button9.Text || button7.Text != button8.Text && button8.Text == button9.Text || button7.Text != button8.Text && button8.Text != button9.Text && button9.Enabled == false) &&
                    (button3.Text == button6.Text && button6.Text != button9.Text || button3.Text != button6.Text && button6.Text == button9.Text || button3.Text != button6.Text && button6.Text != button9.Text && button9.Enabled == false) &&
                    (button2.Text == button5.Text && button5.Text != button8.Text || button2.Text != button5.Text && button5.Text == button8.Text || button2.Text != button5.Text && button5.Text != button8.Text && button8.Enabled == false) &&
                    (button1.Text == button4.Text && button4.Text != button7.Text || button1.Text != button4.Text && button4.Text == button7.Text || button1.Text != button4.Text && button4.Text != button7.Text && button7.Enabled == false) &&
                    (button1.Text == button5.Text && button5.Text != button9.Text || button1.Text != button5.Text && button5.Text == button9.Text || button1.Text != button5.Text && button5.Text != button9.Text && button9.Enabled == false) &&
                    (button3.Text == button5.Text && button5.Text != button7.Text || button3.Text != button5.Text && button5.Text == button7.Text || button3.Text != button5.Text && button5.Text != button7.Text && button7.Enabled == false))   //2 sposob draw
                {
                    MessageBox.Show("DRAW!");
                    Application.Restart();
                    count = 0;
                }*/


            }
            private void restartGameToolStripMenuItem_Click(object sender, EventArgs e)
            {
                Application.Restart();
            }

            private void xToolStripMenuItem_Click(object sender, EventArgs e)
            {
                if (!GameStart)
                {
                    xClick = true;
                }
            }

            private void oToolStripMenuItem_Click(object sender, EventArgs e)
            {
                if (!GameStart)
                {
                    xClick = false;
                }
            }

            private void creatorToolStripMenuItem1_Click(object sender, EventArgs e)
            {
                MessageBox.Show("Viacheslav Klymov 24046, grupa 2 Informatyka 2 rok stac");
            }

            private void rulesToolStripMenuItem_Click(object sender, EventArgs e)
            {
                MessageBox.Show("1. The game is played on a grid that's 3 squares by 3 squares." +
                    " 2.You are X, your friend is O. Players take turns putting their marks in empty squares." +
                    " 3.The first player, which get 3 of her marks in a row(up, down, across, or diagonally) is the winner." +
                    " 4.When all 9 squares are full, the game is over.If no player has 3 marks in a row, the game ends by draw.");
            }

        private void scoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Score is here: D:\\score.txt ");
        }
    }
}
