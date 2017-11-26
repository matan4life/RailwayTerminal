using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

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
            var wordApp = new Word.Application();
            wordApp.Visible = false;
            var wordDocument = wordApp.Documents.Open(tmp);
            ReplaceWordStuff("{date}", "4", wordDocument);
            ReplaceWordStuff("{year}", "2017", wordDocument);
            ReplaceWordStuff("{month1}", "октябрь", wordDocument);
            ReplaceWordStuff("{month2}", "ноябрь", wordDocument);
            ReplaceWordStuff("{month3}", "декабрь", wordDocument);
            ReplaceWordStuff("{number1}", "1000", wordDocument);
            ReplaceWordStuff("{number2}", "2000", wordDocument);
            ReplaceWordStuff("{number3}", "3000", wordDocument);
            ReplaceWordStuff("{totalnumber}", "6000", wordDocument);
            wordDocument.SaveAs("result.docx");
            wordApp.Visible = true;
        }
        private void ReplaceWordStuff(string stub, string text, Word.Document wordDocument)
        {
            var range = wordDocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stub, ReplaceWith: text);
        }

    }
}
