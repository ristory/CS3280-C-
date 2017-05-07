using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NarutoMathGame
{
    public class User
    {
        /// <summary>
        /// Create the high scores list.
        /// </summary>
        List<Score> lstHighScores = new List<Score>();
        private string sUsersName;
        private string Aage;
       

        UserInformation informationform;
        HighScores HighScoresform;
        GameRules GameRulesform;
        private string currentname1;
        private string currentage1;
        

        public string currentnameform1
        { get { return this.currentname1; } set { this.currentname1 = value; } }

        public string currentageform
        { get { return this.currentage1; } set { this.currentage1 = value; } }


        public void editinformation(UserInformation informationform)
        {
            informationform = new UserInformation();
            this.showscore1(HighScoresform);
            for (int i = 0; i < 15; i++)
            {
                              
            }
        }
        public void submitscore(UserInformation informationform)
        {
            
            this.currentname1 = informationform.currentnameform;
            this.currentage1 = informationform.currentageform;

        }

        public void showscore1(HighScores HighScoresform)
            {

            HighScoresform.textBox1.Focus();

            for (int i = 0; i < 10; i++)
            {
                ////////////////////////////////////////////////////////Creating 10 high scores but I am ordering them correctly
                lstHighScores.Add(new Score
                {
                 
                    iScore = (10 - i),
                    iTime = (10 * (i + 1)),
                    Name = "Ninja " + (i + 1).ToString(),
                    Age = "8"
                });
            }
            DisplayTopTenHighScores(HighScoresform);

        }



        /// <summary>
        /// Holds a single score for the top 10 scores list.
        /// </summary>

        public void showscore(HighScores HighScoresform)
        {
            using (informationform = new UserInformation())
            {
                submitscore(informationform);
            }
                //Get the user's name, number correct, and time the game was completed in
             this.sUsersName = "Hoang";
             this.Aage = "28";
             int iUsersScore = 10;      
             int iUsersTime = 2;
            //Create a new Score object with the current users information
            Score CurrentUsersScore = new Score()
            { Name = sUsersName, iScore = iUsersScore, iTime = iUsersTime, Age = Aage };

            //Loop through the top 10 high scores
            for (int i = 0; i < 10; i++)
            {
                //Is the user's score greater than the current top ten high score
                if (iUsersScore > lstHighScores[i].iScore)
                {
                    //The user's score has beat the current score in the list so insert the user's score
                    lstHighScores.Insert(i, CurrentUsersScore);
                    //Remove the last score in the list
                    lstHighScores.RemoveAt(10);
                    break;
                }
                else if (iUsersScore == lstHighScores[i].iScore)    //Are the scores the same
                {
                    //Did the user's time beat the current high scores time
                    if (lstHighScores[i].iTime > iUsersTime)
                    {
                        //User's time was less than the current high scores time
                        lstHighScores.Insert(i, CurrentUsersScore);
                        //Remove the last score in the list
                        lstHighScores.RemoveAt(10);
                        break;
                    }
                }
            }
            DisplayTopTenHighScores(HighScoresform);
        }
        private void DisplayTopTenHighScores(HighScores HighScoresform)
        {
            
            HighScoresform.richTextBox1.Text = "";

            //Loop through the top 10 high scores and display them
            for (int i = 0; i < 10; i++)
            {
                HighScoresform.richTextBox1.Text += lstHighScores[i].Name.PadRight(10) + "\t" + lstHighScores[i].Age + "\t" + lstHighScores[i].iScore.ToString() + "\t" + lstHighScores[i].iTime.ToString() + Environment.NewLine;
            }
        }
    }
}
    
    public class Score
    {
        public int iScore { get; set; }
        public int iTime { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        
}



