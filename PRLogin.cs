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
    public partial class PRLogin : Form
    {
        public PRLogin()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signup log = new Signup();
            log.Show();
          
        }

        private void PRLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pharmacy pl = new Pharmacy();
            pl.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rider rl = new Rider();
            rl.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            LOGIN log = new LOGIN();
            log.Show();
        }
    }
}
