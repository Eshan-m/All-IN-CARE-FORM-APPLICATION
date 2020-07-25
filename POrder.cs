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
    public partial class POrder : Form
    {
        public POrder()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Desktop\All-IN-CARE-FORM-APPLICATION\AllInCare.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "insert into [Order](FullName,Address,Prescription) values('" + fnameTxt.Text + "','" + adTxt.Text + "','" + prescmb.Text + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            try
            { 
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Recorded");
                this.Hide();
                Pharmacy log = new Pharmacy();
                log.Show();

            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Failed to record");
            }
            finally
            {
                con.Close();
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Patient log = new Patient();
            log.Show();

        }
    }
}
