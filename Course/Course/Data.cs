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
using System.Windows.Forms.DataVisualization.Charting;

namespace Course
{
    public partial class Data : Form
    {
        public Data()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Data_Load(object sender, EventArgs e)
        {
            string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Владелец\Desktop\DB\Course\Course\Railroad.mdf;Integrated Security=True";
            int enginecount = 0, diesel = 0, electric = 0, cupe = 0, plac = 0, sv = 0, sid = 0, inter1 = 0, inter2 = 0, inter = 0, sov = 0, ukr = 0, an = 0, sov1 = 0, ukr1 = 0, an1 = 0, car = 0;
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                string sql = "SELECT COUNT(EngineId) FROM Engine";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    enginecount = reader.GetInt32(0);
                }
                reader.Close();
                sql = "SELECT COUNT(EngineId) FROM Engine, EngineModels WHERE Engine.Type=EngineModels.Name AND EngineModels.Type IN (N'Тепловоз')";
                command = new SqlCommand(sql, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    diesel = reader.GetInt32(0);
                }
                reader.Close();
                sql = "SELECT COUNT(EngineId) FROM Engine, EngineModels WHERE Engine.Type=EngineModels.Name AND EngineModels.Type IN (N'Электровоз')";
                command = new SqlCommand(sql, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    electric = reader.GetInt32(0);
                }
                reader.Close();
                sql = "SELECT COUNT(EngineId) FROM Engine, EngineModels WHERE Engine.Type=EngineModels.Name AND EngineModels.Type IN (N'Интерсити')";
                command = new SqlCommand(sql, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    inter = reader.GetInt32(0);
                }
                reader.Close();
                sql = "SELECT COUNT(EngineId) FROM Engine WHERE Type IN ('EJ 675', 'HRCS2', N'ЧС4', N'ЧС4Т', N'ЧС8')";
                command = new SqlCommand(sql, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    an = reader.GetInt32(0);
                }
                reader.Close();
                sql = "SELECT COUNT(EngineId) FROM Engine WHERE Type IN (N'ДС3', N'ЭКр1')";
                command = new SqlCommand(sql, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ukr = reader.GetInt32(0);
                }
                reader.Close();
                sov = enginecount - an - ukr;
                sql = "SELECT COUNT(CarId) FROM Carriage";
                command = new SqlCommand(sql, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    car = reader.GetInt32(0);
                }
                reader.Close();
                sql = "SELECT COUNT(CarId) FROM Carriage, CarriageModels WHERE Carriage.Type=CarriageModels.Name AND CarriageModels.Type IN (N'Купейный')";
                command = new SqlCommand(sql, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cupe = reader.GetInt32(0);
                }
                reader.Close();
                sql = "SELECT COUNT(CarId) FROM Carriage, CarriageModels WHERE Carriage.Type=CarriageModels.Name AND CarriageModels.Type IN (N'Плацкартный')";
                command = new SqlCommand(sql, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    plac = reader.GetInt32(0);
                }
                reader.Close();
                sql = "SELECT COUNT(CarId) FROM Carriage, CarriageModels WHERE Carriage.Type=CarriageModels.Name AND CarriageModels.Type IN (N'СВ')";
                command = new SqlCommand(sql, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    sv = reader.GetInt32(0);
                }
                reader.Close();
                sql = "SELECT COUNT(CarId) FROM Carriage, CarriageModels WHERE Carriage.Type=CarriageModels.Name AND CarriageModels.Type IN (N'Сидячий 2 класса')";
                command = new SqlCommand(sql, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    sid = reader.GetInt32(0);
                }
                reader.Close();
                sql = "SELECT COUNT(CarId) FROM Carriage, CarriageModels WHERE Carriage.Type=CarriageModels.Name AND CarriageModels.Type IN (N'Интерсити 1 класса')";
                command = new SqlCommand(sql, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    inter1 = reader.GetInt32(0);
                }
                reader.Close();
                sql = "SELECT COUNT(CarId) FROM Carriage, CarriageModels WHERE Carriage.Type=CarriageModels.Name AND CarriageModels.Type IN (N'Интерсити 2 класса')";
                command = new SqlCommand(sql, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    inter2 = reader.GetInt32(0);
                }
                reader.Close();
                sql = "SELECT COUNT(CarId) FROM Carriage WHERE Type IN (N'47-К', N'47-К2', 'EJ-675-1', 'EJ-675-2', 'HRCS2-1', 'HRCS2-2')";
                command = new SqlCommand(sql, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    an1 = reader.GetInt32(0);
                }
                reader.Close();
                sql = "SELECT COUNT(CarId) FROM Carriage WHERE Type IN ('61-4174', '61-4186', '61-4194')";
                command = new SqlCommand(sql, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    sov1 = reader.GetInt32(0);
                }
                ukr1 = car - sov1 - an1;
                reader.Close();
                connection.Close();
            }
            for (int i=0; i<6; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Height += dataGridView1.RowTemplate.Height;
            }
            for (int i=0; i<9; i++)
            {
                dataGridView2.Rows.Add();
                dataGridView2.Height += dataGridView2.RowTemplate.Height;
            }
            dataGridView1.Rows[0].Cells[0].Value = "Всего";
            dataGridView1.Rows[1].Cells[0].Value = "Тепловозов";
            dataGridView1.Rows[2].Cells[0].Value = "Электровозов";
            dataGridView1.Rows[3].Cells[0].Value = "Интерсити";
            dataGridView1.Rows[4].Cells[0].Value = "Произведено в СССР";
            dataGridView1.Rows[5].Cells[0].Value = "Произведено в Украине";
            dataGridView1.Rows[6].Cells[0].Value = "Произведено за рубежом";
            dataGridView1.Rows[0].Cells[1].Value = enginecount;
            dataGridView1.Rows[1].Cells[1].Value = diesel;
            dataGridView1.Rows[2].Cells[1].Value = electric;
            dataGridView1.Rows[3].Cells[1].Value = inter;
            dataGridView1.Rows[4].Cells[1].Value = sov;
            dataGridView1.Rows[5].Cells[1].Value = ukr;
            dataGridView1.Rows[6].Cells[1].Value = an;
            dataGridView1.Rows[0].Cells[2].Value = "100%";
            dataGridView1.Rows[1].Cells[2].Value = (diesel*100/enginecount)+"%";
            dataGridView1.Rows[2].Cells[2].Value = (electric*100/enginecount)+"%";
            dataGridView1.Rows[3].Cells[2].Value = (inter*100/enginecount)+"%";
            dataGridView1.Rows[4].Cells[2].Value = (sov*100/enginecount)+"%";
            dataGridView1.Rows[5].Cells[2].Value = (ukr*100/enginecount)+"%";
            dataGridView1.Rows[6].Cells[2].Value = (an*100/enginecount)+"%";
            dataGridView2.Rows[0].Cells[0].Value = "Всего";
            dataGridView2.Rows[1].Cells[0].Value = "Купейных";
            dataGridView2.Rows[2].Cells[0].Value = "Плацкартных";
            dataGridView2.Rows[3].Cells[0].Value = "СВ";
            dataGridView2.Rows[4].Cells[0].Value = "Сидячих 2 класса";
            dataGridView2.Rows[5].Cells[0].Value = "Интерсити 1 класса";
            dataGridView2.Rows[6].Cells[0].Value = "Интерсити 2 класса";
            dataGridView2.Rows[7].Cells[0].Value = "Произведено в СССР";
            dataGridView2.Rows[8].Cells[0].Value = "Произведено в Украине";
            dataGridView2.Rows[9].Cells[0].Value = "Произведено за рубежом";
            dataGridView2.Rows[0].Cells[1].Value = car;
            dataGridView2.Rows[1].Cells[1].Value = cupe;
            dataGridView2.Rows[2].Cells[1].Value = plac;
            dataGridView2.Rows[3].Cells[1].Value = sv;
            dataGridView2.Rows[4].Cells[1].Value = sid;
            dataGridView2.Rows[5].Cells[1].Value = inter1;
            dataGridView2.Rows[6].Cells[1].Value = inter2;
            dataGridView2.Rows[7].Cells[1].Value = sov1;
            dataGridView2.Rows[8].Cells[1].Value = ukr1;
            dataGridView2.Rows[9].Cells[1].Value = an1;
            dataGridView2.Rows[0].Cells[2].Value = "100%";
            dataGridView2.Rows[1].Cells[2].Value = (cupe * 100 / car) + "%";
            dataGridView2.Rows[2].Cells[2].Value = (plac * 100 / car) + "%";
            dataGridView2.Rows[3].Cells[2].Value = (sv * 100 / car) + "%";
            dataGridView2.Rows[4].Cells[2].Value = (sid * 100 / car) + "%";
            dataGridView2.Rows[5].Cells[2].Value = (inter1 * 100 / car) + "%";
            dataGridView2.Rows[6].Cells[2].Value = (inter2 * 100 / car) + "%";
            dataGridView2.Rows[7].Cells[2].Value = (sov1 * 100 / car) + "%";
            dataGridView2.Rows[8].Cells[2].Value = (ukr1 * 100 / car) + "%";
            dataGridView2.Rows[9].Cells[2].Value = (an1 * 100 / car) + "%";
            chart1.Series.Clear();
            chart1.BackColor = Color.Gray;
            chart1.BackSecondaryColor = Color.WhiteSmoke;
            chart1.BackGradientStyle = GradientStyle.DiagonalRight;

