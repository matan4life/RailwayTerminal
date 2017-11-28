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
        public string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Владелец\Desktop\RailwayTerminal-temp-1.2\Course\Course\Railroad.mdf;Integrated Security=True";
        public Edit()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                listBox1.Visible = true;
                textBox4.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                numericUpDown1.Visible = true;
                button1.Visible = true;
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string sql = "SELECT StationName FROM Station";
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
                listBox1.Visible = false;
                textBox4.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                numericUpDown1.Visible = false;
                button1.Visible = false;
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
    }
}
