using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Tic
{

    public partial class Form1 : Form
    {
        //private bool[] buttonGrid = new bool[9];

        private String[] buttonText = new String[9];

        private String firstSymbol = "X";
        private String secondSymbol = "O";

        private bool firstPlayerIsOne = true;
        private bool playerOnesTurn = true;
        
        private void switchTurn()
        {
            if(playerOnesTurn)
            {
                label2.Text = "Player Two's Turn.";
                playerOnesTurn = false;
            }
            else
            {
                label2.Text = "Player One's Turn.";
                playerOnesTurn = true;
            }
        }

        private void checkGridText(String[] g)
        {
            if(g[0]==g[1]&&g[1]==g[2])
            {
                whoWon(g[0]);
            }
            else if(g[3]==g[4]&&g[4]==g[5])
            {
                whoWon(g[3]);
            }
            else if(g[6]==g[7]&&g[7]==g[8])
            {
                whoWon(g[6]);
            }
            else if(g[0]==g[3]&&g[3]==g[6])
            {
                whoWon(g[0]);
            }
            else if (g[1] == g[4] && g[4] == g[7])
            {
                whoWon(g[1]);
            }
            else if (g[2] == g[5] && g[5] == g[8])
            {
                whoWon(g[2]);
            }
            else if (g[0] == g[4] && g[4] == g[8])
            {
                whoWon(g[0]);
            }
            else if (g[2] == g[4] && g[4] == g[6])
            {
                whoWon(g[0]);
            }
            for(int i=0;i<g.Length;i++)
            {
                if (g[i].Equals((i + 1).ToString()))
                {
                    return;
                }
            }
            MessageBox.Show("Tied Game!");
        }
        private void whoWon(String str)
        {
            if(firstSymbol==str&&firstPlayerIsOne)
            {
                MessageBox.Show(label3.Text + " Wins!");
            }
            else
            {
                MessageBox.Show(label4.Text + " Wins!");
            }
            //MessageBox.Show("Tied Game!");
            //reset();
        }
        public Form1()
        {
            for (int i = 1; i <= 9;i++)
            {
                buttonText[i - 1] = i.ToString();
            }
            InitializeComponent();
        }

        private void playersNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label3.Text=Interaction.InputBox("Please Enter Player One's Name", "Player's Name", "");
            label4.Text = Interaction.InputBox("Please Enter Player Two's Name", "Player's Name", "");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void reset()
        {
            label3.Text = "Player One";
            label4.Text = "Player Two";

            button1.Text = "1";
            button2.Text = "2";
            button3.Text = "3";
            button4.Text = "4";
            button5.Text = "5";
            button6.Text = "6";
            button7.Text = "7";
            button8.Text = "8";
            button9.Text = "9";
            for (int i = 1; i <= 9; i++)
            {
                buttonText[i - 1] = i.ToString();
            }

            firstSymbol = "X";
            secondSymbol = "O";

            firstPlayerIsOne = true;
            playerOnesTurn = true;

            label1.Text = "Player One goes first.";
        }
        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void playerOneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            firstPlayerIsOne = true;
            label1.Text = "Player One goes first.";

            label2.Text = "Player One's Turn.";
            playerOnesTurn = true;
        }

        private void playerTwoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            firstPlayerIsOne = false;
            label1.Text = "Player Two goes first.";

            label2.Text = "Player Two's Turn.";
            playerOnesTurn = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text!="X"&&button1.Text!="O")
            {
                if(playerOnesTurn)
                {
                    if(firstPlayerIsOne)
                    {
                        button1.Text = firstSymbol;
                        buttonText[0] = firstSymbol;
                    }
                    else
                    {
                        button1.Text = secondSymbol;
                        buttonText[0] = secondSymbol;
                    }
                    playerOnesTurn = false;
                    label2.Text = "Player Two's Turn.";
                }
                else
                {
                    if(firstPlayerIsOne)
                    {
                        button1.Text = secondSymbol;
                        buttonText[0] = secondSymbol;
                    }
                    else
                    {
                        button1.Text = firstSymbol;
                        buttonText[0] = firstSymbol;
                    }
                    playerOnesTurn = true;
                    label2.Text = "Player One's Turn.";
                }
                checkGridText(buttonText);
            }
            
        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            firstSymbol = "X";
            secondSymbol = "O";

        }

        private void oToolStripMenuItem_Click(object sender, EventArgs e)
        {
            firstSymbol = "O";
            secondSymbol = "X";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text != "X" && button2.Text != "O")
            {
                if (playerOnesTurn)
                {
                    if (firstPlayerIsOne)
                    {
                        button2.Text = firstSymbol;
                        buttonText[1] = firstSymbol;
                    }
                    else
                    {
                        button2.Text = secondSymbol;
                        buttonText[1] = secondSymbol;
                    }
                    playerOnesTurn = false;
                    label2.Text = "Player Two's Turn.";
                }
                else
                {
                    if (firstPlayerIsOne)
                    {
                        button2.Text = secondSymbol;
                        buttonText[1] = secondSymbol;
                    }
                    else
                    {
                        button2.Text = firstSymbol;
                        buttonText[1] = firstSymbol;
                    }
                    playerOnesTurn = true;
                    label2.Text = "Player One's Turn.";
                }
                checkGridText(buttonText);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text != "X" && button3.Text != "O")
            {
                if (playerOnesTurn)
                {
                    if (firstPlayerIsOne)
                    {
                        button3.Text = firstSymbol;
                        buttonText[2] = firstSymbol;
                    }
                    else
                    {
                        button3.Text = secondSymbol;
                        buttonText[2] = secondSymbol;
                    }
                    playerOnesTurn = false;
                    label2.Text = "Player Two's Turn.";
                }
                else
                {
                    if (firstPlayerIsOne)
                    {
                        button3.Text = secondSymbol;
                        buttonText[2] = secondSymbol;
                    }
                    else
                    {
                        button3.Text = firstSymbol;
                        buttonText[2] = firstSymbol;
                    }
                    playerOnesTurn = true;
                    label2.Text = "Player One's Turn.";
                }
                checkGridText(buttonText);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text != "X" && button4.Text != "O")
            {
                if (playerOnesTurn)
                {
                    if (firstPlayerIsOne)
                    {
                        button4.Text = firstSymbol;
                        buttonText[3] = firstSymbol;
                    }
                    else
                    {
                        button4.Text = secondSymbol;
                        buttonText[3] = secondSymbol;
                    }
                    playerOnesTurn = false;
                    label2.Text = "Player Two's Turn.";
                }
                else
                {
                    if (firstPlayerIsOne)
                    {
                        button4.Text = secondSymbol;
                        buttonText[3] = secondSymbol;
                    }
                    else
                    {
                        button4.Text = firstSymbol;
                        buttonText[3] = firstSymbol;
                    }
                    playerOnesTurn = true;
                    label2.Text = "Player One's Turn.";
                }
                checkGridText(buttonText);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text != "X" && button5.Text != "O")
            {
                if (playerOnesTurn)
                {
                    if (firstPlayerIsOne)
                    {
                        button5.Text = firstSymbol;
                        buttonText[4] = firstSymbol;
                    }
                    else
                    {
                        button5.Text = secondSymbol;
                        buttonText[4] = secondSymbol;
                    }
                    playerOnesTurn = false;
                    label2.Text = "Player Two's Turn.";
                }
                else
                {
                    if (firstPlayerIsOne)
                    {
                        button5.Text = secondSymbol;
                        buttonText[4] = secondSymbol;
                    }
                    else
                    {
                        button5.Text = firstSymbol;
                        buttonText[4] = firstSymbol;
                    }
                    playerOnesTurn = true;
                    label2.Text = "Player One's Turn.";
                }
                checkGridText(buttonText);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text != "X" && button6.Text != "O")
            {
                if (playerOnesTurn)
                {
                    if (firstPlayerIsOne)
                    {
                        button6.Text = firstSymbol;
                        buttonText[5] = firstSymbol;
                    }
                    else
                    {
                        button6.Text = secondSymbol;
                        buttonText[5] = secondSymbol;
                    }
                    playerOnesTurn = false;
                    label2.Text = "Player Two's Turn.";
                }
                else
                {
                    if (firstPlayerIsOne)
                    {
                        button6.Text = secondSymbol;
                        buttonText[5] = secondSymbol;
                    }
                    else
                    {
                        button6.Text = firstSymbol;
                        buttonText[5] = firstSymbol;
                    }
                    playerOnesTurn = true;
                    label2.Text = "Player One's Turn.";
                }
                checkGridText(buttonText);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text != "X" && button7.Text != "O")
            {
                if (playerOnesTurn)
                {
                    if (firstPlayerIsOne)
                    {
                        button7.Text = firstSymbol;
                        buttonText[6] = firstSymbol;
                    }
                    else
                    {
                        button7.Text = secondSymbol;
                        buttonText[6] = secondSymbol;
                    }
                    playerOnesTurn = false;
                    label2.Text = "Player Two's Turn.";
                }
                else
                {
                    if (firstPlayerIsOne)
                    {
                        button7.Text = secondSymbol;
                        buttonText[6] = secondSymbol;
                    }
                    else
                    {
                        button7.Text = firstSymbol;
                        buttonText[6] = firstSymbol;
                    }
                    playerOnesTurn = true;
                    label2.Text = "Player One's Turn.";
                }
                checkGridText(buttonText);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text != "X" && button8.Text != "O")
            {
                if (playerOnesTurn)
                {
                    if (firstPlayerIsOne)
                    {
                        button8.Text = firstSymbol;
                        buttonText[7] = firstSymbol;
                    }
                    else
                    {
                        button8.Text = secondSymbol;
                        buttonText[7] = secondSymbol;
                    }
                    playerOnesTurn = false;
                    label2.Text = "Player Two's Turn.";
                }
                else
                {
                    if (firstPlayerIsOne)
                    {
                        button8.Text = secondSymbol;
                        buttonText[7] = secondSymbol;
                    }
                    else
                    {
                        button8.Text = firstSymbol;
                        buttonText[7] = firstSymbol;
                    }
                    playerOnesTurn = true;
                    label2.Text = "Player One's Turn.";
                }
                checkGridText(buttonText);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text != "X" && button9.Text != "O")
            {
                if (playerOnesTurn)
                {
                    if (firstPlayerIsOne)
                    {
                        button9.Text = firstSymbol;
                        buttonText[8] = firstSymbol;
                    }
                    else
                    {
                        button9.Text = secondSymbol;
                        buttonText[8] = secondSymbol;
                    }
                    playerOnesTurn = false;
                    label2.Text = "Player Two's Turn.";
                }
                else
                {
                    if (firstPlayerIsOne)
                    {
                        button9.Text = secondSymbol;
                        buttonText[8] = secondSymbol;
                    }
                    else
                    {
                        button9.Text = firstSymbol;
                        buttonText[8] = firstSymbol;
                    }
                    playerOnesTurn = true;
                    label2.Text = "Player One's Turn.";
                }
                checkGridText(buttonText);
            }
        }
    }
}
