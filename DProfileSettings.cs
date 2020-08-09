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

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\EDUCATION\1 Year SEM 3\Object Oriented Programming with C#\Assigments\SEM END Project\All-IN-CARE-FORM-APPLICATION\AllInCare.mdf;Integrated Security=True;Connect Timeout=30");
            String query = "update DoctorSettings set FirstName = '" +this.Fname.Text + "' ,LastName ='" + this.Lname.Text + "'  ,BirthDate='" + this.BDdate.Value + "',AddressLine1='" + this.ADLine1.Text + "',AddressLine2='" + this.ADLine2.Text + "',Zipcode='" + this.ZipCode.Text + "' ,Province='" + this.Province.Text + "',Email='" + this.Mail.Text + "' ,MobileNo1='" + this.MN1.Text + "',MobileNo2='" + this.MN2.Text + "',EmergencyNo1='" + this.EC1.Text + "',EmergencyNo2='" + this.EC2.Text + "'where Username ='" + this.Username.Text + "';";
           
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
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

       
    }
}
