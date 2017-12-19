using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Course
{
    public partial class Showing : Form
    {
        public string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Владелец\Desktop\DB\Course\Course\Railroad.mdf;Integrated Security=True";
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

            dataGridView1.AutoGenerateColumns = true;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                int number = 0, count = 0;
                string start = "", end = "", starttime = "", endtime = "", time = "", tmp = "";
                string sql = "SELECT TrainId, StationId, ArrivalTime FROM TrainStations ORDER BY TrainId, TravelDate, ArrivalTime";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (number != reader.GetInt32(0))
                    {
                        end = tmp;
                        endtime = time;
                        if (number != 0)
                        {
                            dataGridView1.Rows.Add();
                            dataGridView1.Rows[count].Cells[0].Value = number;
                            dataGridView1.Rows[count].Cells[1].Value = start;
                            dataGridView1.Rows[count].Cells[2].Value = end;
                            dataGridView1.Rows[count].Cells[3].Value = starttime;
                            dataGridView1.Rows[count].Cells[4].Value = endtime;
                            count++;
                        }
                        starttime = reader.GetValue(2).ToString();
                        start = reader.GetString(1);
                        number = reader.GetInt32(0);
                    }
                    else
                    {
                        tmp = reader.GetString(1);
                        time = reader.GetValue(2).ToString();
                    }
                }
                connection.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
