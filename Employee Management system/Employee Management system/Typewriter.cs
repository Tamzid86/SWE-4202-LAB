using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_system
{
    internal class Typewriter:Employee 

    {
        public Typewriter(string name, string contact, int salary, string type, string date, int id)
        {
            this.name = name;
            this.contact = contact;
            this.salary = salary;
            this.type = type;
            this.date = date;
            this.id = id;
        }
        public Typewriter()
        {

        }
        public int EMP_salary()
        {
            return salary + (5 * salary) / 100;
        }
    }
}
