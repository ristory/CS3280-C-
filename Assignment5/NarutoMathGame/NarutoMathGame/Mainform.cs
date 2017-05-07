using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NarutoMathGame
{
    public partial class Form1 : Form
    {
        
        /// <summary>
        /// Class that holds the high scores.
        /// </summary>
        HighScores HighScoresForm;

        /// <summary>
        /// Class that holds the user data.
        /// </summary>
        UserInformation UserInformationForm;

        /// <summary>
        /// Class where the game is played.
        /// </summary>
        Playgame PlaygameForm;

        /// <summary>
        /// Class that holds the Game Type
        /// </summary>

        GameRules GameRulesform;
        
        public Form1()
        {
            InitializeComponent();
            ///Set up the timer
            this.Hide();

            this.HighScoresForm = new HighScores();
            this.UserInformationForm = new UserInformation();
            Playgame PlaygameForm = new Playgame();
            button2.Enabled = false;
          
            //Pass the high scores form to the game form.  This way the high scores form may be displayed via the game form.
            PlaygameForm.frmCopyHighScores = HighScoresForm;         
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Hide the menu
                this.Hide();
                //Show the game form
                UserInformationForm.ShowDialog();
                button2.Enabled = true;
                //Show the main form
                this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("We need to handle Error Exception");
            }
        }

        public void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Need to choose what type of game
                this.Hide();
                SoundPlayer simpleSound = new SoundPlayer("naruto3.wav");
                simpleSound.Play();
                GameRules Gamerulesform = new GameRules();
                Playgame PlaygameForm = new Playgame();
                if (radioAdd.Checked)
                {
                    //Hide the menu
                    this.Hide();

                    PlaygameForm.gametype = "add";

                    //Show the game form 

                    PlaygameForm.ShowDialog();
                    //Show the main form
                    this.Show();
                }
                else if (radioSubtract.Checked)
                {
                    //Hide the menu
                    this.Hide();
                    //Show the game form

                    PlaygameForm.gametype = "subtract";

                    //Show the game form 
                    PlaygameForm.ShowDialog();
                    //Show the main form
                    this.Show();
                }
                else if (radioMultiply.Checked)
                {
                    //Hide the menu
                    this.Hide();

                    PlaygameForm.gametype = "multiply";

                    //Show the game form         
                    PlaygameForm.ShowDialog();
                    //Show the main form
                    this.Show();
                }
                else if (radioDivide.Checked)
                {
                    //Hide the menu
                    this.Hide();

                    PlaygameForm.gametype = "divide";

                    //Show the game form           
                    PlaygameForm.ShowDialog();
                    //Show the main form
                    this.Show();
                }

                else
                {
                    MessageBox.Show("You need to choose game type");
                    this.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("We need to handle Error Exception");
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            
                //Hide the menu
                this.Hide();
                //Show the game form
                HighScoresForm.ShowDialog();
                //Show the main form
                this.Show();                     

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
                //Hide the menu
                this.Hide();
                //Show the game form
                UserInformationForm.ShowDialog();
                //Show the main form
                this.Show();
           
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
        
    }
}

