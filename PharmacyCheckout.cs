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
    public partial class PharmacyCheckout : Form
    {
         
        public PharmacyCheckout()
        {
            InitializeComponent();
        }

        string Payment;
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please Log In before Odering!!");
            this.Hide();
            LOGIN cn = new LOGIN();
            cn.Show();

        }                

        private void cashBtn_CheckedChanged(object sender, EventArgs e)
        {
            Payment = "Cash On Delivery";
        }

        private void payBtn_CheckedChanged(object sender, EventArgs e)
        {
            Payment = "Pay Now";
        }        

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 log = new Form1();
            log.Show();
        }
    }
}
