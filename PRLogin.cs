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
    public partial class PRLogin : Form
    {
        public PRLogin()
        {
            InitializeComponent();
        }

        private void PharmacyLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\isuru\OneDrive\Desktop\All-IN-CARE-FORM-APPLICATION\AllInCare.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sd = new SqlDataAdapter("SELECT count(*) FROM  PharmacySettings WHERE Username='" + unameTxt.Text + "' AND Password='" + pwTxt.Text + "'", con);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                Texttransfer.Uname = unameTxt.Text;
                this.Hide();
                new Pharmacy().Show();
            }
            else
                MessageBox.Show("Invalid username or password");
        }

        private void RiderLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\isuru\OneDrive\Desktop\All-IN-CARE-FORM-APPLICATION\AllInCare.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sd = new SqlDataAdapter("SELECT count(*) FROM RiderSettings WHERE Username='" + unameTxt.Text + "' AND Password='" + pwTxt.Text + "'", con);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                Texttransfer.Uname = unameTxt.Text;
                this.Hide();
                new Rider().Show();
            }
            else
                MessageBox.Show("Invalid username or password");
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Signup().Show();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LOGIN log = new LOGIN();
            log.Show();
        }
    }
}
