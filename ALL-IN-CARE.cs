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

        private void Form1_Load(object sender, EventArgs e)
        {

        }      

        private void button3_Click(object sender, EventArgs e)
        {
            Contact c = new Contact();
            c.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LOGIN log = new LOGIN();
            log.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Pharmacy p = new Pharmacy();
            p.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Channel ch = new Channel();
            ch.Show();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          
        }
    }
}
