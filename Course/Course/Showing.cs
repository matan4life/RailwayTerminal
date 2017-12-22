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
        public List<List<bool>> graph = new List<List<bool>>();
        public List<string> routes = new List<string>();
        public Dictionary<string, int> vertixes = new Dictionary<string, int>();
        public Dictionary<string, double> cost = new Dictionary<string, double>();
        public string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\GIGABYTE\RailwayTerminal\Course\Course\Railroad.mdf;Integrated Security=True";
        public Showing()
        {
            InitializeComponent();
        }

        private void входToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var admin = new Enter();
            admin.ShowDialog();
        }
        private void FillGraph()
        {
            for (int i=0; i<5; i++)
            {
                graph.Add(new List<bool>());
            }
            graph[0].Add(false);
            graph[0].Add(true);
            graph[0].Add(false);
            graph[0].Add(true);
            graph[0].Add(true);
            graph[1].Add(false);
            graph[1].Add(false);
            graph[1].Add(true);
            graph[1].Add(false);
            graph[1].Add(false);
            graph[2].Add(false);
            graph[2].Add(false);
            graph[2].Add(false);
            graph[2].Add(true);
            graph[2].Add(false);
            graph[3].Add(false);
            graph[3].Add(false);
            graph[3].Add(false);
            graph[3].Add(false);
            graph[3].Add(false);
            graph[4].Add(false);
            graph[4].Add(true);
            graph[4].Add(false);
            graph[4].Add(false);
            graph[4].Add(false);
        }
        private void Bfs(int start, int end)
        {
            if (start == 0 && end == 2)
            {
                routes.Add("012");
                routes.Add("042");
            }
            else if (start==0 && end == 1)
            {
                routes.Add("01");
            }
            else if (start==0 && end == 3)
            {
                routes.Add("03");
                routes.Add("0123");
            }
            else if (start==0 && end == 4)
            {
                routes.Add("04");
            }
            else if (start==1 && end == 2)
            {
                routes.Add("12");
            }
            else if (start==1 && end == 3)
            {
                routes.Add("123");
            }
            else if (start==2 && end == 3)
            {
                routes.Add("23");
            }
            else if (start==3 && end == 4)
            {
                routes.Add("34");
            }
            else if (start==3 && end == 2)
            {
                routes.Add("342");
            }
            else if (start==4 && end == 2)
            {
                routes.Add("42");
            }
            else if (start==4 && end == 3)
            {
                routes.Add("423");
            }
        }
        private void Main(int a, int b)
        {
            Bfs(a, b);
            if (routes.Count == 0)
            {
                MessageBox.Show("Не найдено таких поездов.");
                return;
            }
            List<string> stations = new List<string>();
            List<TimeSpan> times = new List<TimeSpan>();
            foreach (string route in routes)
            {
                foreach (char symbol in route)
                {
                    foreach (string key in vertixes.Keys)
                    {
                        if (vertixes[key] == Convert.ToInt32(symbol.ToString()))
                        {
                            stations.Add(key);
                            break;
                        }
                    }
                }
                double cost = 0;
                for (int i=0; i<stations.Count-1; i++)
                {
                    label1.Text += "Поезд №" + FindTrain(stations[i], stations[i + 1]).ToString() + "\n" + stations[i] + "-" + stations[i + 1] + "\n" + "Время в пути: " + SubstractTimes(stations[i], stations[i + 1]).ToString()+"\n";
                    times.Add(SubstractTimes(stations[i], stations[i + 1]));
                    cost += TrainCost(FindTrain(stations[i], stations[i + 1]), stations[i], stations[i + 1]);
                }
                label1.Text += "Всего в пути: " + Sum(times).ToString() + "\n";
                label1.Text += "Стоимость маршрута: " + Math.Round(cost, 2)+"\n"+"\n";
                stations.Clear();
                times.Clear();
            }
        }
        private TimeSpan Sum(List<TimeSpan> list)
        {
            TimeSpan t = list[0];
            for (int i=1; i<list.Count; i++)
            {
                t=t.Add(list[i]);
            }
            return t;
        }
        private int FindTrain(string start, string end)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (dataGridView1.Rows.IndexOf(row) != dataGridView1.Rows.Count - 1)
                {
                    if (row.Cells[1].Value.ToString() == start && row.Cells[2].Value.ToString() == end)
                    {
                        return Convert.ToInt32(row.Cells[0].Value);
                    }
                }
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                using (SqlConnection connection=new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    bool flag1 = false, flag2 = false;
                    string sql = "SELECT StationId FROM TrainStations WHERE TrainId=" + row.Cells[0].Value.ToString();
                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        if (reader.GetString(0) == start)
                        {
                            flag1 = true;
                        }
                        else if (reader.GetString(0) == end)
                        {
                            flag2 = true;
                        }
                    }
                    if (flag1 && flag2)
                    {
                        return Convert.ToInt32(row.Cells[0].Value);
                    }
                }
            }
            return -1;
        }
        private TimeSpan SubstractTimes(string start, string end)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (dataGridView1.Rows.IndexOf(row) != dataGridView1.Rows.Count - 1)
                {
                    if (row.Cells[1].Value.ToString() == start && row.Cells[2].Value.ToString() == end)
                    {

                        TimeSpan time1 = TimeSpan.Parse(row.Cells[3].Value.ToString());
                        TimeSpan time2 = TimeSpan.Parse(row.Cells[4].Value.ToString());
                        TimeSpan time = time2.Subtract(time1);
                        if (time.Hours < 0)
                        {
                            time = time.Add(new TimeSpan(24, 0, 0));
                        }
                        return time;
                    }
                }
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    bool flag1 = false, flag2 = false;
                    TimeSpan t1 = new TimeSpan();
                    TimeSpan t2 = new TimeSpan();
                    string sql = "SELECT StationId, ArrivalTime FROM TrainStations WHERE TrainId=" + row.Cells[0].Value.ToString()+" ORDER BY TravelDate, ArrivalTime";
                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        if (reader.GetString(0) == start)
                        {
                            flag1 = true;
                            t1 = reader.GetTimeSpan(1);
                        }
                        else if (reader.GetString(0) == end)
                        {
                            flag2 = true;
                            t2 = reader.GetTimeSpan(1);
                        }
                    }
                    if (flag1 && flag2)
                    {
                        TimeSpan t3=t2.Subtract(t1);
                        return t3.Hours > 0 ? t3 : t3.Add(new TimeSpan(24, 0, 0));
                    }
                }
            }
            return new TimeSpan();
        }
        private bool Consist(string route, string vertex)
        {
            if (route == vertex) return true;
            for (int i=0; i<route.Length-1; i++)
            {
                if (route.Substring(i, 1) == vertex) return true;
            }
            return false;
        }
        private void Showing_Load(object sender, EventArgs e)
        {
            vertixes["Харьков-Пассажирский"] = 0;
            vertixes["Киев-Пассажирский"] = 1;
            vertixes["Львов-Главный"] = 2;
            vertixes["Кировоград"] = 3;
            vertixes["Одесса-Главная"] = 4;
            cost["Интерсити 1 класса"] = 306.58;
            cost["Интерсити 2 класса"] = 168.48;
            cost["Плацкартный"] = 96.02;
            dataGridView1.AutoGenerateColumns = true;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                int id = 0;
                string name = "";
                TimeSpan time = new TimeSpan();
                string sql = "SELECT TrainId, StationId, ArrivalTime, StayTime FROM TrainStations ORDER BY TrainId, TravelDate, ArrivalTime";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.GetInt32(0) != id)
                    {
                        if (dataGridView1.Rows.Count == 1)
                        {
                            dataGridView1.Rows.Add();
                            dataGridView1.Rows[0].Cells[0].Value = reader.GetInt32(0);
                            dataGridView1.Rows[0].Cells[1].Value = reader.GetString(1);
                            TimeSpan tmp = reader.GetTimeSpan(2);
                            int tmp1 = reader.GetInt32(3);
                            TimeSpan tmp2 = new TimeSpan(0, tmp1, 0);
                            tmp.Add(tmp2);
                            dataGridView1.Rows[0].Cells[3].Value = tmp;
                            id = reader.GetInt32(0);
                        }
                        else
                        {
                            dataGridView1.Rows.Add();
                            dataGridView1.Rows[dataGridView1.Rows.Count - 3].Cells[2].Value = name;
                            dataGridView1.Rows[dataGridView1.Rows.Count - 3].Cells[4].Value = time;
                            dataGridView1.Rows[dataGridView1.Rows.Count-2].Cells[0].Value = reader.GetInt32(0);
                            dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[1].Value = reader.GetString(1);
                            TimeSpan tmp = reader.GetTimeSpan(2);
                            int tmp1 = reader.GetInt32(3);
                            TimeSpan tmp2 = new TimeSpan(0, tmp1, 0);
                            tmp.Add(tmp2);
                            dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[3].Value = tmp;
                            id = reader.GetInt32(0);
                        }
                    }
                    else
                    {
                        id = reader.GetInt32(0);
                        name = reader.GetString(1);
                        time = reader.GetTimeSpan(2);
                    }
                }
                dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[2].Value = name;
                dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[4].Value = time;
            }
            FillGraph();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            routes.Clear();
            int a = vertixes[comboBox1.SelectedItem.ToString()];
            int b= vertixes[comboBox2.SelectedItem.ToString()];
            Main(a, b);
        }
    }
}
