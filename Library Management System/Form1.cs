using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{   
    public partial class Form1 : Form
    {
        List<User> users = new List<User>();
        List<book> books = new List<book>();
        private bool userexits(int UserId)
        {
            foreach (User user in users)
            {
                if (user.userid == UserId)
                {
                    return true;
                }
            }
            return false;
        }
        private bool bookexists(int BookId)
        {
            foreach(book BOOK in books)
            {
                if (BOOK.bookid == BookId)
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
        
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int userID = Convert.ToInt32(useridborrow.Text);
            int bookID = Convert.ToInt32(bookidborrow.Text);
            if(bookexists(bookID) && userexits(userID))
            {foreach (book BOOK in books)
                {
                    if (BOOK.bookid == bookID)
                    {
                        if (BOOK.quantity < 1)
                        {
                            MessageBox.Show("Not enough item in stock");
                            break;
                        }
                        BOOK.quantity -= 1;
                        foreach (User user in users)
                        {
                            if(user.userid == userID)
                            {
                                user.books.Add(bookID);
                                MessageBox.Show("Book has been added to the user");
                            }
                        }
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid Input");
            }
        }

        private void adduser_Click(object sender, EventArgs e)
        {
            string UserName = username.Text;
            int UserId = Convert.ToInt32(userid.Text);
            string UserAddress = useraddress.Text;

            User user = new User(UserId, UserName, UserAddress);
            users.Add(user);
            MessageBox.Show("User has been added successfully");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addbook_Click(object sender, EventArgs e)
        {
            string BookName = bookname.Text;
            int BookId = Convert.ToInt32(bookid.Text);
            string Author = author.Text;
            string Publisher = publisher.Text;
            int QuantityOfBook = Convert.ToInt32(quantity.Text);

            book BOOK = new book(BookName, Author, BookId, Publisher, QuantityOfBook);
            books.Add(BOOK);
            MessageBox.Show("Book has been added");
        }

        private void showuser_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(showuserid.Text);
            User dummy = new User();
            bool flag = false;
            foreach (User user in users)
            {
                if (user.userid == id)
                {
                    flag = true;
                    dummy = user;
                    break;
                }
            }
             if (flag == false)
                {
                    MessageBox.Show("User could not be found");
                }

                info.Items.Clear();
                for(int i=0; i<dummy.books.Count; i++)
                {
                    int id_book = dummy.books[i];
                    for(int j=0; j<books.Count; j++)
                    {
                        if (books[j].bookid == id_book)
                        {
                            info.Items.Add(books[j].history());
                        }
                    }
                }
            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(bookidtxt.Text);
           bool flag = false;
           foreach(book bOok in books)
            {
                if(bOok.bookid == id)
                {
                    flag = true;
                    hbookid.Text = "Book ID" + " " + bOok.bookid.ToString();
                    hauthor.Text = "Author" + " " + bOok.author;
                    hpublisher.Text = "Publisher: " + bOok.publisher;
                    hquantity.Text = "Quantity " + bOok.quantity.ToString();



                }
            }

           if( flag == false)
            {
                MessageBox.Show("Book could not be found");
            }

        }
    }
}
