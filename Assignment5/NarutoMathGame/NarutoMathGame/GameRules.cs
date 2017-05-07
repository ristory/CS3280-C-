using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NarutoMathGame
{
    public class GameRules 
    {
        private HighScores CopyHighScores;
        private Random rand = new Random();
        private int count = 0;
        public int point = 0;
        private int c;       
        private string gametype;
        /// <summary>
        /// Class where the game is played.
        /// </summary>
       
        GameRules GameRulesform;
        User Userform;
        private Playgame PlaygameForm;

        Stopwatch stopWatch = new Stopwatch();
        UserInformation informationform;

        public string gametypeform
        { get { return gametype; } set { gametype = value; } }

      
        public HighScores frmCopyHighScores
        {
            get { return CopyHighScores; }
            set { CopyHighScores = value; }
        }

        public void add(Playgame PlaygameForm)
        {
            
            int a = rand.Next(1, 10);
            int b = rand.Next(1, 10);
            PlaygameForm.labelfirst.Text = a.ToString();
            PlaygameForm.labelsecond.Text = b.ToString();
            c = a + b;
            PlaygameForm.labelmethod.Text = "+";
        }

        public void subtract(Playgame PlaygameForm)
        {
            int a = rand.Next(1, 10);
            int b = rand.Next(1, 10);
            PlaygameForm.labelfirst.Text = a.ToString();
            PlaygameForm.labelsecond.Text = b.ToString();
            c = a - b;
            PlaygameForm.labelmethod.Text = "-";
        }

        public void multiply(Playgame PlaygameForm)
        {
            int a = rand.Next(1, 10);
            int b = rand.Next(1, 10);
            PlaygameForm.labelfirst.Text = a.ToString();
            PlaygameForm.labelsecond.Text = b.ToString();
            c = a * b;
            PlaygameForm.labelmethod.Text = "*";
        }

        public void divide(Playgame PlaygameForm)
        {
            int a = rand.Next(2, 10) * 2;
            int b = 2;
            PlaygameForm.labelfirst.Text = a.ToString();
            PlaygameForm.labelsecond.Text = b.ToString();
            c = a / b;
            PlaygameForm.labelmethod.Text = "/";
        }

       public void gamestart(Playgame PlaygameForm)
        {

            stopWatch.Start();

            if (count != 10)
            {
                count++;
                PlaygameForm.label6.Text = "Q" + count;
                if (PlaygameForm.gametype == "add")
                {
                    add(PlaygameForm);

                }
                else if (PlaygameForm.gametype == "subtract")
                {
                    subtract(PlaygameForm);
                }
                else if (PlaygameForm.gametype == "multiply")
                {
                    multiply(PlaygameForm);
                }
                else if (PlaygameForm.gametype == "divide")
                {
                    divide(PlaygameForm);
                }
            }
            else if (count == 10)
            {
                stopWatch.Stop();
                TimeSpan ts = stopWatch.Elapsed;
                string elapsedTime = String.Format("{0:00}", ts.Seconds);

                //Hide the menu
                PlaygameForm.Close();
                //Show the game form

                CopyHighScores = new HighScores();
                Userform = new User();
                frmCopyHighScores.label1.Text = "Your score is " + point + " point" + " time: " + elapsedTime + "s";

                
                Userform.showscore1(frmCopyHighScores);
                Userform.showscore(frmCopyHighScores);
                CopyHighScores.ShowDialog();              
                
            }
        }

        public void checkanswer(Playgame PlaygameForm)
        {
             
                if (c == Convert.ToInt16(PlaygameForm.input.Text))
                {
                    point++;
                    PlaygameForm.labelcorect.Text = "Correct!! Get one Point for your Village";
                }
                else
                {
                    PlaygameForm.labelcorect.Text = "Incorect.The right answer is " + c;
                }
            
        }
        public void specialpoint(Playgame PlaygameForm)
        {
           
            if (point == 1 && count == 2)
            {
                PlaygameForm.labelcorect.Text = "Good job!!!more point to be come a NINJA...";

            }
            else if (point == 3 && count == 4)
            {

                PlaygameForm.labelcorect.Text = "You become KAKASHI....";
                PlaygameForm.pictureBox1.ImageLocation = @"source\naruto10.jpg";
                PlaygameForm.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            else if (point == 6 && count == 7)
            {
                PlaygameForm.labelcorect.Text = "You become JIRAIYA"; ;
                PlaygameForm.pictureBox1.ImageLocation = @"source\Jiraiya_pose.png";
                PlaygameForm.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            }

            else if (point == 9)
            {
                PlaygameForm.labelcorect.Text = "You become NARUTO"; 
                PlaygameForm.pictureBox1.ImageLocation = @"source\naruto13.jpg";
                PlaygameForm.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
