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

namespace Course
{
    public partial class Report : Form
    {
        public string tmp = "report.docx";
        public Report()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Владелец\Desktop\RailwayTerminal-temp-1.2\Course\Course\Railroad.mdf;Integrated Security=True";
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
            string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Владелец\Desktop\RailwayTerminal-temp-1.2\Course\Course\Railroad.mdf;Integrated Security=True";
            int year = DateTime.Now.Year;
            int quarter = DateTime.Now.Month / 3 + 1;
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
                reader.Close();
                string[] replace = { "{q}", "{y}", "{all}", "{allc}", "{dc}", "{dp}", "{cc}", "{cp}", "{sidc}", "{sidp}", "{ec}", "{ep}", "{pc}", "{pp}", "{ic1}", "{ip1}", "{ic}", "{ip}", "{svc}", "{svp}", "{ic2}", "{ip2}", "{sc}", "{sp}", "{sc1}", "{sp1}", "{uc}", "{up}", "{uc1}", "{up1}", "{ac}", "{ap}", "{ac1}", "{ap1}" };
                string[] replacement = { quarter.ToString()+" квартал", year.ToString()+" года", enginecount.ToString(), car.ToString(), diesel.ToString(), (diesel*100/enginecount).ToString()+"%", cupe.ToString(), (cupe*100/car).ToString()+"%", sid.ToString(), (sid*100/car).ToString()+"%", electric.ToString(), (electric*100/enginecount).ToString()+"%", plac.ToString(), (plac*100/car).ToString()+"%", inter1.ToString(), (inter1*100/car).ToString()+"%", inter.ToString(), (inter*100/enginecount).ToString()+"%", sv.ToString(), (sv*100/car).ToString()+"%", inter2.ToString(), (inter2*100/car).ToString()+"%", sov.ToString(), (sov*100/enginecount).ToString()+"%", sov1.ToString(), (sov1*100/car).ToString()+"%", ukr.ToString(), (ukr*100/enginecount).ToString()+"%", ukr1.ToString(), (ukr1*100/car).ToString()+"%", an.ToString(), (an*100/enginecount).ToString()+"%", an1.ToString(), (an1*100/car).ToString()+"%"};
                ReplaceTextInExcelFile(@"D:\report.xlsx", replace, replacement);
            }
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
