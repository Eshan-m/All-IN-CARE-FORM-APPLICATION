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
            Signup log = new Signup();
            log.Show();
          
        }

        private void PRLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
