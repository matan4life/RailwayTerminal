﻿using System;
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
    public partial class Change : Form
    {
        public int CurrentValue = 0;
        public List<DataGridViewRow> Rows = new List<DataGridViewRow>();
        public string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\GIGABYTE\RailwayTerminal\Course\Course\Railroad.mdf;Integrated Security=True";
        public Change()
        {
            InitializeComponent();
        }
        private void FillEngine(string commandsql)
        {
            while (dataGridView2.Rows.Count != 1)
            {
                dataGridView2.Rows.RemoveAt(0);
            }
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string sql = commandsql;
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();
                int counter = 0;
                while (reader.Read())
                {
                    //dataGridView1.Rows[counter].Cells[0].Value = reader.GetInt32(0).ToString();
                    //dataGridView1.Rows[counter].Cells[1].Value = reader.GetString(1);
                    //dataGridView1.Rows[counter].Cells[2].Value = reader.GetString(2);
                    //dataGridView1.Rows[counter].Cells[3].Value = reader.GetInt32(3).ToString();
                    dataGridView2.Rows.Add();
                    dataGridView2.Height += dataGridView2.RowTemplate.Height;

                }
                reader.Close();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    dataGridView2.Rows[counter].Cells[0].Value = reader.GetInt32(0).ToString();
                    dataGridView2.Rows[counter].Cells[1].Value = reader.GetString(1);
                    dataGridView2.Rows[counter].Cells[2].Value = reader.GetString(2);
                    dataGridView2.Rows[counter].Cells[3].Value = reader.GetInt32(3).ToString();
                    counter++;
                }
                connection.Close();
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                label13.Visible = true;
                textBox1.Visible = true;
                listBox1.Visible = true;
                numericUpDown1.Visible = true;
                textBox2.Visible = true;
                button1.Visible = true;
                carriageDataGridView.DataSource = carriageModelsBindingSource;
            }
            else
            {
                label10.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
                label13.Visible = false;
                textBox1.Visible = false;
                listBox1.Visible = false;
                numericUpDown1.Visible = false;
                textBox2.Visible = false;
                button1.Visible = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                label14.Visible = true;
                label15.Visible = true;
                Generate_Types(listBox2);
                numericUpDown2.Visible = true;
                listBox2.Visible = true;
                button2.Visible = true;
                carriageDataGridView.DataSource = carriageBindingSource;
            }
            else
            {
                label14.Visible = false;
                label15.Visible = false;
                numericUpDown2.Visible = false;
                listBox2.Visible = false;
                button2.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                carriageTableAdapter.InsertQuery(Convert.ToInt32(numericUpDown2.Value), null, null, listBox2.SelectedItem.ToString());
                CreatePlaces(Convert.ToInt32(numericUpDown2.Value));
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибббочка");
            }
        }
        private void CreatePlaces(int id)
        {
            int max = 0, max1=0;
            using (SqlConnection sqlconnection = new SqlConnection(ConnectionString))
            {
                sqlconnection.Open();
                string sql = "SELECT PlaceId FROM Place ORDER BY PlaceId";
                SqlCommand command = new SqlCommand(sql, sqlconnection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    max=reader.GetInt32(0);
                }
                reader.Close();
                sql = "SELECT c1.NumberOfPlaces FROM Carriage c, CarriageModels c1 WHERE c.Type=c1.Name AND c.CarId=" + id + "";
                command = new SqlCommand(sql, sqlconnection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    max1 = reader.GetInt32(0);
                }
                sqlconnection.Close();
            }
            for (int i=max+1; i<=max+max1; i++)
            {
                placeTableAdapter.InsertQuery(i, id, i - max);
            }
        }
        private void Generate_Types(ListBox listbox)
        {
            
            using (SqlConnection sqlconnection=new SqlConnection(ConnectionString))
            {
                sqlconnection.Open();
                string sql = "SELECT Name FROM CarriageModels";
                SqlCommand command = new SqlCommand(sql, sqlconnection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    listbox.Items.Add(reader.GetString(0));
                }
                sqlconnection.Close();
            }
        }
        private void Generate_Types_Engines()
        {
            
            using (SqlConnection sqlconnection = new SqlConnection(ConnectionString))
            {
                sqlconnection.Open();
                string sql = "SELECT Name FROM EngineModels";
                SqlCommand command = new SqlCommand(sql, sqlconnection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    listBox4.Items.Add(reader.GetString(0));
                }
                sqlconnection.Close();
            }
        }

        private void Change_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "railroadDataSet2.TrainStations". При необходимости она может быть перемещена или удалена.
            this.trainStationsTableAdapter.Fill(this.railroadDataSet2.TrainStations);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "railroadDataSet2.Train". При необходимости она может быть перемещена или удалена.
            this.trainTableAdapter.Fill(this.railroadDataSet2.Train);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "railroadDataSet2.Ticket". При необходимости она может быть перемещена или удалена.
            this.ticketTableAdapter.Fill(this.railroadDataSet2.Ticket);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "railroadDataSet2.Terminal". При необходимости она может быть перемещена или удалена.
            this.terminalTableAdapter.Fill(this.railroadDataSet2.Terminal);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "railroadDataSet2.Station". При необходимости она может быть перемещена или удалена.
            this.stationTableAdapter.Fill(this.railroadDataSet2.Station);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "railroadDataSet2.Place". При необходимости она может быть перемещена или удалена.
            this.placeTableAdapter.Fill(this.railroadDataSet2.Place);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "railroadDataSet2.EngineModels". При необходимости она может быть перемещена или удалена.
            this.engineModelsTableAdapter.Fill(this.railroadDataSet2.EngineModels);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "railroadDataSet2.Engine". При необходимости она может быть перемещена или удалена.
            this.engineTableAdapter.Fill(this.railroadDataSet2.Engine);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "railroadDataSet2.CarriageModels". При необходимости она может быть перемещена или удалена.
            this.carriageModelsTableAdapter.Fill(this.railroadDataSet2.CarriageModels);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "railroadDataSet2.Carriage". При необходимости она может быть перемещена или удалена.
            this.carriageTableAdapter.Fill(this.railroadDataSet2.Carriage);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "railroadDataSet21.Train". При необходимости она может быть перемещена или удалена.
            this.trainTableAdapter.Fill(this.railroadDataSet2.Train);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "railroadDataSet2.Terminal". При необходимости она может быть перемещена или удалена.
            this.terminalTableAdapter.Fill(this.railroadDataSet2.Terminal);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "railroadDataSet2.Station". При необходимости она может быть перемещена или удалена.
            this.stationTableAdapter.Fill(this.railroadDataSet2.Station);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "railroadDataSet2.EngineModels". При необходимости она может быть перемещена или удалена.
            this.engineModelsTableAdapter.Fill(this.railroadDataSet2.EngineModels);

            // TODO: данная строка кода позволяет загрузить данные в таблицу "railroadDataSet2.Engine". При необходимости она может быть перемещена или удалена.
            this.engineTableAdapter.Fill(this.railroadDataSet2.Engine);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "railroadDataSet2.Place". При необходимости она может быть перемещена или удалена.
            this.placeTableAdapter.Fill(this.railroadDataSet2.Place);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "railroadDataSet2.Carriage". При необходимости она может быть перемещена или удалена.
            this.carriageTableAdapter.Fill(this.railroadDataSet2.Carriage);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "railroadDataSet2.CarriageModels". При необходимости она может быть перемещена или удалена.
            this.carriageModelsTableAdapter.Fill(this.railroadDataSet2.CarriageModels);
            dataGridView1.AutoGenerateColumns = true;
            carriageDataGridView.AutoGenerateColumns = true;
        }

        private void Change_FormClosing(object sender, FormClosingEventArgs e)
        {
            carriageTableAdapter.Update(railroadDataSet2);
            placeTableAdapter.Update(railroadDataSet2);
            carriageModelsTableAdapter.Update(railroadDataSet2);
            engineTableAdapter.Update(railroadDataSet2);
            engineModelsTableAdapter.Update(railroadDataSet2);
            terminalTableAdapter.Update(railroadDataSet2);
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked)
            {
                label16.Visible = true;
                label17.Visible = true;
                label18.Visible = true;
                label19.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                numericUpDown3.Visible = true;
                listBox3.Visible = true;
                button3.Visible = true;
                carriageDataGridView.DataSource = engineModelsBindingSource;
            }
            else
            {
                label16.Visible = false;
                label17.Visible = false;
                label18.Visible = false;
                label19.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                numericUpDown3.Visible = false;
                listBox3.Visible = false;
                button3.Visible = false;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                label20.Visible = true;
                label21.Visible = true;
                Generate_Types_Engines();
                numericUpDown4.Visible = true;
                listBox4.Visible = true;
                button4.Visible = true;
                carriageDataGridView.DataSource = engineBindingSource;
            }
            else
            {
                label20.Visible = false;
                label21.Visible = false;
                numericUpDown4.Visible = false;
                listBox4.Visible = false;
                button4.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                carriageModelsTableAdapter.InsertQuery(textBox1.Text, listBox1.SelectedItem.ToString(), Convert.ToInt32(numericUpDown1.Value), textBox2.Text);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Ошибббочка");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try {
                engineModelsTableAdapter.InsertQuery(textBox4.Text, listBox3.SelectedItem.ToString(), Convert.ToInt32(numericUpDown3.Value), textBox3.Text);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Ошибббочка");
            }
        }
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)

            {
                label22.Visible = true;
                label23.Visible = true;
                label24.Visible = true;
                button5.Visible = true;
                numericUpDown5.Visible = true;
                numericUpDown6.Visible = true;
                textBox5.Visible = true;
                carriageDataGridView.DataSource = stationBindingSource;
            }
            else
            {
                label22.Visible = false;
                label23.Visible = false;
                label24.Visible = false;
                button5.Visible = false;
                numericUpDown5.Visible = false;
                numericUpDown6.Visible = false;
                textBox5.Visible = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                stationTableAdapter.InsertQuery(textBox5.Text, Convert.ToInt32(numericUpDown5.Value), Convert.ToInt32(numericUpDown6.Value));
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Ошибббочка");
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked)
            {
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                listBox5.Visible = true;
                numericUpDown7.Visible = true;
                textBox6.Visible = true;
                textBox7.Visible = true;
                textBox8.Visible = true;
                textBox9.Visible = true;
                button6.Visible = true;
                using (SqlConnection connection=new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string sql = "SELECT StationName FROM Station";
                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        listBox5.Items.Add(reader.GetString(0));
                    }
                    connection.Close();
                }
                carriageDataGridView.DataSource = terminalBindingSource;
            }
            else
            {
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                listBox5.Visible = false;
                numericUpDown7.Visible = false;
                textBox6.Visible = false;
                textBox7.Visible = false;
                textBox8.Visible = false;
                textBox9.Visible = false;
                button6.Visible = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                terminalTableAdapter.InsertQuery(listBox5.SelectedItem.ToString(), textBox6.Text, textBox7.Text, textBox8.Text, Convert.ToInt32(numericUpDown7.Value), textBox9.Text);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Ошибббочка");
            }
        }
        private void Generate_Train()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string sql = "SELECT EngineId FROM Engine";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    listBox6.Items.Add(reader.GetInt32(0));
                }
                reader.Close();
                sql = "SELECT CarId FROM Carriage";
                command = new SqlCommand(sql, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    listBox7.Items.Add(reader.GetInt32(0));
                }
                connection.Close();
            }
        }
        private void FillDGV(string commandsql)
        {
            while (dataGridView1.Rows.Count != 1)
            {
                dataGridView1.Rows.RemoveAt(0);
            }
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string sql = commandsql;
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();
                int counter = 0;
                while (reader.Read())
                {
                    //dataGridView1.Rows[counter].Cells[0].Value = reader.GetInt32(0).ToString();
                    //dataGridView1.Rows[counter].Cells[1].Value = reader.GetString(1);
                    //dataGridView1.Rows[counter].Cells[2].Value = reader.GetString(2);
                    //dataGridView1.Rows[counter].Cells[3].Value = reader.GetInt32(3).ToString();
                    dataGridView1.Rows.Add();
                    dataGridView1.Height += dataGridView1.RowTemplate.Height;
                   
                }
                reader.Close();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    dataGridView1.Rows[counter].Cells[0].Value = reader.GetInt32(0).ToString();
                    dataGridView1.Rows[counter].Cells[1].Value = reader.GetString(1);
                    dataGridView1.Rows[counter].Cells[2].Value = reader.GetString(2);
                    dataGridView1.Rows[counter].Cells[3].Value = reader.GetInt32(3).ToString();
                    counter++;
                }
                connection.Close();
            }
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                FillEngine("SELECT e.EngineId, e.Type, em.Type, em.Propulsion FROM Engine e, EngineModels em WHERE e.Type=em.Name");
                FillDGV("SELECT c.CarId, cm.Name, cm.Type, cm.NumberOfPlaces FROM Carriage c, CarriageModels cm WHERE c.Type=cm.Name");
                Generate_Train();
                dataGridView2.Visible = true;
                numericUpDown10.Visible = true;
                listBox6.Visible = true;
                listBox7.Visible = true;
                button7.Visible = true;
                button8.Visible = true;
                dataGridView1.Visible = true;
                button9.Visible = true;
                button10.Visible = true;
                checkBox1.Visible = true;
                checkBox2.Visible = true;
                checkBox3.Visible = true;
                checkBox4.Visible = true;
                carriageDataGridView.Visible = false;
            }
            else
            {
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                numericUpDown10.Visible = false;
                checkBox1.Visible = false;
                checkBox2.Visible = false;
                checkBox3.Visible = false;
                listBox6.Visible = false;
                listBox7.Visible = false;
                button7.Visible = false;
                button8.Visible = false;
                dataGridView2.Visible = false;
                dataGridView1.Visible = false;
                button9.Visible = false;
                button10.Visible = false;
                numericUpDown9.Visible = false;
                checkBox4.Visible = false;
                carriageDataGridView.Visible = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                engineTableAdapter.InsertQuery(Convert.ToInt32(numericUpDown4.Value), listBox4.SelectedItem.ToString());
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Ошибббочка");
            }
        }
        private void FilterCarType(string type)
        {

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                comboBox1.Visible = true;
            }
            else
            {
                comboBox1.Visible = false;
                Rows.Clear();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlcommand = "SELECT c.CarId, cm.Name, cm.Type, cm.NumberOfPlaces FROM Carriage c, CarriageModels cm WHERE c.Type=cm.Name";
                if (checkBox1.Checked)
                {
                    sqlcommand += " AND cm.Type IN (N'" + comboBox1.SelectedItem.ToString() + "')";
                }
                if (checkBox2.Checked)
                {
                    sqlcommand += " AND cm.Name IN (N'" + comboBox2.SelectedItem.ToString() + "')";
                }
                if (checkBox3.Checked)
                {
                    string sign = "";
                    if (comboBox3.SelectedItem.ToString() == "Меньше")
                    {
                        sign = "<";
                    }
                    else if (comboBox3.SelectedItem.ToString() == "Меньше или равно")
                    {
                        sign = "<=";
                    }
                    else if (comboBox3.SelectedItem.ToString() == "Равно")
                    {
                        sign = "=";
                    }
                    else if (comboBox3.SelectedItem.ToString() == "Больше или равно")
                    {
                        sign = ">=";
                    }
                    else if (comboBox3.SelectedItem.ToString() == "Больше")
                    {
                        sign = ">";
                    }
                    else
                    {
                        MessageBox.Show("Выберите арифметическую операцию для фильтра!");
                        return;
                    }
                    sqlcommand += " AND cm.NumberOfPlaces" + sign + numericUpDown8.Value.ToString();
                }
                FillDGV(sqlcommand);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Вы ничего не выбрали в фильтрах. Выберите значение для корректного отображения результата", "Ошибочка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Generate_Types_Combobox(ComboBox combobox)
        {

            using (SqlConnection sqlconnection = new SqlConnection(ConnectionString))
            {
                sqlconnection.Open();
                string sql = "SELECT Name FROM CarriageModels";
                SqlCommand command = new SqlCommand(sql, sqlconnection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    combobox.Items.Add(reader.GetString(0));
                }
                sqlconnection.Close();
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                Generate_Types_Combobox(comboBox2);
                comboBox2.Visible = true;
            }
            else
            {
                comboBox2.Visible = false;
                Rows.Clear();
            }
        }
               private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                comboBox3.Visible = true;
                numericUpDown8.Visible = true;
            }
            else
            {
                Rows.Clear();
                comboBox3.Visible = false;
                numericUpDown8.Visible = false;
            }
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FillDGV("SELECT c.CarId, cm.Name, cm.Type, cm.NumberOfPlaces FROM Carriage c, CarriageModels cm WHERE c.Type=cm.Name");
            List<DataGridViewRow> indexes = new List<DataGridViewRow>();
            foreach (DataGridViewRow elem in dataGridView1.Rows)
            {
                if (dataGridView1.Rows.IndexOf(elem) == dataGridView1.Rows.Count - 1)
                {
                    break;
                }
                if (checkBox1.Checked)
                {
                    if (elem.Cells[2].Value.ToString() != comboBox1.SelectedItem.ToString())
                    {
                        continue;
                    }
                }
                if (checkBox2.Checked)
                {
                    if (elem.Cells[1].Value.ToString() != comboBox2.SelectedItem.ToString())
                    {
                        continue;
                    }
                }
                if (checkBox3.Checked)
                {
                    if (comboBox3.SelectedItem.ToString() == "Больше" && numericUpDown8.Value>=Convert.ToDecimal(elem.Cells[3].Value)){
                        continue;
                    }
                    else if (comboBox3.SelectedItem.ToString() == "Больше или равно" && numericUpDown8.Value > Convert.ToDecimal(elem.Cells[3].Value))
                    {
                        continue;
                    }
                    else if (comboBox3.SelectedItem.ToString() == "Равно" && (numericUpDown8.Value > Convert.ToDecimal(elem.Cells[3].Value) || numericUpDown8.Value<Convert.ToDecimal(elem.Cells[3].Value)))
                    {
                        continue;
                    }
                    else if (comboBox3.SelectedItem.ToString() == "Меньше или равно" && numericUpDown8.Value < Convert.ToDecimal(elem.Cells[3].Value))
                    {
                        continue;
                    }
                    else if (comboBox3.SelectedItem.ToString() == "Меньше" && numericUpDown8.Value <= Convert.ToDecimal(elem.Cells[3].Value))
                    {
                        continue;
                    }
                }
                if (checkBox4.Checked)
                {
                    if (elem.Cells[0].Value.ToString() != numericUpDown9.Value.ToString())
                    {
                        continue;
                    }
                }
                indexes.Add(elem);
            }
            dataGridView1.Rows[dataGridView1.Rows.Count - 1].Selected = false;
            try
            {
                Rows.Add(indexes[Current(indexes, CurrentValue)]);
                indexes[Rows.Count-1].Selected = true;
            }
            catch (ArgumentOutOfRangeException exc)
            {
                MessageBox.Show("По введенному вами запросу ничего не найдено!");
            }
        }
        private int Current(List<DataGridViewRow> rows, int curr)
        {
            if (Rows.Count == rows.Count)
            {
                Rows.Clear();
                CurrentValue = 0;
                return CurrentValue;
            }
            return curr++;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                trainTableAdapter.InsertQuery(Convert.ToInt32(numericUpDown10.Value), Convert.ToInt32(listBox6.SelectedItem));
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Ошибббочка");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                int c = 0;
                string type = "";
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string sql = "SELECT COUNT(CarId) FROM Carriage WHERE TrainId=" + numericUpDown10.Value.ToString();
                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        c = reader.GetInt32(0);
                    }
                    reader.Close();
                    sql = "SELECT Type FROM Carriage WHERE CarId=" + listBox7.SelectedItem.ToString();
                    command = new SqlCommand(sql, connection);
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        type = reader.GetString(0);
                    }
                    connection.Close();
                }
                carriageTableAdapter.UpdateQuery(Convert.ToInt32(listBox7.SelectedItem), Convert.ToInt32(numericUpDown10.Value), c + 1, type, Convert.ToInt32(listBox7.SelectedItem));
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Ошибббочка");
            }
        }
    private bool IsSorted(DataGridViewColumn dgv)
    {
        if (Convert.ToInt32(dgv.DataGridView.Rows[0].Cells[dgv.Index].Value)< Convert.ToInt32(dgv.DataGridView.Rows[1].Cells[dgv.Index].Value))
        {
            return true;
        }
        return false;
    }
        private void dataGridView2_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                dataGridView2.Columns[0].SortMode = DataGridViewColumnSortMode.Programmatic;
                if (!IsSorted(dataGridView2.Columns[0]))
                {
                    FillEngine("SELECT e.EngineId, e.Type, em.Type, em.Propulsion FROM Engine e, EngineModels em WHERE e.Type=em.Name ORDER BY e.EngineId");
                }
                else
                {
                    FillEngine("SELECT e.EngineId, e.Type, em.Type, em.Propulsion FROM Engine e, EngineModels em WHERE e.Type=em.Name ORDER BY e.EngineId DESC");
                }
            }
            else if (e.ColumnIndex == 3)
            {
                dataGridView2.Columns[3].SortMode = DataGridViewColumnSortMode.Programmatic;
                if (!IsSorted(dataGridView2.Columns[3]))
                {
                    FillEngine("SELECT e.EngineId, e.Type, em.Type, em.Propulsion FROM Engine e, EngineModels em WHERE e.Type=em.Name ORDER BY em.Propulsion");
                }
                else
                {
                    FillEngine("SELECT e.EngineId, e.Type, em.Type, em.Propulsion FROM Engine e, EngineModels em WHERE e.Type=em.Name ORDER BY em.Propulsion DESC");
                }
            }
        }

        private void Change_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            carriageTableAdapter.Update(railroadDataSet2);
            placeTableAdapter.Update(railroadDataSet2);
            carriageModelsTableAdapter.Update(railroadDataSet2);
            engineTableAdapter.Update(railroadDataSet2);
            engineModelsTableAdapter.Update(railroadDataSet2);
            terminalTableAdapter.Update(railroadDataSet2);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                numericUpDown9.Visible = true;
            }
            else
            {
                Rows.Clear();
                numericUpDown9.Visible = false;
            }
        }

        private void редактированиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var edit = new Edit();
            edit.ShowDialog();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                label25.Visible = true;
                label26.Visible = true;
                label27.Visible = true;
                label28.Visible = true;
                label29.Visible = true;
                label30.Visible = true;
                listBox8.Visible = true;
                listBox9.Visible = true;
                numericUpDown11.Visible = true;
                numericUpDown12.Visible = true;
                numericUpDown13.Visible = true;
                dateTimePicker1.Visible = true;
                button11.Visible = true;
                using (SqlConnection connection=new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string sql = "select TrainId from Train";
                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        listBox8.Items.Add(reader.GetInt32(0).ToString());
                    }
                    reader.Close();
                    sql = "select StationName from Station";
                    command = new SqlCommand(sql, connection);
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        listBox9.Items.Add(reader.GetString(0));
                    }
                }
                    carriageDataGridView.DataSource = trainStationsBindingSource;
            }
            else
            {
                label25.Visible = false;
                label26.Visible = false;
                label27.Visible = false;
                label28.Visible = false;
                label29.Visible = false;
                label30.Visible = false;
                listBox8.Visible = false;
                listBox9.Visible = false;
                numericUpDown11.Visible = false;
                numericUpDown12.Visible = false;
                numericUpDown13.Visible = false;
                dateTimePicker1.Visible = false;
                button11.Visible = false;
            }
        }

        private void редактированиеToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var edit = new Edit();
            edit.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }
    }
}
