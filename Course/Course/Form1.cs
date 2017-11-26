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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void входToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var admin = new Enter();
            admin.ShowDialog();
        }

        private void расписаниеПоездовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Show = new Showing();
            Show.ShowDialog();
        }
        private void FillPlaces()
        {

        }
    }
}
