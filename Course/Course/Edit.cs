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
    public partial class Edit : Form
    {
        public string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Владелец\Desktop\DB\Course\Course\Railroad.mdf;Integrated Security=True";
        public Edit()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                listBox1.Visible = true;
                textBox4.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                numericUpDown1.Visible = true;
                button1.Visible = true;
                button2.Visible = true;
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string sql = "SELECT StationName FROM Terminal";
                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        listBox1.Items.Add(reader.GetString(0));
                    }
                    connection.Close();
                }
                listBox1.SelectedItems.Add(listBox1.Items[0]);
                listBox1_SelectedValueChanged(sender, e);
            }
            else
            {
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                listBox1.Visible = false;
                textBox4.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                numericUpDown1.Visible = false;
                button1.Visible = false;
                button2.Visible = false;
            }
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string sql = "SELECT TerminalName, Country, City, YearOfFoundation, Description FROM Terminal WHERE StationName IN (N'"+listBox1.SelectedItem.ToString()+"')";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    textBox1.Text = reader.GetString(0);
                    textBox2.Text = reader.GetString(1);
                    textBox3.Text = reader.GetString(2);
                    numericUpDown1.Value = Convert.ToDecimal(reader.GetInt32(3));
                    textBox4.Text = reader.GetString(4);
                }
                connection.Close();
            }
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "railroadDataSet2.TrainStations". При необходимости она может быть перемещена или удалена.
            this.trainStationsTableAdapter.Fill(this.railroadDataSet2.TrainStations);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "railroadDataSet2.Carriage". При необходимости она может быть перемещена или удалена.
            this.carriageTableAdapter.Fill(this.railroadDataSet2.Carriage);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "railroadDataSet2.Engine". При необходимости она может быть перемещена или удалена.
            this.engineTableAdapter.Fill(this.railroadDataSet2.Engine);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "railroadDataSet2.Train". При необходимости она может быть перемещена или удалена.
            this.trainTableAdapter.Fill(this.railroadDataSet2.Train);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "railroadDataSet2.Terminal". При необходимости она может быть перемещена или удалена.
            this.terminalTableAdapter.Fill(this.railroadDataSet2.Terminal);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                terminalTableAdapter.UpdateQuery(listBox1.SelectedItem.ToString(), textBox1.Text, textBox2.Text, textBox3.Text, Convert.ToInt32(numericUpDown1.Value), textBox4.Text, listBox1.SelectedItem.ToString());
                radioButton1_CheckedChanged(sender, e);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибббочка");
            }
        }

        private void Edit_FormClosing(object sender, FormClosingEventArgs e)
        {
            terminalTableAdapter.Update(railroadDataSet2);
            trainTableAdapter.Update(railroadDataSet2);
            engineTableAdapter.Update(railroadDataSet2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                terminalTableAdapter.DeleteQuery(listBox1.SelectedItem.ToString());
                terminalTableAdapter.Update(railroadDataSet2);
                listBox1_SelectedValueChanged(sender, e);
                radioButton1_CheckedChanged(sender, e);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибббочка");
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                label7.Visible = true;
                label8.Visible = true;
                listBox2.Visible = true;
                listBox3.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                listBox2.Items.Clear();
                listBox3.Items.Clear();
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string sql = "SELECT TrainId FROM Train";
                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        listBox2.Items.Add(reader.GetInt32(0));
                    }
                }
            }
            else
            {
                label7.Visible = false;
                label8.Visible = false;
                listBox2.Visible = false;
                listBox3.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string sql = "SELECT EngineId FROM Train WHERE TrainId="+listBox2.SelectedItem;
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    listBox3.Items.Add(reader.GetInt32(0));
                }
                sql = "SELECT EngineId FROM Engine WHERE EngineId NOT IN (SELECT EngineId FROM Train WHERE TrainId="+listBox2.SelectedItem+")";
                reader.Close();
                command = new SqlCommand(sql, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    listBox3.Items.Add(reader.GetInt32(0));
                }
                connection.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                trainTableAdapter.UpdateQuery(Convert.ToInt32(listBox2.SelectedItem), Convert.ToInt32(listBox3.SelectedItem), Convert.ToInt32(listBox2.SelectedItem));
                this.OnLoad(e);
                radioButton2_CheckedChanged(sender, e);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибббочка");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                trainTableAdapter.DeleteQuery(Convert.ToInt32(listBox2.SelectedItem));
                trainTableAdapter.Update(railroadDataSet2);
                radioButton2_CheckedChanged(sender, e);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM Carriage WHERE TrainId="+listBox2.SelectedItem;
                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        carriageTableAdapter.UpdateQuery(reader.GetInt32(0), null, null, reader.GetString(3), reader.GetInt32(0));
                    }
                    sql = "SELECT * FROM TrainStations WHERE TrainId=" + listBox2.SelectedItem;
                    reader.Close();
                    command = new SqlCommand(sql, connection);
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        trainStationsTableAdapter.DeleteQuery(reader.GetString(0), reader.GetInt32(1), reader.GetDateTime(4));
                    }
                    connection.Close();
                }
                trainTableAdapter.DeleteQuery(Convert.ToInt32(listBox2.SelectedItem));
                trainTableAdapter.Update(railroadDataSet2);
                radioButton2_CheckedChanged(sender, e);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибббочка");
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                label9.Visible = true;
                label10.Visible = true;
                listBox4.Visible = true;
                listBox5.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
                listBox4.Items.Clear();
                listBox5.Items.Clear();
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string sql = "SELECT EngineId FROM Engine";
                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        listBox4.Items.Add(reader.GetInt32(0));
                    }
                }
            }
            else
            {
                label9.Visible = false;
                label10.Visible = false;
                listBox4.Visible = false;
                listBox5.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
            }
            listBox4.SelectedItem = listBox4.Items[0];
            listBox4_SelectedValueChanged(sender, e);
        }

        private void listBox4_SelectedValueChanged(object sender, EventArgs e)
        {
            listBox5.Items.Clear();
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string sql = "SELECT Type FROM Engine WHERE EngineId=" + listBox4.SelectedItem.ToString();
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    listBox5.Items.Add(reader.GetString(0));
                }
                sql = "SELECT Name FROM EngineModels WHERE Name NOT IN (SELECT Type FROM Engine WHERE EngineId=" + listBox4.SelectedItem + ")";
                reader.Close();
                command = new SqlCommand(sql, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    listBox5.Items.Add(reader.GetString(0));
                }
                connection.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                engineTableAdapter.UpdateQuery(Convert.ToInt32(listBox4.SelectedItem), listBox5.SelectedItem.ToString(), Convert.ToInt32(listBox4.SelectedItem));
                engineTableAdapter.Update(railroadDataSet2);
                radioButton3_CheckedChanged(sender, e);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибббочка");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                engineTableAdapter.DeleteQuery(Convert.ToInt32(listBox4.SelectedItem));
                engineTableAdapter.Update(railroadDataSet2);
                radioButton3_CheckedChanged(sender, e);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM Train WHERE EngineId=" + listBox4.SelectedItem;
                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        trainTableAdapter.UpdateQuery(reader.GetInt32(0), null, reader.GetInt32(0));
                    }
                    connection.Close();
                }
                engineTableAdapter.DeleteQuery(Convert.ToInt32(listBox4.SelectedItem));
                engineTableAdapter.Update(railroadDataSet2);
                radioButton3_CheckedChanged(sender, e);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибббочка");
            }
        }
    }
}
