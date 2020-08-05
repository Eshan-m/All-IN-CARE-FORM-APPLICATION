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
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            LOGIN log = new LOGIN();
            log.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\EDUCATION\1 Year SEM 3\Object Oriented Programming with C#\Assigments\SEM END Project\All-IN-CARE-FORM-APPLICATION\AllInCare.mdf;Integrated Security=True;Connect Timeout=30";
            string query = "SELECT * FROM CurrentChannels";

            SqlDataAdapter adapter = new SqlDataAdapter(query, conString);
            DataSet set = new DataSet();
            adapter.Fill(set, "CurrentChannels");
            dataGridView1.DataSource = set.Tables["CurrentChannels"];
        }

        private void Doctor_Load(object sender, EventArgs e)
        {
            unameTxt.Text = Texttransfer.Uname;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\EDUCATION\1 Year SEM 3\Object Oriented Programming with C#\Assigments\SEM END Project\All-IN-CARE-FORM-APPLICATION\AllInCare.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "delete from PatientSettings where Username= '" + unameTxt.Text + "' ";
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                if (MessageBox.Show("Do you really want to delete your account??", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deletion was successfull");
                    this.Close();
                    Form1 f1 = new Form1();
                    f1.Show();
                }
                else
                    this.Show();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Oops there's a problem deleting your account please try again later");
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }
    }
}
