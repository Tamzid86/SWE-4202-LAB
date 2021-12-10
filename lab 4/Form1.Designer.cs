namespace lab_4
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.bookidtext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.booktitletext = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bookauthortext = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bookpublishertext = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bookquantitytext = new System.Windows.Forms.TextBox();
            this.addstudybookButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.genretext = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.isbntext = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.articlequantitytext = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.articlepublishertext = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.articleauthortext = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.articletitletext = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.articleidtext = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.conferenceorjournaltext = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.publisheddatetext = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.doitext = new System.Windows.Forms.TextBox();
            this.addresearcharticleButton = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.borrowbookidtext = new System.Windows.Forms.TextBox();
            this.borrowbookButton = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.borrowarticleidtext = new System.Windows.Forms.TextBox();
            this.borrowarticleButton = new System.Windows.Forms.Button();
            this.BookList = new System.Windows.Forms.ListBox();
            this.ArticleList = new System.Windows.Forms.ListBox();
            this.showstudybookButton = new System.Windows.Forms.Button();
            this.showarticleButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(239, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 544);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox2.Location = new System.Drawing.Point(-15, 260);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(912, 10);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox3.Location = new System.Drawing.Point(597, -12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 561);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // bookidtext
            // 
            this.bookidtext.Location = new System.Drawing.Point(116, 14);
            this.bookidtext.Name = "bookidtext";
            this.bookidtext.Size = new System.Drawing.Size(100, 20);
            this.bookidtext.TabIndex = 3;
            this.bookidtext.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Book ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Title:";
            // 
            // booktitletext
            // 
            this.booktitletext.Location = new System.Drawing.Point(116, 40);
            this.booktitletext.Name = "booktitletext";
            this.booktitletext.Size = new System.Drawing.Size(100, 20);
            this.booktitletext.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Author:";
            // 
            // bookauthortext
            // 
            this.bookauthortext.Location = new System.Drawing.Point(116, 66);
            this.bookauthortext.Name = "bookauthortext";
            this.bookauthortext.Size = new System.Drawing.Size(100, 20);
            this.bookauthortext.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Publisher:";
            // 
            // bookpublishertext
            // 
            this.bookpublishertext.Location = new System.Drawing.Point(116, 92);
            this.bookpublishertext.Name = "bookpublishertext";
            this.bookpublishertext.Size = new System.Drawing.Size(100, 20);
            this.bookpublishertext.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Quantity:";
            // 
            // bookquantitytext
            // 
            this.bookquantitytext.Location = new System.Drawing.Point(116, 118);
            this.bookquantitytext.Name = "bookquantitytext";
            this.bookquantitytext.Size = new System.Drawing.Size(100, 20);
            this.bookquantitytext.TabIndex = 11;
            // 
            // addstudybookButton
            // 
            this.addstudybookButton.Location = new System.Drawing.Point(106, 206);
            this.addstudybookButton.Name = "addstudybookButton";
            this.addstudybookButton.Size = new System.Drawing.Size(122, 31);
            this.addstudybookButton.TabIndex = 13;
            this.addstudybookButton.Text = "ADD STUDY BOOK";
            this.addstudybookButton.UseVisualStyleBackColor = true;
            this.addstudybookButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Genre:";
            // 
            // genretext
            // 
            this.genretext.Location = new System.Drawing.Point(116, 170);
            this.genretext.Name = "genretext";
            this.genretext.Size = new System.Drawing.Size(100, 20);
            this.genretext.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "ISBN:";
            // 
            // isbntext
            // 
            this.isbntext.Location = new System.Drawing.Point(116, 144);
            this.isbntext.Name = "isbntext";
            this.isbntext.Size = new System.Drawing.Size(100, 20);
            this.isbntext.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 390);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Quantity:";
            // 
            // articlequantitytext
            // 
            this.articlequantitytext.Location = new System.Drawing.Point(116, 390);
            this.articlequantitytext.Name = "articlequantitytext";
            this.articlequantitytext.Size = new System.Drawing.Size(100, 20);
            this.articlequantitytext.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(57, 364);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Publisher:";
            // 
            // articlepublishertext
            // 
            this.articlepublishertext.Location = new System.Drawing.Point(116, 364);
            this.articlepublishertext.Name = "articlepublishertext";
            this.articlepublishertext.Size = new System.Drawing.Size(100, 20);
            this.articlepublishertext.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(69, 341);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Author:";
            // 
            // articleauthortext
            // 
            this.articleauthortext.Location = new System.Drawing.Point(116, 338);
            this.articleauthortext.Name = "articleauthortext";
            this.articleauthortext.Size = new System.Drawing.Size(100, 20);
            this.articleauthortext.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(80, 315);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Title:";
            // 
            // articletitletext
            // 
            this.articletitletext.Location = new System.Drawing.Point(116, 312);
            this.articletitletext.Name = "articletitletext";
            this.articletitletext.Size = new System.Drawing.Size(100, 20);
            this.articletitletext.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(57, 289);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Article ID:";
            // 
            // articleidtext
            // 
            this.articleidtext.Location = new System.Drawing.Point(116, 286);
            this.articleidtext.Name = "articleidtext";
            this.articleidtext.Size = new System.Drawing.Size(100, 20);
            this.articleidtext.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 475);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Conference/Journal:";
            // 
            // conferenceorjournaltext
            // 
            this.conferenceorjournaltext.Location = new System.Drawing.Point(116, 468);
            this.conferenceorjournaltext.Name = "conferenceorjournaltext";
            this.conferenceorjournaltext.Size = new System.Drawing.Size(100, 20);
            this.conferenceorjournaltext.TabIndex = 32;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(28, 445);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Published Date:";
            // 
            // publisheddatetext
            // 
            this.publisheddatetext.Location = new System.Drawing.Point(116, 442);
            this.publisheddatetext.Name = "publisheddatetext";
            this.publisheddatetext.Size = new System.Drawing.Size(100, 20);
            this.publisheddatetext.TabIndex = 30;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(81, 416);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "DOI:";
            // 
            // doitext
            // 
            this.doitext.Location = new System.Drawing.Point(116, 416);
            this.doitext.Name = "doitext";
            this.doitext.Size = new System.Drawing.Size(100, 20);
            this.doitext.TabIndex = 28;
            // 
            // addresearcharticleButton
            // 
            this.addresearcharticleButton.Location = new System.Drawing.Point(55, 498);
            this.addresearcharticleButton.Name = "addresearcharticleButton";
            this.addresearcharticleButton.Size = new System.Drawing.Size(173, 31);
            this.addresearcharticleButton.TabIndex = 34;
            this.addresearcharticleButton.Text = "ADD RESEARCH ARTICLE";
            this.addresearcharticleButton.UseVisualStyleBackColor = true;
            this.addresearcharticleButton.Click += new System.EventHandler(this.addresearcharticleButton_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(262, 65);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 13);
            this.label16.TabIndex = 36;
            this.label16.Text = "Book ID:";
            // 
            // borrowbookidtext
            // 
            this.borrowbookidtext.Location = new System.Drawing.Point(317, 62);
            this.borrowbookidtext.Name = "borrowbookidtext";
            this.borrowbookidtext.Size = new System.Drawing.Size(100, 20);
            this.borrowbookidtext.TabIndex = 35;
            // 
            // borrowbookButton
            // 
            this.borrowbookButton.Location = new System.Drawing.Point(442, 55);
            this.borrowbookButton.Name = "borrowbookButton";
            this.borrowbookButton.Size = new System.Drawing.Size(122, 31);
            this.borrowbookButton.TabIndex = 37;
            this.borrowbookButton.Text = "BORROW BOOK";
            this.borrowbookButton.UseVisualStyleBackColor = true;
            this.borrowbookButton.Click += new System.EventHandler(this.borrowbookButton_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(258, 140);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 13);
            this.label17.TabIndex = 39;
            this.label17.Text = "Article ID:";
            // 
            // borrowarticleidtext
            // 
            this.borrowarticleidtext.Location = new System.Drawing.Point(317, 137);
            this.borrowarticleidtext.Name = "borrowarticleidtext";
            this.borrowarticleidtext.Size = new System.Drawing.Size(100, 20);
            this.borrowarticleidtext.TabIndex = 38;
            // 
            // borrowarticleButton
            // 
            this.borrowarticleButton.Location = new System.Drawing.Point(442, 131);
            this.borrowarticleButton.Name = "borrowarticleButton";
            this.borrowarticleButton.Size = new System.Drawing.Size(122, 31);
            this.borrowarticleButton.TabIndex = 40;
            this.borrowarticleButton.Text = "BORROW ARTICLE";
            this.borrowarticleButton.UseVisualStyleBackColor = true;
            this.borrowarticleButton.Click += new System.EventHandler(this.borrowarticleButton_Click);
            // 
            // BookList
            // 
            this.BookList.FormattingEnabled = true;
            this.BookList.Location = new System.Drawing.Point(626, 17);
            this.BookList.Name = "BookList";
            this.BookList.Size = new System.Drawing.Size(221, 186);
            this.BookList.TabIndex = 41;
            // 
            // ArticleList
            // 
            this.ArticleList.FormattingEnabled = true;
            this.ArticleList.Location = new System.Drawing.Point(626, 289);
            this.ArticleList.Name = "ArticleList";
            this.ArticleList.Size = new System.Drawing.Size(221, 186);
            this.ArticleList.TabIndex = 42;
            // 
            // showstudybookButton
            // 
            this.showstudybookButton.Location = new System.Drawing.Point(335, 327);
            this.showstudybookButton.Name = "showstudybookButton";
            this.showstudybookButton.Size = new System.Drawing.Size(122, 31);
            this.showstudybookButton.TabIndex = 43;
            this.showstudybookButton.Text = "SHOW STUDY BOOK";
            this.showstudybookButton.UseVisualStyleBackColor = true;
            this.showstudybookButton.Click += new System.EventHandler(this.showstudybookButton_Click);
            // 
            // showarticleButton
            // 
            this.showarticleButton.Location = new System.Drawing.Point(335, 390);
            this.showarticleButton.Name = "showarticleButton";
            this.showarticleButton.Size = new System.Drawing.Size(122, 31);
            this.showarticleButton.TabIndex = 44;
            this.showarticleButton.Text = "SHOW ARTICLE";
            this.showarticleButton.UseVisualStyleBackColor = true;
            this.showarticleButton.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 541);
            this.Controls.Add(this.showarticleButton);
            this.Controls.Add(this.showstudybookButton);
            this.Controls.Add(this.ArticleList);
            this.Controls.Add(this.BookList);
            this.Controls.Add(this.borrowarticleButton);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.borrowarticleidtext);
            this.Controls.Add(this.borrowbookButton);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.borrowbookidtext);
            this.Controls.Add(this.addresearcharticleButton);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.conferenceorjournaltext);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.publisheddatetext);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.doitext);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.articlequantitytext);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.articlepublishertext);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.articleauthortext);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.articletitletext);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.articleidtext);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.genretext);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.isbntext);
            this.Controls.Add(this.addstudybookButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bookquantitytext);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bookpublishertext);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bookauthortext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.booktitletext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bookidtext);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox bookidtext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox booktitletext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bookauthortext;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox bookpublishertext;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox bookquantitytext;
        private System.Windows.Forms.Button addstudybookButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox genretext;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox isbntext;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox articlequantitytext;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox articlepublishertext;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox articleauthortext;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox articletitletext;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox articleidtext;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox conferenceorjournaltext;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox publisheddatetext;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox doitext;
        private System.Windows.Forms.Button addresearcharticleButton;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox borrowbookidtext;
        private System.Windows.Forms.Button borrowbookButton;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox borrowarticleidtext;
        private System.Windows.Forms.Button borrowarticleButton;
        private System.Windows.Forms.ListBox BookList;
        private System.Windows.Forms.ListBox ArticleList;
        private System.Windows.Forms.Button showstudybookButton;
        private System.Windows.Forms.Button showarticleButton;
    }
}

