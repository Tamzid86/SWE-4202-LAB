using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_system
{
    internal class Employee
    {
       public string name;
        public string contact;
        public int salary;
        public string type;
        public string date;
        public int id = 1;
        public int IDGenerate()
        {
            return id++; 
        }

        public int EMP_salary()
        {
            return salary;
        }




    }
}
