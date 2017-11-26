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
    public partial class Showing : Form
    {
        public Showing()
        {
            InitializeComponent();
        }

        private void входToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var admin = new Enter();
            admin.ShowDialog();
        }

        private void Showing_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "railroadDataSet1.Engine". При необходимости она может быть перемещена или удалена.
            this.engineTableAdapter.Fill(this.railroadDataSet1.Engine);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "railroadDataSet.TrainStations". При необходимости она может быть перемещена или удалена.
            this.trainStationsTableAdapter.Fill(this.railroadDataSet.TrainStations);
            dataGridView1.AutoGenerateColumns = true;
        }
    }
}
