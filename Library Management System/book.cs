using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    internal class book
    {
        public string bookname;
        public string author;
        public int bookid;
        public string publisher;
        public int quantity;
        public book(string bookname, string author, int bookid, string publisher, int quantity)
        {
            this.bookname = bookname;
            this.author = author;
            this.bookid = bookid;
            this.publisher = publisher;
            this.quantity = quantity;

        }
        public string history()
        {
            return this.bookid.ToString() + "\t" + this.bookname;
        }

    }
}

