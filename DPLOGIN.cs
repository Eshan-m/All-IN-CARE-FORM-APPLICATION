using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void PatientLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\EDUCATION\1 Year SEM 3\Object Oriented Programming with C#\Assigments\SEM END Project\All-IN-CARE-FORM-APPLICATION\AllInCare.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sd = new SqlDataAdapter("SELECT count(*) FROM PatientSettings WHERE Username='" + unameTxt.Text + "' AND Password='" + pwTxt.Text + "'", con);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                Texttransfer.Uname = unameTxt.Text;
                this.Hide();
                new Patient().Show();
            }
            else
                MessageBox.Show("Invalid username or password");
        }

        private void DoctorLogin_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\isuru\OneDrive\Desktop\All-IN-CARE-FORM-APPLICATION\AllInCare.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sd = new SqlDataAdapter("SELECT count(*) FROM DoctorSettings WHERE Username='" + unameTxt.Text + "' AND Password='" + pwTxt.Text + "'", con);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                Texttransfer.Uname = unameTxt.Text;
                this.Hide();
                new Doctor().Show();
            }
            else
                MessageBox.Show("Invalid username or password");
        }

        private void OtherLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PRLogin().Show();
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Signup().Show();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 log = new Form1();
            log.Show();
        }

    }
}
