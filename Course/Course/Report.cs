using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Text.RegularExpressions;

namespace Course
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tmp = "report.docx";
            SearchAndReplace(tmp);
        }
        public static void SearchAndReplace(string document)
        {
            string tmp = "report.docx";
            string docText = null;
            Regex regexText = new Regex("");
            using (WordprocessingDocument wordDoc = WordprocessingDocument.Open(document, true))
            {
                using (StreamReader sr = new StreamReader(wordDoc.MainDocumentPart.GetStream()))
                {
                    docText = sr.ReadToEnd();
                }

                regexText = new Regex("{month1}");
                docText = regexText.Replace(docText, "октябрь");
                regexText = new Regex("{number1}");
                docText = regexText.Replace(docText, "1000");
                regexText = new Regex("{month2}");
                docText = regexText.Replace(docText, "ноябрь");
                regexText = new Regex("{month3}");
                docText = regexText.Replace(docText, "декабрь");
                regexText = new Regex("{number2}");
                docText = regexText.Replace(docText, "2000");
                regexText = new Regex("{year}");
                docText = regexText.Replace(docText, "2017");
                regexText = new Regex("{number3}");
                docText = regexText.Replace(docText, "3000");
                regexText = new Regex("{total}");
                docText = regexText.Replace(docText, "6000");
                regexText = new Regex("{quarter}");
                docText = regexText.Replace(docText, "4");
            }
            if (File.Exists("result.docx"))
            {
                File.Delete("result.docx");
            }
            File.Copy(tmp, "result.docx");
            using (WordprocessingDocument wordDoc= WordprocessingDocument.Open("result.docx", true))
            { 
                using (StreamWriter sw = new StreamWriter(wordDoc.MainDocumentPart.GetStream(FileMode.Create)))
                {
                    sw.Write(docText);
                }
            }
        }
    }
}
