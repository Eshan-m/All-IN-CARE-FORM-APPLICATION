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
    public partial class Pharmacy : Form
    {
         
        public Pharmacy()
        {
            InitializeComponent();
        }

        string Payment;
        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Desktop\All-IN-CARE-FORM-APPLICATION\Pharmacy.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "insert into Pharmacy(City,Pharmacy,Date,Payment) values('" + cityCmb.Text + "','" + pharmacyLst.Text + "','" + dateCal.CustomFormat + "','" + Payment + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            this.Hide();
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Records were added successfully");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Error your values didn't added");
            }
            finally
            {
                con.Close();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
           
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cashBtn_CheckedChanged(object sender, EventArgs e)
        {
            Payment = "Cash On Delivery";
        }

        private void payBtn_CheckedChanged(object sender, EventArgs e)
        {
            Payment = "Pay Now";
        }
    }
}
