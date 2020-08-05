using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Contact : Form
    {
        public Contact()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = nameTxt.Text;
            string prob = probTxt.Text;
            string tele = teleTxt.Text;
            string email = emailTxt.Text;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\EDUCATION\1 Year SEM 3\Object Oriented Programming with C#\Assigments\SEM END Project\All-IN-CARE-FORM-APPLICATION\AllInCare.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "insert into Contact(Name,Problem,Tele,Email) values('" + name + "','" + prob + "','" + tele + "','" + email + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Your Problem Has been Submitted successfully");
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Error submitting your problem");
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
          
          

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 log = new Form1();
            log.Show();

            
            
        }
    }
}
