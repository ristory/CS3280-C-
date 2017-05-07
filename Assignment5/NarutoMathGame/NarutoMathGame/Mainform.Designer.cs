namespace NarutoMathGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.radioMultiply = new System.Windows.Forms.RadioButton();
            this.radioDivide = new System.Windows.Forms.RadioButton();
            this.radioAdd = new System.Windows.Forms.RadioButton();
            this.radioSubtract = new System.Windows.Forms.RadioButton();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(272, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Math Main Menu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(339, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(254, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "Enter User Information";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.Location = new System.Drawing.Point(339, 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(254, 51);
            this.button2.TabIndex = 2;
            this.button2.Text = "Play game:";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Lime;
            this.button3.Location = new System.Drawing.Point(339, 266);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(254, 51);
            this.button3.TabIndex = 3;
            this.button3.Text = "High Scores:";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // radioMultiply
            // 
            this.radioMultiply.AutoSize = true;
            this.radioMultiply.BackColor = System.Drawing.Color.Aqua;
            this.radioMultiply.Location = new System.Drawing.Point(615, 181);
            this.radioMultiply.Name = "radioMultiply";
            this.radioMultiply.Size = new System.Drawing.Size(76, 21);
            this.radioMultiply.TabIndex = 4;
            this.radioMultiply.TabStop = true;
            this.radioMultiply.Text = "Multiply";
            this.radioMultiply.UseVisualStyleBackColor = false;
            this.radioMultiply.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioDivide
            // 
            this.radioDivide.AutoSize = true;
            this.radioDivide.BackColor = System.Drawing.Color.Aqua;
            this.radioDivide.Location = new System.Drawing.Point(615, 151);
            this.radioDivide.Name = "radioDivide";
            this.radioDivide.Size = new System.Drawing.Size(68, 21);
            this.radioDivide.TabIndex = 5;
            this.radioDivide.TabStop = true;
            this.radioDivide.Text = "Divide";
            this.radioDivide.UseVisualStyleBackColor = false;
            // 
            // radioAdd
            // 
            this.radioAdd.AutoSize = true;
            this.radioAdd.BackColor = System.Drawing.Color.Aqua;
            this.radioAdd.Location = new System.Drawing.Point(263, 151);
            this.radioAdd.Name = "radioAdd";
            this.radioAdd.Size = new System.Drawing.Size(54, 21);
            this.radioAdd.TabIndex = 6;
            this.radioAdd.TabStop = true;
            this.radioAdd.Text = "Add";
            this.radioAdd.UseVisualStyleBackColor = false;
            this.radioAdd.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioSubtract
            // 
            this.radioSubtract.AutoSize = true;
            this.radioSubtract.BackColor = System.Drawing.Color.Aqua;
            this.radioSubtract.Location = new System.Drawing.Point(235, 181);
            this.radioSubtract.Name = "radioSubtract";
            this.radioSubtract.Size = new System.Drawing.Size(82, 21);
            this.radioSubtract.TabIndex = 7;
            this.radioSubtract.TabStop = true;
            this.radioSubtract.Text = "Subtract";
            this.radioSubtract.UseVisualStyleBackColor = false;
            this.radioSubtract.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Lime;
            this.button4.Location = new System.Drawing.Point(339, 337);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(254, 51);
            this.button4.TabIndex = 8;
            this.button4.Text = "Edit User Information";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(896, 415);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.radioSubtract);
            this.Controls.Add(this.radioAdd);
            this.Controls.Add(this.radioDivide);
            this.Controls.Add(this.radioMultiply);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton radioMultiply;
        private System.Windows.Forms.RadioButton radioDivide;
        private System.Windows.Forms.RadioButton radioAdd;
        private System.Windows.Forms.RadioButton radioSubtract;
        private System.Windows.Forms.Button button4;
        internal System.Windows.Forms.Button button2;
    }
}

