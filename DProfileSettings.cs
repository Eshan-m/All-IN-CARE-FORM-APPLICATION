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
            String query = "update DoctorSettings where Username='" + Username.Text + "'set FirstName='" + Fname.Text + "' set LastName='" + Lname.Text + "'set BirthDate='" + BDdate.Value.ToString() + "'set AddressLine1='" + ADLine1.Text + "'set AddressLine2='" + ADLine2.Text + "'set Zipcode='" + ZipCode.Text + "' set Province='" + Province.Text + "' set Email='" + Mail.Text + "' set MobileNo1='" + MN1.Text + "'set MobileNo2='" + MN2.Text + "'set EmergencyNo1='" + EC1.Text + "'set EmergencyNo2='" + EC2.Text + "'";
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
