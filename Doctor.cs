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
    public partial class Doctor : Form
    {
        public Doctor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DProfileSettings log = new DProfileSettings();
            log.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DChannels log = new DChannels();
            log.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            PatientRecords logs = new PatientRecords();
            logs.Show();
        }
    }
}
