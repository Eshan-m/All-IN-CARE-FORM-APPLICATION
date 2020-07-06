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
    public partial class POrder : Form
    {
        public POrder()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pharmacy log = new Pharmacy();
            log.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Patient log = new Patient();
            log.Show();

        }
    }
}
