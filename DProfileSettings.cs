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
    public partial class DProfileSettings : Form
    {
        public DProfileSettings()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\EDUCATION\1 Year SEM 3\Object Oriented Programming with C#\Assigments\SEM END Project\All-IN-CARE-FORM-APPLICATION\AllInCare.mdf;Integrated Security=True;Connect Timeout=30");
            String query = "insert into DoctorProfile(Username,FirstName,LastName,BirthDate,AddressLine1,AddressLine2,Zipcode,Province,Email,MobileNo1,MobileNo2,EmergencyNo1,EmergencyNo2) values ('" + Username.Text + "','" + Fname.Text + "','" + Lname.Text + "','" + BDdate.Value.ToString() + "','" + ADLine1.Text + "','" + ADLine2.Text + "','" + ZipCode.Text + "','" + Province.Text + "','" + Mail.Text + "','" + MN1.Text + "','" + MN2.Text + "','" + EC1.Text + "','" + EC2.Text + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            this.Hide();
            Doctor log = new Doctor();
            log.Show();
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Your Records Updated Successfully");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("TRY AGAIN ERROR OCCURED!!");
                //Console.Write(ex.ToString());
                MessageBox.Show(ex.ToString());


            }
            finally
            {
                con.Close();
            }
        }

       
    }
}
