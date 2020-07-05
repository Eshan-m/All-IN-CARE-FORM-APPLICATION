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
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            PRLogin olog = new PRLogin();
            olog.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Patient p = new Patient();
            p.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Doctor d = new Doctor();
            d.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Signup log = new Signup();
            log.Show();
        }
    }
}
