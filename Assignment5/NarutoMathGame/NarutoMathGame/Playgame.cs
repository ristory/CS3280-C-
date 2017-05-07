using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NarutoMathGame
{

    public partial class Playgame : Form
    {
        public Label labelmethod1;
        public string gametype;
        public int a;
        public int b;
        int count = 1;
        int point = 0;
        string answer;
        GameRules GameRulesform;
        Playgame PlaygameForm;
        /// <summary>
        /// Variable to hold the high scores form.
        /// </summary>
        private HighScores CopyHighScores;
        /// A timer.
        /// </summary>
        Timer MyTimer;
       
        /// <summary>
        /// Property to get and set the high scores.
        /// </summary>
        public HighScores frmCopyHighScores
        {
            get { return CopyHighScores; }
            set { CopyHighScores = value; }
        }
      
        public Playgame()
        {
            this.GameRulesform = GameRulesform;
            InitializeComponent();
            HighScores HighScoresForm = new HighScores();
           

            ///Set up the timer
            MyTimer = new Timer();
            MyTimer.Interval = 1000;
            MyTimer.Tick += new EventHandler(label2_Click);

        }

        /// <summary>
        /// Hide the game form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
           
        }

         void label2_Click(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                GameRulesform = new GameRules();
                MyTimer.Start();


                GameRulesform.gamestart(this);


                button3.Enabled = false;
                button4.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("We need to handle Error Exception");
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                GameRulesform.checkanswer(this);
                button2.Enabled = true;
                button4.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("We need to handle Error Exception");
            }



        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                GameRulesform.gamestart(this);
                GameRulesform.specialpoint(this);
                button4.Enabled = true;
                button2.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("We need to handle Error Exception");
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    button4_Click(this, new EventArgs());
                    button2_Click_1(this, new EventArgs());
                    input.Clear();
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("We need to handle Error Exception");
            }


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Playgame_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
