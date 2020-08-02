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
    public partial class PProfileSettings : Form
    {
        public PProfileSettings()
        {
            InitializeComponent();
        }       

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\EDUCATION\1 Year SEM 3\Object Oriented Programming with C#\Assigments\SEM END Project\All-IN-CARE-FORM-APPLICATION\AllInCare.mdf;Integrated Security=True;Connect Timeout=30");
            String query = "update PatientSettings where UserName='" + Username.Text + "'set FirstName='" + FName.Text + "'set LastName='" + LName.Text + "' set BirthDate='" + BDdate.Value.ToString() + "'set AdressLine1='" + AdLine1.Text + "'set AdressLine2='" + ADLine2.Text + "'set ZipCode='" + ZipCode.Text + "'set Province='" + Province.Text + "'set Email='" + Mail.Text + "' set MobileNo1='" + MbNo1.Text + "' set MobileNo2='" + MbNo2.Text + "' set EmergencyNo1='" + ECNo1.Text + "' set EmergencyNo2='" + ECNo2.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            this.Hide();
            Patient log = new Patient();
            log.Show();
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Your Records Updated Successfully");                
            }
            catch(SqlException ex)
            {
                MessageBox.Show("TRY AGAIN ERROR OCCURED!!");
                Console.Write(ex.ToString());
                

            }
            finally
            {
                con.Close();
            }
          
        }
    }
}
