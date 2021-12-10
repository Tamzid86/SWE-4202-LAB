using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace lab_4
{
    internal class StudyBook:Book
    {
        public int ISBN;
        public string genre;
        public List<int> books = new List<int>();

        public StudyBook(int id,string title, string author,string publisher, int quantity, int ISBN, string genre )
        {
            this.id = id;
            this.title = title;
            this.author = author;
            this.publisher = publisher;
            this.quantity = quantity;
            this.ISBN = ISBN;
            this.genre = genre;
        }
        public void addStudyBook( int id)
        {
            books.Add(id);
        }
        public string getbookinfo()
        {
            return "ID= " + this.id.ToString() + "\t" + this.title + " Quantity =" + this.quantity.ToString();
        }

    }
}
