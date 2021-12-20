using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management_System
{
    internal class medicine
    {
        public string MedicineName;
        public int Quantity;
        public int Totaltaka;
        List<string> medicines = new List<string>();

        public medicine(string MedicineName, int Quantity)
        {
            this.MedicineName = MedicineName;
            this.Quantity = Quantity;
        }
        public medicine()
        {

        }
        

        public void AddMedicine(string MedicineName)
        {
            medicines.Add(MedicineName);
        }
        

        public string ShowStock()
        {
            return "Number of Available Medicine is:" + "\t" + this.Quantity.ToString();
        }
    }
}
