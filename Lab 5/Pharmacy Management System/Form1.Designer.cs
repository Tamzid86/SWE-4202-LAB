namespace Pharmacy_Management_System
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
            this.label1 = new System.Windows.Forms.Label();
            this.medicinenametxt = new System.Windows.Forms.TextBox();
            this.quantitytxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.soldmedicinetxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.showmedicinetxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.totalpricetxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.showquantity = new System.Windows.Forms.Label();
            this.showamount = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Medicine Name:";
            // 
            // medicinenametxt
            // 
            this.medicinenametxt.Location = new System.Drawing.Point(102, 24);
            this.medicinenametxt.Name = "medicinenametxt";
            this.medicinenametxt.Size = new System.Drawing.Size(100, 20);
            this.medicinenametxt.TabIndex = 1;
            // 
            // quantitytxt
            // 
            this.quantitytxt.Location = new System.Drawing.Point(102, 61);
            this.quantitytxt.Name = "quantitytxt";
            this.quantitytxt.Size = new System.Drawing.Size(100, 20);
            this.quantitytxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantity:";
            // 
            // soldmedicinetxt
            // 
            this.soldmedicinetxt.Location = new System.Drawing.Point(102, 229);
            this.soldmedicinetxt.Name = "soldmedicinetxt";
            this.soldmedicinetxt.Size = new System.Drawing.Size(100, 20);
            this.soldmedicinetxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Medicine Name:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "ADD Medicine";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(67, 313);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Sell Medicine";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(395, 106);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Show Stock";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // showmedicinetxt
            // 
            this.showmedicinetxt.Location = new System.Drawing.Point(430, 20);
            this.showmedicinetxt.Name = "showmedicinetxt";
            this.showmedicinetxt.Size = new System.Drawing.Size(100, 20);
            this.showmedicinetxt.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(340, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Medicine Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(384, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Check Current Balance:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(395, 313);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "Show Account Balance";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // totalpricetxt
            // 
            this.totalpricetxt.Location = new System.Drawing.Point(102, 274);
            this.totalpricetxt.Name = "totalpricetxt";
            this.totalpricetxt.Size = new System.Drawing.Size(100, 20);
            this.totalpricetxt.TabIndex = 16;
            this.totalpricetxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Total Price: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(340, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Quantity of the Medicine is:";
            // 
            // showquantity
            // 
            this.showquantity.AutoSize = true;
            this.showquantity.Location = new System.Drawing.Point(481, 64);
            this.showquantity.Name = "showquantity";
            this.showquantity.Size = new System.Drawing.Size(10, 13);
            this.showquantity.TabIndex = 18;
            this.showquantity.Text = "-";
            this.showquantity.Click += new System.EventHandler(this.label8_Click);
            // 
            // showamount
            // 
            this.showamount.AutoSize = true;
            this.showamount.Location = new System.Drawing.Point(460, 265);
            this.showamount.Name = "showamount";
            this.showamount.Size = new System.Drawing.Size(10, 13);
            this.showamount.TabIndex = 20;
            this.showamount.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(372, 265);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Total amount is:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showamount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.showquantity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.totalpricetxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.showmedicinetxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.soldmedicinetxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.quantitytxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.medicinenametxt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox medicinenametxt;
        private System.Windows.Forms.TextBox quantitytxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox soldmedicinetxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox showmedicinetxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox totalpricetxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label showquantity;
        private System.Windows.Forms.Label showamount;
        private System.Windows.Forms.Label label9;
    }
}

