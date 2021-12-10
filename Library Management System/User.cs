using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    internal class User
    {
        public string username;
        public int userid;
        public string useraddress;
        public List<int> books = new List<int>();

        public User()
        {

        }
        public User(int userid, string username, string useraddress)
        {
            this.userid = userid;
            this.username = username;
            this.useraddress = useraddress;
        }
        public void AddBook(int userid)
        {
            books.Add(userid);
        }






    }




}

