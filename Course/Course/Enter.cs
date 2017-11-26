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
    public partial class Enter : Form
    {
        public Enter()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool find = false;
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\GIGABYTE\Desktop\БД_курсовик\Course\Course\LAP.mdf;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string Sql = "SELECT Login, Password FROM LaP";
                SqlCommand command = new SqlCommand(Sql, connection);
                SqlDataReader read = command.ExecuteReader();
                while (read.Read())
                {
                    string login = read.GetString(0);
                    string password = read.GetString(1);
                    if (login==textBox1.Text && password == textBox2.Text)
                    {
                        this.Dispose();
                        var admin = new Admin();
                        admin.ShowDialog();
                        return;
                    }
                }
            }
            MessageBox.Show("Вы ввели неправильный логин или пароль! Повторите попытку");
        }
    }
}
