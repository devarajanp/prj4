using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Storeing the values to variables

            DateTime dTime = Convert.ToDateTime(date.Text);
            courseclass1.setdate(dTime);// passing the value of datetime variable to another variable dtTime of the setdate method in class1.
            string courseno = crsno.Text;
            // the following code tests the first textbox No. of Course Taken
            // it checks if the value entered is integer if not it shows an error.
            try
            {
                int NoOfCourse = int.Parse(nocrs.Text, System.Globalization.NumberStyles.None); // parses the string in CrsTaken text box.
                courseclass1.setsnocours(NoOfCourse); // passing the value of NoOfCourse variable to another variable course of the setsnocours method in class1.
            }

            catch (Exception)
            {
                MessageBox.Show("Enter the Number of Courses Taken. Enter the values in form of Numbers only.");
                nocrs.Clear();// Clears the TextBox CrsTaken

            }

            // the following code tests the Second textbox Student Name
            // it checks if the value entered ends with or starts with a space if it does it shows an error.
            string StudentName = cname.Text; // storeing of value to variable
            if (StudentName.EndsWith(" ") || StudentName.StartsWith(" ")) // the code checks if the string starts with or ends with a Blank
            {
                MessageBox.Show("Student Name Cannot Start or End with a Space");
                cname.Clear();

            }
            else
            { }
            //the following code tests the Second textbox Student Name
            // it checks if the value entered consist of a space if it doesn't it shows an error.
            if (StudentName.Contains(" ")) // the code that checks if there is space between first name and last name.
            {
                courseclass1.sets1(StudentName); // passing the value of StudentName variable to another variable sname of the sets1 method in class1.
            }
            else
            {
                MessageBox.Show("There should be a space between First name and Last name");
                cname.Clear();
            }

            if (Online.Checked == true)
            {
                string type = "Online";
                courseclass1.settype(type);

            }

            else
            {
                Hybrid.Checked = true;
                string type1 = "Hybrid";
                courseclass1.settype(type1);
            }

        }

        private void butExit_Click(object sender, EventArgs e)
        {
            Application.Exit();// to exit the application.
        }

        private void btnget_Click(object sender, EventArgs e)
        {
            // the following code 
            string content = courseclass2.gets1();
            cname1.Text = content;

            int courseno = courseclass2.getnocours();
            nocrs1.Text = Convert.ToString(courseno);

            DateTime dttime = courseclass2.getdate();
            startdate.Text = Convert.ToString(dttime);

            string type3 = courseclass2.gettype();
            ctype.Text = type3;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();// to exit the application.
        }
    }
}


