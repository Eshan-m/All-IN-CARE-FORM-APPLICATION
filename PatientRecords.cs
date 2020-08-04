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
    public partial class PatientRecords : Form
    {
        public PatientRecords()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Doctor log = new Doctor();
            log.Show();
        }

        private void btnCChannels_Click(object sender, EventArgs e)
        {

        }

        private void btnPRRefresh_Click(object sender, EventArgs e)
        {
            String conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\isuru\OneDrive\Desktop\All-IN-CARE-FORM-APPLICATION\AllInCare.mdf;Integrated Security=True;Connect Timeout=30";
            String query = "SELECT * FROM PatientRecords";

            SqlDataAdapter adapter = new SqlDataAdapter(query, conString);
            DataSet set = new DataSet();
            adapter.Fill(set, "PatientRecords");
            dataGridView1.DataSource = set.Tables["PatientRecords"];
        }
    }
}
