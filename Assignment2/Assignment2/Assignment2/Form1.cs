using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if( richTextBox2.Text == "1")
            {
                int l = Int32.Parse(label34.Text);
                l += 1;
                label34.Text = l.ToString();
            }
            if (richTextBox2.Text == "2")
            {
                int l1 = Int32.Parse(label33.Text);
                l1 += 1;
                label33.Text = l1.ToString();
            }
            if (richTextBox2.Text == "3")
            {
                int l2 = Int32.Parse(label32.Text);
                l2 += 1;
                label32.Text = l2.ToString();
            }
            if (richTextBox2.Text == "4")
            {
                int l3 = Int32.Parse(label31.Text);
                l3 += 1;
                label31.Text = l3.ToString();
            }
            if (richTextBox2.Text == "5")
            {
                int l4 = Int32.Parse(label30.Text);
                l4 += 1;
                label30.Text = l4.ToString();
            }
            if (richTextBox2.Text == "6")
            {
                int l5 = Int32.Parse(label29.Text);
                l5 += 1;
                label29.Text = l5.ToString();
            }


            int x = Int32.Parse(label2.Text);
            x += 1;
            label2.Text = x.ToString();
            try
            {
                Random random = new Random();
                int i = random.Next(1, 7);
                object O = Properties.Resources.ResourceManager.GetObject("die" + i.ToString());
                pictureBox1.Image = (Image)O;

                pictureBox1.Refresh();
                System.Threading.Thread.Sleep(300);

                if (i == 1)
                {
                    int q = Int32.Parse(label15.Text);
                    q += 1;
                    label15.Text = q.ToString();
                    q.ToString();

                    var s = ((double)q / x);
                    label27.Text = (String.Format("{0:P}", s)).ToString();


                }
                if (i == 2)
                {
                    int w = Int32.Parse(label16.Text);
                    w += 1;
                    label16.Text = w.ToString();
                    var d = ((double)w / x);
                    label26.Text = (String.Format("{0:P}", d)).ToString();
                }
                if (i == 3)
                {
                    int r = Int32.Parse(label20.Text);
                    r += 1;
                    label20.Text = r.ToString();
                    var d = ((double)r / x);
                    label25.Text = (String.Format("{0:P}", d)).ToString();
                }
                if (i == 4)
                {
                    int t= Int32.Parse(label19.Text);
                    t += 1;
                    label19.Text = t.ToString();
                    var f = ((double)t / x);
                    label24.Text = (String.Format("{0:P}", f)).ToString();
                }
             
                if (i == 5)
                {
                    int y = Int32.Parse(label18.Text);
                    y += 1;
                    label18.Text = y.ToString();
                    var g = ((double)y / x);
                    label23.Text = (String.Format("{0:P}", g)).ToString();
                }
                if (i == 6)
                {
                    int u = Int32.Parse(label17.Text);
                    u += 1;
                    label17.Text = u.ToString();
                    var h = ((double)u / x);
                    label22.Text = (String.Format("{0:P}", h)).ToString();
                }

                if (richTextBox2.Text == i.ToString())
                {
                    int y = Int32.Parse(label3.Text);
                    y += 1;
                    label3.Text = y.ToString();

                    MessageBox.Show("You won");
                    
                }
                else
                {
                    int z = Int32.Parse(label6.Text);
                    z += 1;
                    label6.Text = z.ToString();

                    MessageBox.Show("You Wrong");
                }

            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("Please check the path.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            richTextBox2.MaxLength = 1;
            if (System.Text.RegularExpressions.Regex.IsMatch(richTextBox2.Text, "[^1-6]"))
            {
                label36.Text = ("Please check the number.");
                
            }
            
         



        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
       
        }
       
        private void richTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "0";
            label3.Text = "0";
            label6.Text = "0";
            label15.Text = "0";
            label16.Text = "0";
            label17.Text = "0";
            label18.Text = "0";
            label19.Text = "0";
            label20.Text = "0";
            label27.Text = "0";
            label26.Text = "0";
            label25.Text = "0";
            label24.Text = "0";
            label23.Text = "0";
            label22.Text = "0";
            label34.Text = "0";
            label33.Text = "0";
            label32.Text = "0";
            label31.Text = "0";
            label30.Text = "0";
            label29.Text = "0";
            richTextBox2.Clear();
            MessageBox.Show("Game is reset");
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }
    }
}
