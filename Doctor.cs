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
    public partial class Doctor : Form
    {
        public Doctor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DProfileSettings log = new DProfileSettings();
            log.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DChannels log = new DChannels();
            log.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientRecords logs = new PatientRecords();
            logs.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            LOGIN log = new LOGIN();
            log.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\isuru\OneDrive\Desktop\All-IN-CARE-FORM-APPLICATION\AllInCare.mdf;Integrated Security=True;Connect Timeout=30";
            String query = "SELECT * FROM CurrentChannels";

            SqlDataAdapter adapter = new SqlDataAdapter(query, conString);
            DataSet set = new DataSet();
            adapter.Fill(set, "CurrentChannels");
            dataGridView1.DataSource = set.Tables["CurrentChannels"];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
