using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System
{
    public partial class Form1 : Form
    {

        List<medicine> medicines = new List<medicine>();
        int total;
        

        private bool medicineexists(string name)
        {
            foreach(medicine med in medicines)
            {
                if(med.MedicineName == name)
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

        private void button2_Click(object sender, EventArgs e)
        {
            string name = soldmedicinetxt.Text;
            int price = Convert.ToInt32(totalpricetxt.Text);

            if (medicineexists(name))
            {
                foreach (medicine med in medicines)
                {
                    if (med.MedicineName == name)
                    {
                        if (med.Quantity < 1)
                        {
                            MessageBox.Show("Medicine is out of stock");
                        }
                        else
                        {
                            med.Quantity -= 1;
                            total += price;
                            
                            MessageBox.Show("Medicine has been sold successfully");
                        }
                       
                        
                    }
                    


                }
            }
            else
            {
                MessageBox.Show("Invalid input");
            }


        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             string name = medicinenametxt.Text;
            int quantity = Convert.ToInt32(quantitytxt.Text);

            medicine dummy = new medicine( name, quantity);

            medicines.Add(dummy);

            MessageBox.Show("Medicine has been added");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string name = showmedicinetxt.Text;
            
            if (medicineexists(name))
            {
                foreach (medicine med in medicines)
                {
                    if (med.MedicineName == name)
                    {
                        showquantity.Text = Convert.ToString(med.Quantity);
                    }
                }
                
             }
            
            /*showquantity.Text = Convert.ToString(dummy.Quantity);*/

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            showamount.Text = Convert.ToString(total) + "Taka";
        }
    }
}
