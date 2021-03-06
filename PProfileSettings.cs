﻿using System;
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
            String query = "update PatientSettings Set FirstName='" + this.FName.Text + "',LastName='" + this.LName.Text + "',BirthDate='" + this.BDdate.Value.ToString() + "',AdressLine1='" + this.AdLine1.Text + "',AdressLine2='" + this.ADLine2.Text + "',ZipCode='" + this.ZipCode.Text + "',Province='" + this.Province.Text + "',Email='" + this.Mail.Text + "',MobileNo1='" + this.MbNo1.Text + "',MobileNo2='" + this.MbNo2.Text + "',EmergencyNo1='" + this.ECNo1.Text + "',EmergencyNo2='" + this.ECNo2.Text + "'where UserName='" + this.Username.Text + "';";
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
