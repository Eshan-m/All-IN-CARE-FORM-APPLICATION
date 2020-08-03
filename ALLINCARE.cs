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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Contact c = new Contact();
            c.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LOGIN log = new LOGIN();
            log.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            PharmacyCheckout p = new PharmacyCheckout();
            p.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Channel ch = new Channel();
            ch.Show();
        }      
    }
}
