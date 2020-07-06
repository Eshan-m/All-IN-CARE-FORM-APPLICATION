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
    public partial class Contact : Form
    {
        public Contact()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Your Problem Has been Submitted");
            Contact log = new Contact();
            log.Show();
            return;
          

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 log = new Form1();
            log.Show();

            
            
        }
    }
}
