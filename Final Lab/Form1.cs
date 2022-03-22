using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Final_Lab
{
    public partial class Form1 : Form
    {
        public List<Student> students = new List<Student>();
        public Form1()
        {
            InitializeComponent();
            

            using (var reader = new StreamReader(@"C:\Users\My System\Desktop\Final Lab\marksheet.csv"))
            {
                

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    Student dummy = new Student();
                    dummy.ID = values[0];
                    dummy.Name = values[1];
                    dummy.Attd = values[2];
                    dummy.quiz[0] = values[3];
                    dummy.quiz[1] = values[4];
                    dummy.quiz[2] = values[5];
                    dummy.quiz[3] = values[6];
                    dummy.Mid = values[7];
                    dummy.Final = values[8];
                    dummy.Viva = values[9];

                    students.Add(dummy);

                    listBox1.Items.Add(dummy.getInfo());
                }
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = idtxt.Text;

            var student = from s 
                          in students
                          select s;


            foreach (var s in student)
            {
                if (s.ID == id)
                {
                    s.getGrade();

                    attendancetxt.Text = s.Attd.ToString();
                    quiztotaltxt.Text = s.quizTotal.ToString();
                    midtxt.Text = s.Mid.ToString();
                    finaltxt.Text = s.Final.ToString();
                    vivatxt.Text = s.Viva.ToString();
                    totaltxt.Text = s.Total.ToString();
                    gradetxt.Text = s.grade.ToString();
                    percenttxt.Text = s.percentage.ToString("#.##") + "%";
                    quiz1txt.Text = s.quiz[0];
                    quiz2txt.Text = s.quiz[1];
                    quiz3txt.Text = s.quiz[2];
                    quiz4txt.Text = s.quiz[3];
                }
            }
        }
    }
}