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
            String query = "insert into PatientSettings(UserName,FirstName,LastName,BirthDate,AdressLine1,AdressLine2,ZipCode,Province,Email,MobileNo1,MobileNo2,EmergencyNo1,EmergencyNo2) values ('" + Username.Text + "','" + FName.Text + "','" + LName.Text + "','" + BDdate.Value.ToString() + "','" + AdLine1.Text + "','" + ADLine2.Text + "','" + ZipCode.Text + "','" + Province.Text + "','" + Mail.Text + "','" + MbNo1.Text + "','" + MbNo2.Text + "','" + ECNo1.Text + "','" + ECNo2.Text + "')";
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
