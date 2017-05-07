using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Tictactoe tictac;
        bool isgamestart;
        bool turn = true;
        int turn_count = 0;
        int turnwin1 = 0;
        int turnwin2 = 0;
        int turntie = 0;
        bool winner = false;

        public Form1()
        {
            InitializeComponent();

            tictac = new Tictactoe();
            isgamestart = false;
        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// When the start button clicks.
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            isgamestart = true;
            turn = true;
            turn_count = 0;
            ClearLabels();
        }

        /// <summary>
        /// Clear label and array function
        /// </summary>
        private void ClearLabels()
        {
            foreach (Control c in this.Controls)
            {
                if (c is Label)
                {
                    ((Label)c).Enabled = true;
                    ((Label)c).Text = "";
                    if (c.Name.Substring(0,3).Equals("lbl"))
                        ((Label)c).BackColor = Color.Gray;
                }
            }
            tictac.saBoard = new string[,] { { "0", "0", "0" }, { "0", "0", "0" }, { "0", "0", "0" } };
        }


        /// <summary>
        /// The structure of game
        /// </summary>
        private void spaceclick(object sender, EventArgs e)
        {
            try
            {
                Label mylabel = (Label)sender;
                if (isgamestart && mylabel.Text == "")
                {
                    turn_count++;
                    if (turn)
                    {
                        mylabel.Text = "X";
                        mylabel.ForeColor = Color.Red;

                        for (int x = 0; x < 3; x++)
                            for (int y = 0; y < 3; y++)
                                if (mylabel.Name.Equals("lbl" + x + y))
                                {
                                    tictac.saBoard[x, y] = "X";
                                    label6.Text = ("Player 1 turn");
                                }
                                else{}
                    }

                    else
                    {
                        mylabel.Text = "O";
                        mylabel.ForeColor = Color.Blue;
                        for (int x = 0; x < 3; x++)
                            for (int y = 0; y < 3; y++)
                                if (mylabel.Name.Equals("lbl" + x + y))
                                {
                                    tictac.saBoard[x, y] = "O";
                                    label6.Text = ("Player 2 turn");
                                }
                                else{}
                    }
                    turn = !turn;
                }
                else{}

                /// <summary>
                /// when winning move is recognized
                /// </summary>
                if (tictac.IsWinningMove())
                {
                    
                    disablebuttons();
                    String winner = "";
                    if (turn)
                    {
                        turnwin2++;
                        winner = "2";
                        label7.Text = ("Player2 Win: " + turnwin2);
                    }
                    else
                    {
                        turnwin1++;
                        winner = "1";
                        label4.Text = ("Player1 Win: " + turnwin1);
                    }

                    label6.Text = ("Player " + winner + " Win");                 
                }



                /// <summary>
                /// When tie move is recognized
                /// </summary>
                if (tictac.IsTie() && turn_count == 9)
                {
                    turntie++;
                    label6.Text = ("Draw");
                    disablebuttons();
                    label8.Text = ("Tie: " + turntie);
                }
            }
            catch{}          
        }


        /// <summary>
        /// lock the game when it win or tie/
        /// </summary>
        private void disablebuttons()
        {
            string WinningLine = tictac.winningLine;
            try
            {
                foreach (Control c in Controls)
                {
                    if (c is Label)
                        ((Label)c).Enabled = false;
                }


                /// <summary>
                /// Highlight the winning move
                /// </summary>
                if (tictac.IsWinningMove())
                {
                    foreach (Control c in Controls)
                    {
                        if (c is Label && c.Name.Substring(3, 2) == WinningLine.Substring(0, 2))
                            c.BackColor = Color.Yellow;
                        if (c is Label && c.Name.Substring(3, 2) == WinningLine.Substring(2, 2))
                            c.BackColor = Color.Yellow;
                        if (c is Label && c.Name.Substring(3, 2) == WinningLine.Substring(4, 2))
                            c.BackColor = Color.Yellow;
                    }
                }
            }
            catch{}
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}