            chart1.BorderlineDashStyle = ChartDashStyle.Solid;
            chart1.BorderlineColor = Color.Gray;
            chart1.BorderSkin.SkinStyle = BorderSkinStyle.Emboss;

            // Форматировать область диаграммы
            chart1.ChartAreas[0].BackColor = Color.Wheat;
            chart1.Titles.Add("Типы");
            chart1.Titles[0].Font = new Font("Utopia", 16);

            chart1.Series.Add(new Series("ColumnSeries")
            {
                ChartType = SeriesChartType.Pie
            });
            int[] yValues = { diesel, electric, inter };
            string[] xValues = { "Тепловозы", "Электровозы", "Интерсити" };
            chart1.Series["ColumnSeries"].Points.DataBindXY(xValues, yValues);
            for (int i=0; i<xValues.Length; i++)
            {
                chart1.Series["ColumnSeries"].Points[i].AxisLabel = "";
                chart1.Series[0].Points[i].LegendText = xValues[i];
            }
            chart1.ChartAreas[0].Area3DStyle.Enable3D = true;

            chart2.Series.Clear();
            chart2.BackColor = Color.Gray;
            chart2.BackSecondaryColor = Color.WhiteSmoke;
            chart2.BackGradientStyle = GradientStyle.DiagonalRight;

