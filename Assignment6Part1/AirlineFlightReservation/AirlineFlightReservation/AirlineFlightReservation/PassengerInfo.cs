using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineFlightReservation
{
    public partial class PassengerInfo : Form
    {
        /// <summary>
        /// add the location for first name and last name
        /// </summary>
        private string firstname;
        private string lastname;

        public PassengerInfo()
        {
            InitializeComponent();          
        }
 

        private void button1_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// create the condition for statment
            /// </summary>
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter the First Name");
            }

            else if ( textBox2.Text == "")
            {
                MessageBox.Show("Please enter the Last Name");
            }

            else
            {
                /// <summary>
                /// assign the value 
                /// </summary>
                firstname = textBox1.Text;
                lastname = textBox2.Text;

                /// <summary>
                /// hide the current windows form
                /// </summary>
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            /// <summary>
            /// hide the current windows form
            /// </summary>
            this.Hide();
        
        }
    }
}
