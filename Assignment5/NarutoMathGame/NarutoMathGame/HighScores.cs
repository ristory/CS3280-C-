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
    public partial class HighScores : Form
    {
       
        public string TheValue
        {
            get { return textBox1.Text; }
        }
        public HighScores()
        {
            InitializeComponent();
            textBox1.Focus();
            User Userform = new User();                      
        }
      
        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
                    
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
      
    }
   

    }
