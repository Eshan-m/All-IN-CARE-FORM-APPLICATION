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
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PProfileSettings log = new PProfileSettings();
            log.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            PHealthinfo log = new PHealthinfo();
            log.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Channel log = new Channel();
            log.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            POrder log = new POrder();
            log.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorDetails log = new DoctorDetails();
            log.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Appointment log = new Appointment();
            log.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            PaymentDetails log = new PaymentDetails();
            log.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        private void Patient_Load(object sender, EventArgs e)
        {
            unameTxt.Text = Texttransfer.Uname;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            LOGIN log = new LOGIN();
            log.Show();
        }

        private void btnPRefresh_Click(object sender, EventArgs e)
        {
            String conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\isuru\OneDrive\Desktop\All-IN-CARE-FORM-APPLICATION\AllInCare.mdf;Integrated Security=True;Connect Timeout=30";
            String query = "SELECT * FROM Patient";

            SqlDataAdapter adapter = new SqlDataAdapter(query, conString);
            DataSet set = new DataSet();
            adapter.Fill(set, "Patient");
            dataGridView1.DataSource = set.Tables["Patient"];
        }       

        private void button12_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Desktop\All-IN-CARE-FORM-APPLICATION\AllInCare.mdf;Integrated Security=True;Connect Timeout=30");
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
