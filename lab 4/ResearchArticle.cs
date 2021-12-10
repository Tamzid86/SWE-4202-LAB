using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    internal class ResearchArticle:Book
    {
       public string DOI;
        public string publisheddate;
        public string conferenceORjournal;
        public List<int> articles = new List<int>();

        public ResearchArticle(int id, string title, string author, string publisher, int quantity, string DOI, string publisheddate, string conferenceORjournal)
    {
        this.id = id;
        this.title = title;
        this.author = author;
        this.publisher = publisher;
        this.quantity = quantity;
        this.DOI = DOI; ;
        this.publisheddate = publisheddate;
        this.conferenceORjournal = conferenceORjournal;
    }
        public void addarticle(int id)
        {
            articles.Add(id);
        }
        public string getarticleinfo()
        {
            return "ID= " + this.id.ToString() + "\t" + this.title + " Quantity =" + this.quantity.ToString();
        }
    }
}
