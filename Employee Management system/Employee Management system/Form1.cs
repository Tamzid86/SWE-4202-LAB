using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management_system
{
    public partial class Form1 : Form
    {
        List<Manager> manager = new List<Manager>();
        List<Salesperson> salesperson = new List<Salesperson>();
        List<Typewriter> typewriter = new List<Typewriter>();
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void AddButton_Click(object sender, EventArgs e)
        {
            string emp_name = nametxt.Text;
            string emp_contatc = contacttxt.Text;
            int emp_salary = Convert.ToInt32(salarytxt.Text);
            string emp_type = typetxt.Text;
            string DateOfJoining = datetxt.Text;
            int id = 1;

            if (emp_type == "Manager")
            {
                id = 100 + id++;
                Manager dummy = new Manager(emp_name, emp_contatc, emp_salary, emp_type, DateOfJoining, id);
                manager.Add(dummy);
                
            }
                if (emp_type == "Salesperson")
                {
                    id = 200 + id++;
                    Salesperson dummy2 = new Salesperson(emp_name, emp_contatc, emp_salary, emp_type, DateOfJoining, id);
                    salesperson.Add(dummy2);
                }
                else
                {
                    id = 300 + id++;
                    Typewriter dummy3 = new Typewriter(emp_name, emp_contatc, emp_salary, emp_type, DateOfJoining, id);
                    typewriter.Add(dummy3);
                }
            MessageBox.Show("Employee has been added");
        }

        public void showbutton_Click(object sender, EventArgs e)
        {
            string name = shownametxt.Text;
            string type = showtypetxt.Text;
            
            
                label8.Text = "Name: " + name;

            
            
        }
    }
}
