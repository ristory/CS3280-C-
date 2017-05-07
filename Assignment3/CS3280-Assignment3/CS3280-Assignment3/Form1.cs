using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS3280_Assignment3
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        
        String[] studentnumber = new String[10];
        int[,] studentscore = new int[10,99];

        /// <summary>  
        ///  This class performs submit Counts.  
        /// </summary>  
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Convert.ToInt32(richTextBox1.Text); i++)
            {
                for (int j = 0; j < Convert.ToInt32(richTextBox2.Text); j++)
                {
                    studentscore[i, j] = 0;
                }
            }
                for (int i = 1; i < Convert.ToInt32(richTextBox1.Text) + 1; i++)
                {
                    studentnumber[i - 1] = "Student#" + i;
                }
            richTextBox3.Text = studentnumber[0];
            label4.Text = "Enter Assignment Number (1-" + richTextBox2.Text + "):";


        }

        /// <summary>  
        ///  This class performs number of students.  
        /// </summary>  

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
            richTextBox1.MaxLength = 2;
            int num1;
            if (int.TryParse(richTextBox1.Text, out num1) && Convert.ToInt32(richTextBox1.Text) < 11)
            {

            }
            else
            {
                MessageBox.Show("Invalid Input!");
            }

        }

        /// <summary>  
        ///  This class performs number of assignments.  
        /// </summary>

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            richTextBox2.MaxLength = 2;
            int num2;
            if (int.TryParse(richTextBox2.Text, out num2))
            {

            }
            else
            {
                MessageBox.Show("Invalid Input!");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        /// <summary>  
        ///  This class performs enter assignment.  
        /// </summary>  
        /// 
        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {
            richTextBox4.MaxLength = 2;
           
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
         
        }

        /// <summary>  
        ///  This class performs save name of students.  
        /// </summary>  

        private void button7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Convert.ToInt32(richTextBox1.Text); i++)
            { 
                if (label3.Text == studentnumber[i])
                    studentnumber[i] = richTextBox3.Text;
                    label3.Text = richTextBox3.Text;
                    
             }

        }

        /// <summary>  
        ///  This class performs Prev student.  
        /// </summary> 
        /// 
        private void button3_Click(object sender, EventArgs e)
        {

            for (int i = 1; i < Convert.ToInt32(richTextBox1.Text) + 1; i++)

                if (richTextBox3.Text == studentnumber[i])
                {
                    richTextBox3.Text = studentnumber[i - 1];
                    label3.Text = studentnumber[i - 1];
                    break;
                }
           
                
            
        }

        /// <summary>  
        ///  This class performs next student.  
        /// </summary>  
        /// 
        private void button4_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < Convert.ToInt32(richTextBox1.Text) -1; i++)

                if (richTextBox3.Text == studentnumber[i])
                {
                    richTextBox3.Text = studentnumber[i + 1];
                    label3.Text = studentnumber[i + 1];
                    break;
                }

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        /// <summary>  
        ///  This class performs enter score.  
        /// </summary>  
        /// 
        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        /// <summary>  
        ///  This class performs last student.  
        /// </summary>  

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox3.Text = studentnumber[Convert.ToInt32(richTextBox1.Text) - 1 ];
            label3.Text = studentnumber[Convert.ToInt32(richTextBox1.Text) - 1];
        }

        /// <summary>  
        ///  This class performs first of student.  
        /// </summary>
        /// 
        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox3.Text = studentnumber[0];
            label3.Text = studentnumber[0];
        }

        /// <summary>  
        ///  This class performs display score.  
        /// </summary>  

        private void button9_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < Convert.ToInt32(richTextBox1.Text); i++)
            {
                
                for (int j = 0; j < Convert.ToInt32(richTextBox2.Text); j++)
                {
                        if (studentscore== null)
                            {
                               // label6.Text = "";
                            }              
                    label6.Text += studentscore[i, j].ToString()+"   ";                
                }
                label6.Text += "\n";
            }

            
            for (int i = 0; i < Convert.ToInt32(richTextBox1.Text); i++)
            {
                lblSingle1.Text += studentnumber[i];
                lblSingle1.Text += "\n";

                int totalScore=0;
                int totalAssignment=0;
                for (int j=0; j < Convert.ToInt32(richTextBox2.Text); j++)
                {
                    totalScore += studentscore[i, j];
                    totalAssignment++; 
                }
                label11.Text += (totalScore /totalAssignment).ToString();
                label11.Text += "\n";

                double d = totalScore / totalAssignment;
                if (d <= 100 && d >= 93)
                    label12.Text += "A"; 
               else if (d < 93 && d >= 90)
                    label12.Text += "A-";

                else if (d < 87 && d >= 83)
                    label12.Text += "B";

                else if (d < 83 && d >= 80)
                    label12.Text += "B-";

                else if (d < 80 && d >= 73)
                    label12.Text += "C";

               else if (d < 70 && d >= 60)
                    label12.Text += "D";            
                else if (d < 60)
                    label12.Text += "E";
                label12.Text += "\n";
            }

        }
        /// <summary>  
        ///  This class performs Reset data.  
        /// </summary>  
        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            richTextBox3.Text = "";
            richTextBox4.Text = "";
            richTextBox5.Text = "";
            lblSingle1.Text = "";
            label6.Text = "\n";
            //label7.Text = "#2";
            //label8.Text = "#3";
            //label9.Text = "#4";
            //label10.Text = "#5";
            label12.Text = "";
            label11.Text = "";
            label13.Text = "Student";
        }

        /// <summary>  
        ///  This class performs save score.  
        /// </summary>  

        private void button8_Click(object sender, EventArgs e)
        {
            string s = label3.Text;
            //string[] s1 = s.Split('#');

            for (int k = 0;k<studentnumber.Length ; k++)
            {
                if (label3.Text == studentnumber[k]) 
                {

                    studentscore[k, Convert.ToInt32(richTextBox4.Text)-1] = Convert.ToInt32(richTextBox5.Text);

                    /*for (int i = 0; i < Convert.ToInt32(richTextBox1.Text); i++)
                        for (int j = 0; j < Convert.ToInt32(richTextBox2.Text); j++)
                            if (Convert.ToInt32(richTextBox4.Text) == j+1&& k == i)
                            {
                                studentscore[i, j] = Convert.ToInt32(richTextBox5.Text);
                            }
                       */

                }
            }
            

            

                
           



        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        /// <summary>  
        ///  This class performs grade of student.  
        /// </summary> 
        private void label12_Click_1(object sender, EventArgs e)
        {

        }

        /// <summary>  
        ///  This class performs score #1.  
        /// </summary>  
        private void label6_Click(object sender, EventArgs e)
        {

        }

        /// <summary>  
        ///  This class performs student name.  
        /// </summary>  

        private void lblSingle1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>  
        ///  This class performs score#3.  
        /// </summary>  

        private void label8_Click(object sender, EventArgs e)
        {

        }
        /// <summary>  
        ///  This class performs score#4.  
        /// </summary> 
        private void label9_Click(object sender, EventArgs e)
        {

        }
        /// <summary>  
        ///  This class performs avarage score.  
        /// </summary> 
        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click_1(object sender, EventArgs e)
        {

        }

        private void label13_Click_1(object sender, EventArgs e)
        {

        }

        /// <summary>  
        ///  This class performs score#2.  
        /// </summary>  

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }
        /// <summary>  
        ///  This class performs score#5.  
        /// </summary> 
        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click_2(object sender, EventArgs e)
        {

        }
    }
}

        
