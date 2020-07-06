using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Appoinment log = new Appoinment();
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
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
