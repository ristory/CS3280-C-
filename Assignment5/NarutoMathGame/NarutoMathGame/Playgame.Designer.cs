namespace NarutoMathGame
{
    partial class Playgame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Playgame));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelfirst = new System.Windows.Forms.Label();
            this.labelmethod = new System.Windows.Forms.Label();
            this.labelsecond = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelcorect = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tomato;
            this.button1.Location = new System.Drawing.Point(370, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(571, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Timer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(614, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "0";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelfirst
            // 
            this.labelfirst.BackColor = System.Drawing.Color.Tomato;
            this.labelfirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfirst.Location = new System.Drawing.Point(181, 40);
            this.labelfirst.Name = "labelfirst";
            this.labelfirst.Size = new System.Drawing.Size(146, 80);
            this.labelfirst.TabIndex = 4;
            this.labelfirst.Text = "0";
            this.labelfirst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelfirst.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelmethod
            // 
            this.labelmethod.BackColor = System.Drawing.Color.Tomato;
            this.labelmethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmethod.Location = new System.Drawing.Point(357, 40);
            this.labelmethod.Name = "labelmethod";
            this.labelmethod.Size = new System.Drawing.Size(83, 80);
            this.labelmethod.TabIndex = 5;
            this.labelmethod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelmethod.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelsecond
            // 
            this.labelsecond.BackColor = System.Drawing.Color.Tomato;
            this.labelsecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsecond.Location = new System.Drawing.Point(482, 40);
            this.labelsecond.Name = "labelsecond";
            this.labelsecond.Size = new System.Drawing.Size(137, 80);
            this.labelsecond.TabIndex = 6;
            this.labelsecond.Text = "0";
            this.labelsecond.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelsecond.Click += new System.EventHandler(this.label5_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Tomato;
            this.button3.Location = new System.Drawing.Point(28, 346);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(234, 48);
            this.button3.TabIndex = 7;
            this.button3.Text = "Start";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Tomato;
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(28, 277);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(234, 44);
            this.button4.TabIndex = 8;
            this.button4.Text = "Submit";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(268, 277);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(96, 44);
            this.input.TabIndex = 41;
            this.input.Text = "";
            this.input.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            this.input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBox1_KeyDown);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Tomato;
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(370, 277);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(234, 44);
            this.button2.TabIndex = 43;
            this.button2.Text = "Next Question";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Tomato;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-2, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 80);
            this.label6.TabIndex = 44;
            this.label6.Text = "Q0";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(617, 220);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 174);
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelcorect
            // 
            this.labelcorect.BackColor = System.Drawing.Color.Transparent;
            this.labelcorect.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcorect.ForeColor = System.Drawing.Color.Crimson;
            this.labelcorect.Location = new System.Drawing.Point(21, 137);
            this.labelcorect.Name = "labelcorect";
            this.labelcorect.Size = new System.Drawing.Size(765, 62);
            this.labelcorect.TabIndex = 47;
            this.labelcorect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Playgame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(809, 418);
            this.Controls.Add(this.labelcorect);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.input);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.labelsecond);
            this.Controls.Add(this.labelmethod);
            this.Controls.Add(this.labelfirst);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Playgame";
            this.Text = "Playgame";
            this.Load += new System.EventHandler(this.Playgame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        internal System.Windows.Forms.Label labelfirst;
        internal System.Windows.Forms.Label labelmethod;
        internal System.Windows.Forms.Label labelsecond;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label labelcorect;
        internal System.Windows.Forms.RichTextBox input;
        internal System.Windows.Forms.PictureBox pictureBox1;
    }
}