            chart2.BorderlineDashStyle = ChartDashStyle.Solid;
            chart2.BorderlineColor = Color.Gray;
            chart2.BorderSkin.SkinStyle = BorderSkinStyle.Emboss;

            // Форматировать область диаграммы
            chart2.ChartAreas[0].BackColor = Color.Wheat;
            chart2.Titles.Add("Страны-производители");
            chart2.Titles[0].Font = new Font("Utopia", 16);

            chart2.Series.Add(new Series("ColumnSeries"));
            chart2.Series[0].ChartType = SeriesChartType.Pie;
            int[] yValues1 = { sov, ukr, an };
            string[] xValues1 = { "СССР", "Украина", "Прочие" };
            chart2.Series["ColumnSeries"].Points.DataBindXY(xValues1, yValues1);
            for (int i = 0; i < xValues1.Length; i++)
            {
                chart2.Series["ColumnSeries"].Points[i].AxisLabel = "";
                chart2.Series[0].Points[i].LegendText = xValues1[i];
            }
            chart2.ChartAreas[0].Area3DStyle.Enable3D = true;
            chart3.Series.Clear();
            chart3.BackColor = Color.Gray;
            chart3.BackSecondaryColor = Color.WhiteSmoke;
            chart3.BackGradientStyle = GradientStyle.DiagonalRight;

            chart3.BorderlineDashStyle = ChartDashStyle.Solid;
            chart3.BorderlineColor = Color.Gray;
            chart3.BorderSkin.SkinStyle = BorderSkinStyle.Emboss;

            // Форматировать область диаграммы
            chart3.ChartAreas[0].BackColor = Color.Wheat;
            chart3.Titles.Add("Типы");
            chart3.Titles[0].Font = new Font("Utopia", 16);

            chart3.Series.Add(new Series("ColumnSeries"));
            chart3.Series[0].ChartType = SeriesChartType.Pie;
            int[] yValues2 = { cupe, plac, sv, sid, inter1, inter2 };
            string[] xValues2 = {"Купе", "Плацкарт", "СВ", "Сидячий 2 класса", "Интерсити 1 класса", "Интерсити 2 класса"};
            chart3.Series["ColumnSeries"].Points.DataBindXY(xValues2, yValues2);
            for (int i = 0; i < xValues2.Length; i++)
            {
                chart3.Series["ColumnSeries"].Points[i].AxisLabel = "";
                chart3.Series[0].Points[i].LegendText = xValues2[i];
            }
            chart3.ChartAreas[0].Area3DStyle.Enable3D = true;
            chart4.Series.Clear();
            chart4.BackColor = Color.Gray;
            chart4.BackSecondaryColor = Color.WhiteSmoke;
            chart4.BackGradientStyle = GradientStyle.DiagonalRight;

            chart4.BorderlineDashStyle = ChartDashStyle.Solid;
            chart4.BorderlineColor = Color.Gray;
            chart4.BorderSkin.SkinStyle = BorderSkinStyle.Emboss;

            // Форматировать область диаграммы
            chart4.ChartAreas[0].BackColor = Color.Wheat;
            chart4.Titles.Add("Страны-производители");
            chart4.Titles[0].Font = new Font("Utopia", 16);

            chart4.Series.Add(new Series("ColumnSeries"));
            chart4.Series[0].ChartType = SeriesChartType.Pie;
            int[] yValues3 = { sov1, ukr1, an1 };
            chart4.Series["ColumnSeries"].Points.DataBindXY(xValues1, yValues3);
            for (int i = 0; i < xValues1.Length; i++)
            {
                chart4.Series["ColumnSeries"].Points[i].AxisLabel = "";
                chart4.Series[0].Points[i].LegendText = xValues1[i];
            }
            chart4.ChartAreas[0].Area3DStyle.Enable3D = true;
        }
    }
}
