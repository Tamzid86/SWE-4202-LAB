namespace Library_Management_System
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
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.userid = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.useraddress = new System.Windows.Forms.TextBox();
            this.adduser = new System.Windows.Forms.Button();
            this.author = new System.Windows.Forms.TextBox();
            this.bookname = new System.Windows.Forms.TextBox();
            this.bookid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.TextBox();
            this.publisher = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.addbook = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.showuser = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.ListBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.hbookid = new System.Windows.Forms.Label();
            this.hauthor = new System.Windows.Forms.Label();
            this.hpublisher = new System.Windows.Forms.Label();
            this.hquantity = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.showuserid = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.useridborrow = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.bookidborrow = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.bookidtxt = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Address:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // userid
            // 
            this.userid.Location = new System.Drawing.Point(67, 26);
            this.userid.Name = "userid";
            this.userid.Size = new System.Drawing.Size(100, 20);
            this.userid.TabIndex = 3;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(67, 56);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(100, 20);
            this.username.TabIndex = 4;
            // 
            // useraddress
            // 
            this.useraddress.Location = new System.Drawing.Point(67, 88);
            this.useraddress.Name = "useraddress";
            this.useraddress.Size = new System.Drawing.Size(100, 20);
            this.useraddress.TabIndex = 5;
            this.useraddress.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // adduser
            // 
            this.adduser.Location = new System.Drawing.Point(67, 128);
            this.adduser.Name = "adduser";
            this.adduser.Size = new System.Drawing.Size(75, 23);
            this.adduser.TabIndex = 6;
            this.adduser.Text = "ADD User";
            this.adduser.UseVisualStyleBackColor = true;
            this.adduser.Click += new System.EventHandler(this.adduser_Click);
            // 
            // author
            // 
            this.author.Location = new System.Drawing.Point(263, 88);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(100, 20);
            this.author.TabIndex = 12;
            // 
            // bookname
            // 
            this.bookname.Location = new System.Drawing.Point(263, 56);
            this.bookname.Name = "bookname";
            this.bookname.Size = new System.Drawing.Size(100, 20);
            this.bookname.TabIndex = 11;
            // 
            // bookid
            // 
            this.bookid.Location = new System.Drawing.Point(263, 26);
            this.bookid.Name = "bookid";
            this.bookid.Size = new System.Drawing.Size(100, 20);
            this.bookid.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Author:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(181, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Book Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(201, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Book ID:";
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(263, 146);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(100, 20);
            this.quantity.TabIndex = 16;
            // 
            // publisher
            // 
            this.publisher.Location = new System.Drawing.Point(263, 114);
            this.publisher.Name = "publisher";
            this.publisher.Size = new System.Drawing.Size(100, 20);
            this.publisher.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(198, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Quantity:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(181, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(197, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Publisher:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(2, 207);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(451, 102);
            this.label10.TabIndex = 18;
            this.label10.Text = "---------------------------------------------------------------";
            // 
            // addbook
            // 
            this.addbook.Location = new System.Drawing.Point(263, 181);
            this.addbook.Name = "addbook";
            this.addbook.Size = new System.Drawing.Size(75, 23);
            this.addbook.TabIndex = 19;
            this.addbook.Text = "ADD Book";
            this.addbook.UseVisualStyleBackColor = true;
            this.addbook.Click += new System.EventHandler(this.addbook_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(144, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Borrow Book";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(543, 26);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(123, 24);
            this.linkLabel1.TabIndex = 23;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "User History";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // showuser
            // 
            this.showuser.Location = new System.Drawing.Point(667, 59);
            this.showuser.Name = "showuser";
            this.showuser.Size = new System.Drawing.Size(82, 23);
            this.showuser.TabIndex = 25;
            this.showuser.Text = "Show";
            this.showuser.UseVisualStyleBackColor = true;
            this.showuser.Click += new System.EventHandler(this.showuser_Click);
            // 
            // info
            // 
            this.info.FormattingEnabled = true;
            this.info.Location = new System.Drawing.Point(466, 104);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(307, 121);
            this.info.TabIndex = 26;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkColor = System.Drawing.Color.Black;
            this.linkLabel2.Location = new System.Drawing.Point(543, 260);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(127, 24);
            this.linkLabel2.TabIndex = 27;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Book History";
            this.linkLabel2.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(463, 342);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Book ID:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(471, 372);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Author:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(459, 401);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Publisher:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(459, 434);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "Quantity:";
            // 
            // hbookid
            // 
            this.hbookid.AutoSize = true;
            this.hbookid.Location = new System.Drawing.Point(518, 342);
            this.hbookid.Name = "hbookid";
            this.hbookid.Size = new System.Drawing.Size(10, 13);
            this.hbookid.TabIndex = 34;
            this.hbookid.Text = "-";
            // 
            // hauthor
            // 
            this.hauthor.AutoSize = true;
            this.hauthor.Location = new System.Drawing.Point(518, 372);
            this.hauthor.Name = "hauthor";
            this.hauthor.Size = new System.Drawing.Size(10, 13);
            this.hauthor.TabIndex = 36;
            this.hauthor.Text = "-";
            // 
            // hpublisher
            // 
            this.hpublisher.AutoSize = true;
            this.hpublisher.Location = new System.Drawing.Point(518, 401);
            this.hpublisher.Name = "hpublisher";
            this.hpublisher.Size = new System.Drawing.Size(10, 13);
            this.hpublisher.TabIndex = 37;
            this.hpublisher.Text = "-";
            // 
            // hquantity
            // 
            this.hquantity.AutoSize = true;
            this.hquantity.Location = new System.Drawing.Point(518, 434);
            this.hquantity.Name = "hquantity";
            this.hquantity.Size = new System.Drawing.Size(10, 13);
            this.hquantity.TabIndex = 38;
            this.hquantity.Text = "-";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(521, 474);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(79, 23);
            this.button5.TabIndex = 39;
            this.button5.Text = "Book History";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // showuserid
            // 
            this.showuserid.Location = new System.Drawing.Point(545, 62);
            this.showuserid.Name = "showuserid";
            this.showuserid.Size = new System.Drawing.Size(100, 20);
            this.showuserid.TabIndex = 41;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(483, 62);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(46, 13);
            this.label17.TabIndex = 40;
            this.label17.Text = "User ID:";
            // 
            // useridborrow
            // 
            this.useridborrow.Location = new System.Drawing.Point(67, 226);
            this.useridborrow.Name = "useridborrow";
            this.useridborrow.Size = new System.Drawing.Size(100, 20);
            this.useridborrow.TabIndex = 43;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(5, 226);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(46, 13);
            this.label18.TabIndex = 42;
            this.label18.Text = "User ID:";
            // 
            // bookidborrow
            // 
            this.bookidborrow.Location = new System.Drawing.Point(67, 252);
            this.bookidborrow.Name = "bookidborrow";
            this.bookidborrow.Size = new System.Drawing.Size(100, 20);
            this.bookidborrow.TabIndex = 45;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(5, 252);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(49, 13);
            this.label19.TabIndex = 44;
            this.label19.Text = "Book ID:";
            // 
            // bookidtxt
            // 
            this.bookidtxt.Location = new System.Drawing.Point(525, 296);
            this.bookidtxt.Name = "bookidtxt";
            this.bookidtxt.Size = new System.Drawing.Size(100, 20);
            this.bookidtxt.TabIndex = 47;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(463, 296);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 13);
            this.label16.TabIndex = 46;
            this.label16.Text = "Book ID:";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(408, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(10, 526);
            this.label12.TabIndex = 48;
            this.label12.Text = "label12";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 521);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.bookidtxt);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.bookidborrow);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.useridborrow);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.showuserid);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.hquantity);
            this.Controls.Add(this.hpublisher);
            this.Controls.Add(this.hauthor);
            this.Controls.Add(this.hbookid);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.info);
            this.Controls.Add(this.showuser);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addbook);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.publisher);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.author);
            this.Controls.Add(this.bookname);
            this.Controls.Add(this.bookid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.adduser);
            this.Controls.Add(this.useraddress);
            this.Controls.Add(this.username);
            this.Controls.Add(this.userid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "User History";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox userid;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox useraddress;
        private System.Windows.Forms.Button adduser;
        private System.Windows.Forms.TextBox author;
        private System.Windows.Forms.TextBox bookname;
        private System.Windows.Forms.TextBox bookid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.TextBox publisher;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button addbook;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button showuser;
        private System.Windows.Forms.ListBox info;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label hbookid;
        private System.Windows.Forms.Label hauthor;
        private System.Windows.Forms.Label hpublisher;
        private System.Windows.Forms.Label hquantity;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox showuserid;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox useridborrow;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox bookidborrow;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox bookidtxt;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label12;
    }
}

