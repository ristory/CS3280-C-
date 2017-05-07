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
    public partial class UserInformation : Form
    {
        User Userform;
        HighScores HighScoresform;
        UserInformation informationform;
        private string currentname;
        private string currentage;
        public UserInformation()
        {
            InitializeComponent();
            

        }

        public string currentnameform
        { get { return this.currentname; } set { this.currentname = value; } }

        public string currentageform
        { get { return this.currentage; } set { this.currentage = value; } }

        private void button2_Click(object sender, EventArgs e)
        {
            //Hide user data form
            this.Hide();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (richTextBox1.Text == "")
                {
                    MessageBox.Show("Please Enter the Valid Name");
                }
                else if (richTextBox2.Text == "")
                {
                    MessageBox.Show("Please Enter the  Valid Age");
                }

                else
                {
                    this.currentname = richTextBox1.Text;
                    this.currentage = richTextBox2.Text;
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("We need to handle Error Exception");
            }

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Userform = new User();
                Userform.editinformation(informationform);
            }
            catch (Exception ex)
            {
                MessageBox.Show("We need to handle Error Exception");
            }
        }

        private void richTextBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void UserInformation_Load(object sender, EventArgs e)
        {

        }
    }
}
