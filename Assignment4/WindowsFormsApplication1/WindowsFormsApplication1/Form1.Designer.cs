namespace WindowsFormsApplication1
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
            this.lbl00 = new System.Windows.Forms.Label();
            this.lbl01 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl02 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl10 = new System.Windows.Forms.Label();
            this.lbl11 = new System.Windows.Forms.Label();
            this.lbl12 = new System.Windows.Forms.Label();
            this.lbl20 = new System.Windows.Forms.Label();
            this.lbl21 = new System.Windows.Forms.Label();
            this.lbl22 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl00
            // 
            this.lbl00.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbl00.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl00.Location = new System.Drawing.Point(29, 28);
            this.lbl00.Name = "lbl00";
            this.lbl00.Size = new System.Drawing.Size(100, 100);
            this.lbl00.TabIndex = 0;
            this.lbl00.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl00.Click += new System.EventHandler(this.spaceclick);
            // 
            // lbl01
            // 
            this.lbl01.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbl01.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl01.Location = new System.Drawing.Point(135, 28);
            this.lbl01.Name = "lbl01";
            this.lbl01.Size = new System.Drawing.Size(100, 100);
            this.lbl01.TabIndex = 0;
            this.lbl01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl01.Click += new System.EventHandler(this.spaceclick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(462, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 121);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Statictics";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(19, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Player1 Win : 0";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(58, 409);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 64);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Game Status";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(484, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Start Game";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl02
            // 
            this.lbl02.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbl02.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl02.Location = new System.Drawing.Point(230, 28);
            this.lbl02.Name = "lbl02";
            this.lbl02.Size = new System.Drawing.Size(100, 100);
            this.lbl02.TabIndex = 0;
            this.lbl02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl02.Click += new System.EventHandler(this.spaceclick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(225, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 320);
            this.label1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(127, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 320);
            this.label2.TabIndex = 1;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(27, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(303, 10);
            this.label5.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(27, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(303, 10);
            this.label3.TabIndex = 6;
            // 
            // lbl10
            // 
            this.lbl10.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbl10.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl10.Location = new System.Drawing.Point(29, 138);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(100, 100);
            this.lbl10.TabIndex = 0;
            this.lbl10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl10.Click += new System.EventHandler(this.spaceclick);
            // 
            // lbl11
            // 
            this.lbl11.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbl11.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl11.Location = new System.Drawing.Point(135, 138);
            this.lbl11.Name = "lbl11";
            this.lbl11.Size = new System.Drawing.Size(100, 100);
            this.lbl11.TabIndex = 0;
            this.lbl11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl11.Click += new System.EventHandler(this.spaceclick);
            // 
            // lbl12
            // 
            this.lbl12.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbl12.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl12.Location = new System.Drawing.Point(230, 138);
            this.lbl12.Name = "lbl12";
            this.lbl12.Size = new System.Drawing.Size(100, 100);
            this.lbl12.TabIndex = 0;
            this.lbl12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl12.Click += new System.EventHandler(this.spaceclick);
            // 
            // lbl20
            // 
            this.lbl20.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbl20.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl20.Location = new System.Drawing.Point(29, 248);
            this.lbl20.Name = "lbl20";
            this.lbl20.Size = new System.Drawing.Size(100, 100);
            this.lbl20.TabIndex = 0;
            this.lbl20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl20.Click += new System.EventHandler(this.spaceclick);
            // 
            // lbl21
            // 
            this.lbl21.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbl21.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl21.Location = new System.Drawing.Point(135, 248);
            this.lbl21.Name = "lbl21";
            this.lbl21.Size = new System.Drawing.Size(100, 100);
            this.lbl21.TabIndex = 0;
            this.lbl21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl21.Click += new System.EventHandler(this.spaceclick);
            // 
            // lbl22
            // 
            this.lbl22.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbl22.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl22.Location = new System.Drawing.Point(230, 248);
            this.lbl22.Name = "lbl22";
            this.lbl22.Size = new System.Drawing.Size(100, 100);
            this.lbl22.TabIndex = 0;
            this.lbl22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl22.Click += new System.EventHandler(this.spaceclick);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 31);
            this.label6.TabIndex = 1;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(19, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "Player2 Win : 0";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(19, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "Tie : 0";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(766, 530);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl22);
            this.Controls.Add(this.lbl12);
            this.Controls.Add(this.lbl02);
            this.Controls.Add(this.lbl21);
            this.Controls.Add(this.lbl20);
            this.Controls.Add(this.lbl11);
            this.Controls.Add(this.lbl10);
            this.Controls.Add(this.lbl01);
            this.Controls.Add(this.lbl00);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.spaceclick);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl00;
        private System.Windows.Forms.Label lbl01;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl02;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl10;
        private System.Windows.Forms.Label lbl11;
        private System.Windows.Forms.Label lbl12;
        private System.Windows.Forms.Label lbl20;
        private System.Windows.Forms.Label lbl21;
        private System.Windows.Forms.Label lbl22;
        protected internal System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}

