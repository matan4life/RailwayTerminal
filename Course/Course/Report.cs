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
using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace Course
{
    public partial class Report : Form
    {
        public string tmp = "report.docx";
        public Report()
        {
            InitializeComponent();
        }
        private const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\GIGABYTE\RailwayTerminal\Course\Course\Railroad.mdf;Integrated Security=True";
        //TODO:: создать пустой файл, сохранить его, и путь к нему в переменную sample_doc
        private const string sample_doc = @"C:\Users\Владелец\Desktop\DB\Course\Course\bin\Debug\sample.docx";

        
        private void button1_Click(object sender, EventArgs e)
        {
            string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\GIGABYTE\RailwayTerminal\Course\Course\Railroad.mdf;Integrated Security=True";
            int year = DateTime.Now.Year;
            int quarter = DateTime.Now.Month / 3+1;
            int enginecount = 0, diesel=0, electric=0, cupe=0, plac=0, sv=0, sid=0, inter1=0, inter2=0, inter=0, sov=0, ukr=0, an=0, sov1=0, ukr1=0, an1=0, car=0;
            using (SqlConnection connection=new SqlConnection(connectionstring))
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
                reader.Close();
            }
            var wordApp = new Word.Application();
            wordApp.Visible = false;
            var wordDocument = wordApp.Documents.Open(@"D:\report1.docx");
            ReplaceWordStuff("{quarter}", quarter.ToString(), wordDocument);
            ReplaceWordStuff("{year}", year.ToString(), wordDocument);
            ReplaceWordStuff("{countengines}", enginecount.ToString(), wordDocument);
            ReplaceWordStuff("{countdieselengine}", diesel.ToString(), wordDocument);
            ReplaceWordStuff("{percentdieselengine}", (diesel * 100 / enginecount).ToString(), wordDocument);
            ReplaceWordStuff("{countelectricengine}", electric.ToString(), wordDocument);
            ReplaceWordStuff("{percentelectricengine}", (electric * 100 / enginecount).ToString(), wordDocument);
            ReplaceWordStuff("{countintercity}", inter.ToString(), wordDocument);
            ReplaceWordStuff("{percentintercity}", (inter * 100 / enginecount).ToString(), wordDocument);
            ReplaceWordStuff("{sovietnumber}", (enginecount - ukr - an).ToString(), wordDocument);
            ReplaceWordStuff("{sovietpercent}", ((enginecount - ukr - an) * 100 / enginecount).ToString(), wordDocument);
            ReplaceWordStuff("{ukrainenumber}", ukr.ToString(), wordDocument);
            ReplaceWordStuff("{ukrainepercent}", (ukr * 100 / enginecount).ToString(), wordDocument);
            ReplaceWordStuff("{anothernumber}", an.ToString(), wordDocument);
            ReplaceWordStuff("{anotherpercent}", (an * 100 / enginecount).ToString(), wordDocument);
            ReplaceWordStuff("{countcar}", car.ToString(), wordDocument);
            ReplaceWordStuff("{countcupe}", cupe.ToString(), wordDocument);
            ReplaceWordStuff("{percentcupe}", (cupe * 100 / car).ToString(), wordDocument);
            ReplaceWordStuff("{countplac}", plac.ToString(), wordDocument);
            ReplaceWordStuff("{percentplac}", (plac * 100 / car).ToString(), wordDocument);
            ReplaceWordStuff("{countsv}", sv.ToString(), wordDocument);
            ReplaceWordStuff("{percentsv}", (sv * 100 / car).ToString(), wordDocument);
            ReplaceWordStuff("{count2}", sid.ToString(), wordDocument);
            ReplaceWordStuff("{percent2}", (sid * 100 / car).ToString(), wordDocument);
            ReplaceWordStuff("{countintercity1}", inter1.ToString(), wordDocument);
            ReplaceWordStuff("{countintercity2}", inter2.ToString(), wordDocument);
            ReplaceWordStuff("{percentintercity1}", (inter1 * 100 / car).ToString(), wordDocument);
            ReplaceWordStuff("{percentintercity2}", (inter2 * 100 / car).ToString(), wordDocument);
            ReplaceWordStuff("{sovietnumber1}", sov1.ToString(), wordDocument);
            ReplaceWordStuff("{sovietpercent1}", (sov1 * 100 / car).ToString(), wordDocument);
            ukr1 = car - sov1 - an1;
            ReplaceWordStuff("{ukrainenumber1}", ukr1.ToString(), wordDocument);
            ReplaceWordStuff("{ukrainepercent1}", (ukr1 * 100 / car).ToString(), wordDocument);
            ReplaceWordStuff("{anothernumber1}", an1.ToString(), wordDocument);
            ReplaceWordStuff("{anotherpercent1}", (an1 * 100 / car).ToString(), wordDocument);
            wordApp.Visible = true;
            wordDocument.SaveAs2("result.docx");
        }
        private void ReplaceWordStuff(string stub, string text, Word.Document wordDocument)
        {
            var range = wordDocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stub, ReplaceWith: text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] replace = { "{total}", "{tc}", "{tp}", "{inter}", "{ic}", "{ip}", "{rapid}", "{rc}", "{rp}", "{other}", "{oc}", "{op}" };
            string[] replacement = { "Всего поездов", "0", "100%", "Поездов Интерсити", "0", "0", "Скорых поездов", "0", "0", "Обычных поездов", "0", "0" };
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string sql = "select count(TrainId) from train";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    replacement[1] = reader.GetInt32(0).ToString();
                }
                reader.Close();
                sql = "select count(trainid) from train where engineid in(select engineid from engine where type in (select name from enginemodels where type in(" + "N'Интерсити'" + ")))";
                command = new SqlCommand(sql, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    replacement[4] = reader.GetInt32(0).ToString();
                    replacement[5] = (reader.GetInt32(0) * 100 / Convert.ToInt32(replacement[1])).ToString();
                }
                reader.Close();
                sql = "select count(trainid) from train where trainid in(" +
                    "select trainid from trainstations group by trainid having count(stationid)<6" +
                    ") and engineid not in (" +
                    "select engineid from engine where type in(" +
                    "select name from enginemodels where type in (N'Интерсити')" +
                    ")" +
                    ")";
                command = new SqlCommand(sql, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    replacement[7] = reader.GetInt32(0).ToString();
                    replacement[8] = (reader.GetInt32(0) * 100 / Convert.ToInt32(replacement[1])).ToString();
                }
                reader.Close();
                sql = "select count(trainid) from train where trainid in(" +
                    "select trainid from trainstations group by trainid having count(stationid)>=6" +
                    ")";
                command = new SqlCommand(sql, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    replacement[10] = reader.GetInt32(0).ToString();
                    replacement[11] = (reader.GetInt32(0) * 100 / Convert.ToInt32(replacement[1])).ToString();
                }
            }
            ReplaceTextInExcelFile(@"D:\report.xlsx", replace, replacement);
        }
        public static void ReplaceTextInExcelFile(string filename, string[] replace, string[] replacement)
        {
            object m = Type.Missing;

            // open excel.
            Excel.Application app=new Excel.Application();

            // open the workbook. 
            Excel.Workbook wb = app.Workbooks.Open(
                filename,
                m, false, m, m, m, m, m, m, m, m, m, m, m, m);

            // get the active worksheet. (Replace this if you need to.) 
            Excel.Worksheet ws = (Excel.Worksheet)wb.ActiveSheet;

            // get the used range. 
            Excel.Range r = (Excel.Range)ws.UsedRange;

            // call the replace method to replace instances. 
            for (int i = 0; i < replace.Length; i++)
            {
                bool success = (bool)r.Replace(
                    replace[i],
                    replacement[i],
                    Excel.XlLookAt.xlWhole,
                    Excel.XlSearchOrder.xlByRows,
                    true, m, m, m);
            }

            // save and close. 
            wb.SaveAs("result.xlsx");
            app.Quit();
            app = null;
        }
    }
}
