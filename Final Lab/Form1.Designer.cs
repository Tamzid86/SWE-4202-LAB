namespace Final_Lab
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.attendancetxt = new System.Windows.Forms.Label();
            this.quiz1txt = new System.Windows.Forms.Label();
            this.quiz2txt = new System.Windows.Forms.Label();
            this.quiz3txt = new System.Windows.Forms.Label();
            this.quiztotaltxt = new System.Windows.Forms.Label();
            this.midtxt = new System.Windows.Forms.Label();
            this.finaltxt = new System.Windows.Forms.Label();
            this.vivatxt = new System.Windows.Forms.Label();
            this.totaltxt = new System.Windows.Forms.Label();
            this.percenttxt = new System.Windows.Forms.Label();
            this.gradetxt = new System.Windows.Forms.Label();
            this.quiz4txt = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(28, 47);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(360, 319);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // idtxt
            // 
            this.idtxt.Location = new System.Drawing.Point(560, 47);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(124, 23);
            this.idtxt.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(584, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(560, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Attendace:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(560, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quiz 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(560, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quiz 3:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(560, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Quiz 2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(560, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Viva:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(560, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Final:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(560, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Mid:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(560, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Quiz Total(Best 3):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(632, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(168, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Developed by : 200042145";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(560, 406);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 15);
            this.label10.TabIndex = 13;
            this.label10.Text = "Grade:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(560, 381);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 15);
            this.label11.TabIndex = 12;
            this.label11.Text = "Percent:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(560, 355);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 15);
            this.label12.TabIndex = 11;
            this.label12.Text = "Total(Out of 300):";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(489, 50);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 15);
            this.label13.TabIndex = 15;
            this.label13.Text = "Student ID:";
            // 
            // attendancetxt
            // 
            this.attendancetxt.AutoSize = true;
            this.attendancetxt.Location = new System.Drawing.Point(630, 122);
            this.attendancetxt.Name = "attendancetxt";
            this.attendancetxt.Size = new System.Drawing.Size(12, 15);
            this.attendancetxt.TabIndex = 16;
            this.attendancetxt.Text = "-";
            // 
            // quiz1txt
            // 
            this.quiz1txt.AutoSize = true;
            this.quiz1txt.Location = new System.Drawing.Point(609, 148);
            this.quiz1txt.Name = "quiz1txt";
            this.quiz1txt.Size = new System.Drawing.Size(12, 15);
            this.quiz1txt.TabIndex = 17;
            this.quiz1txt.Text = "-";
            // 
            // quiz2txt
            // 
            this.quiz2txt.AutoSize = true;
            this.quiz2txt.Location = new System.Drawing.Point(609, 173);
            this.quiz2txt.Name = "quiz2txt";
            this.quiz2txt.Size = new System.Drawing.Size(12, 15);
            this.quiz2txt.TabIndex = 18;
            this.quiz2txt.Text = "-";
            // 
            // quiz3txt
            // 
            this.quiz3txt.AutoSize = true;
            this.quiz3txt.Location = new System.Drawing.Point(609, 199);
            this.quiz3txt.Name = "quiz3txt";
            this.quiz3txt.Size = new System.Drawing.Size(12, 15);
            this.quiz3txt.TabIndex = 19;
            this.quiz3txt.Text = "-";
            // 
            // quiztotaltxt
            // 
            this.quiztotaltxt.AutoSize = true;
            this.quiztotaltxt.Location = new System.Drawing.Point(667, 223);
            this.quiztotaltxt.Name = "quiztotaltxt";
            this.quiztotaltxt.Size = new System.Drawing.Size(12, 15);
            this.quiztotaltxt.TabIndex = 20;
            this.quiztotaltxt.Text = "-";
            // 
            // midtxt
            // 
            this.midtxt.AutoSize = true;
            this.midtxt.Location = new System.Drawing.Point(597, 275);
            this.midtxt.Name = "midtxt";
            this.midtxt.Size = new System.Drawing.Size(12, 15);
            this.midtxt.TabIndex = 21;
            this.midtxt.Text = "-";
            // 
            // finaltxt
            // 
            this.finaltxt.AutoSize = true;
            this.finaltxt.Location = new System.Drawing.Point(598, 300);
            this.finaltxt.Name = "finaltxt";
            this.finaltxt.Size = new System.Drawing.Size(12, 15);
            this.finaltxt.TabIndex = 22;
            this.finaltxt.Text = "-";
            // 
            // vivatxt
            // 
            this.vivatxt.AutoSize = true;
            this.vivatxt.Location = new System.Drawing.Point(598, 326);
            this.vivatxt.Name = "vivatxt";
            this.vivatxt.Size = new System.Drawing.Size(12, 15);
            this.vivatxt.TabIndex = 23;
            this.vivatxt.Text = "-";
            // 
            // totaltxt
            // 
            this.totaltxt.AutoSize = true;
            this.totaltxt.Location = new System.Drawing.Point(664, 329);
            this.totaltxt.Name = "totaltxt";
            this.totaltxt.Size = new System.Drawing.Size(12, 15);
            this.totaltxt.TabIndex = 24;
            this.totaltxt.Text = "-";
            // 
            // percenttxt
            // 
            this.percenttxt.AutoSize = true;
            this.percenttxt.Location = new System.Drawing.Point(616, 381);
            this.percenttxt.Name = "percenttxt";
            this.percenttxt.Size = new System.Drawing.Size(12, 15);
            this.percenttxt.TabIndex = 25;
            this.percenttxt.Text = "-";
            // 
            // gradetxt
            // 
            this.gradetxt.AutoSize = true;
            this.gradetxt.Location = new System.Drawing.Point(616, 406);
            this.gradetxt.Name = "gradetxt";
            this.gradetxt.Size = new System.Drawing.Size(12, 15);
            this.gradetxt.TabIndex = 26;
            this.gradetxt.Text = "-";
            // 
            // quiz4txt
            // 
            this.quiz4txt.AutoSize = true;
            this.quiz4txt.Location = new System.Drawing.Point(609, 223);
            this.quiz4txt.Name = "quiz4txt";
            this.quiz4txt.Size = new System.Drawing.Size(12, 15);
            this.quiz4txt.TabIndex = 28;
            this.quiz4txt.Text = "-";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(560, 223);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 15);
            this.label15.TabIndex = 27;
            this.label15.Text = "Quiz 4:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.quiz4txt);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.gradetxt);
            this.Controls.Add(this.percenttxt);
            this.Controls.Add(this.totaltxt);
            this.Controls.Add(this.vivatxt);
            this.Controls.Add(this.finaltxt);
            this.Controls.Add(this.midtxt);
            this.Controls.Add(this.quiztotaltxt);
            this.Controls.Add(this.quiz3txt);
            this.Controls.Add(this.quiz2txt);
            this.Controls.Add(this.quiz1txt);
            this.Controls.Add(this.attendancetxt);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBox1;
        private TextBox idtxt;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label attendancetxt;
        private Label quiz1txt;
        private Label quiz2txt;
        private Label quiz3txt;
        private Label quiztotaltxt;
        private Label midtxt;
        private Label finaltxt;
        private Label vivatxt;
        private Label totaltxt;
        private Label percenttxt;
        private Label gradetxt;
        private Label quiz4txt;
        private Label label15;
    }
}