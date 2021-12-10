using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_4
{
    public partial class Form1 : Form
    {   
        List<StudyBook> books = new List<StudyBook>();
        List<ResearchArticle> articles = new List<ResearchArticle>();


        private bool bookexist(int id)
        {
            foreach(StudyBook book in books)
            {
                if (book.id ==id)
                {
                    return true;
                }
            }
            return false;
        }

        private bool articleexist(int id)
        {
            foreach(ResearchArticle article in articles)
            {
                if (article.id == id)
                {
                    return true;
                }
            }
            return false;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(bookidtext.Text);
            string title = booktitletext.Text;
            string author = booktitletext.Text;
            string publisher = bookpublishertext.Text;
            int quantity = Convert.ToInt32(bookquantitytext.Text);
            int ISBN = Convert.ToInt32(isbntext.Text);
            string genre = genretext.Text;
            if (quantity < 0)
            {
                MessageBox.Show("Quantity can not be negative");
                return;
            }

            StudyBook dummy = new StudyBook(id, title, author, publisher, quantity, ISBN, genre);
            books.Add(dummy);
            MessageBox.Show("Book has been added succesfully");



            

      



                

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

            ArticleList.Items.Clear();
            for (int i = 0; i < articles.Count; i++)
            {
                ArticleList.Items.Add(articles[i].getarticleinfo());
            }
        }
        

        private void showstudybookButton_Click(object sender, EventArgs e)
        {
            BookList.Items.Clear();
            for(int i=0; i<books.Count; i++)
            {
                BookList.Items.Add(books[i].getbookinfo());
            }

        }

        private void addresearcharticleButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(articleidtext.Text);
            string title = articletitletext.Text;
            string author = articletitletext.Text;
            string publisher = articlepublishertext.Text;
            int quantity = Convert.ToInt32(articlequantitytext.Text);
            string DOI = doitext.Text;
            string publisheddate = publisheddatetext.Text;
            string conferenceORgernal = conferenceorjournaltext.Text;

            ResearchArticle dummy = new ResearchArticle(id, title, author, publisher, quantity, DOI, publisheddate, conferenceORgernal);
            articles.Add(dummy);
            MessageBox.Show("Research article has been added");
        }

        private void borrowbookButton_Click(object sender, EventArgs e)
        {
            int bookID = Convert.ToInt32(borrowbookidtext.Text);

            if (bookexist(bookID) == true)
            {
                foreach(StudyBook book in books)
                {
                    if (book.id == bookID)
                    {
                        if (book.quantity < 1)
                        {
                            MessageBox.Show("Not enough item in stock");
                            break;
                        }
                        book.quantity -= 1;
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid input");
            }
        }

        private void borrowarticleButton_Click(object sender, EventArgs e)
        {
            int articleID = Convert.ToInt32(borrowarticleidtext.Text);
            if (articleexist(articleID) == true)
            {
                foreach(ResearchArticle article in articles)
                {
                    if (article.id == articleID)
                    {
                        if(article.quantity < 1)
                        {
                            MessageBox.Show("Not enough item in stock");
                        }
                    }
                    else
                    {
                        article.quantity -= 1;
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid input");
            }

        }
    }
}
