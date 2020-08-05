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
    public partial class Rider : Form
    {
        public Rider()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            PRLogin log = new PRLogin();
            log.Show();
        }

        private void Rider_Load(object sender, EventArgs e)
        {
            unameTxt.Text = Texttransfer.Uname;
        }

        private void button11_Click(object sender, EventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
