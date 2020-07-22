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
    public partial class DoctorDetails : Form
    {
        public DoctorDetails()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Channel log = new Channel();
            log.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Patient log = new Patient();
            log.Show();
               
        }

        private void btnDocInfo_Click(object sender, EventArgs e)
        {
            String conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\isuru\OneDrive\Desktop\All-IN-CARE-FORM-APPLICATION\AllInCare.mdf;Integrated Security=True;Connect Timeout=30";
            String query = "SELECT * FROM DoctorDetails";

            SqlDataAdapter adapter = new SqlDataAdapter(query, conString);
            DataSet set = new DataSet();

            adapter.Fill(set, "DoctorDetails");
            dataGridView1.DataSource = set.Tables["DoctorDetails"];
        }
    }
}
