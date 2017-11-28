using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                var ch = new Change();
                ch.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var stat = new Data();
            stat.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var report = new Report();
            report.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var edit = new Edit();
            edit.ShowDialog();
        }
    }

}
