using System;
using System.Collections.Generic;
using System.IO;
using static VCF.Core;
using System.Text;
using System.Data;
using System.Linq;
using OfficeOpenXml;

namespace VCF
{
    public  class Service
    {

        public  bool ConvertvCardFileToExcelFile(string sourcePath, string outputPath)
        {
            try
            {
                var cards = GetVCFs(File.ReadAllLines(sourcePath).ToList());
                CreateExcelFile(outputPath, cards);
                return true;
            }
            catch (Exception aa)
            {
                throw aa;
            }

        }

        public  bool ConvertExcelFileTovCardFile(string sourcePath, string outputPath)
        {
            try
            {
                var cards = GetVCFs(GetDataTableFromExcel(sourcePath));
                CreateVcfFile(outputPath, cards);
                return true;
            }
            catch (Exception aa)
            {
                throw aa;
            }
        }


        private void CreateExcelFile(string outputPath, List<vCard> list)
        {
            using (var excelPackage = new ExcelPackage(new FileInfo(outputPath)))
            {
                //Get the Worksheet created in the previous codesample. 
                var ws = excelPackage.Workbook.Worksheets.Add("VCF");

                ws.Cells[1, 1].Value = "İsim Ön Eki";
                ws.Cells[1, 2].Value = "İlk İsim";
                ws.Cells[1, 3].Value = "Orta İsim";
                ws.Cells[1, 4].Value = "Soyisim";
                ws.Cells[1, 5].Value = "Telefon Numarası";
                ws.Cells[1, 6].Value = "Telefon Numarası Cep";
                ws.Cells[1, 7].Value = "Telefon Numarası İş";
                ws.Cells[1, 8].Value = "Ünvan";
                ws.Cells[1, 9].Value = "Firma";
                ws.Cells[1, 10].Value = "Adres";
                ws.Cells[1, 11].Value = "İnternet Sitesi";
                ws.Cells[1, 12].Value = "e Mail Adresi";
                ws.Cells[1, 13].Value = "Not 1";
                ws.Cells[1, 14].Value = "e Mail Adresi Kişisel";
                ws.Cells[1, 15].Value = "e Mail Adresi İş";
                ws.Cells[1, 16].Value = "Telefon Numarası Ev";
                ws.Cells[1, 17].Value = "Telefon Numarası Pref";
                ws.Cells[1, 18].Value = "Telefon Numarası Sesli Mesaj";
                ws.Cells[1, 19].Value = "İsim Son Eki";
                ws.Cells[1, 20].Value = "Adres Ev";
                ws.Cells[1, 21].Value = "Adres İş";
                ws.Cells[1, 22].Value = "Not 2";
                ws.Cells[1, 23].Value = "Not 3";
                ws.Cells[1, 24].Value = "Diğer 1";
                ws.Cells[1, 25].Value = "Diğer 2";
                ws.Cells[1, 26].Value = "Diğer 3";
                ws.Cells[1, 27].Value = "Diğer 4";
                ws.Cells[1, 28].Value = "Diğer 5";
                ws.Cells[1, 29].Value = "Diğer 6";
                ws.Cells[1, 30].Value = "Diğer 7";
                ws.Cells[1, 31].Value = "Diğer 8";
                ws.Cells[1, 32].Value = "Diğer 9";
                for (int i = 2; i <= list.Count; i++)
                {
                    var item = list[i - 2];
                    ws.Cells[i, 1].Value = item.Prefix;
                    ws.Cells[i, 2].Value = item.FirstName;
                    ws.Cells[i, 3].Value = item.MiddleName;
                    ws.Cells[i, 4].Value = item.LastName;
                    ws.Cells[i, 5].Value = item.TEL;
                    ws.Cells[i, 6].Value = item.TELCELL;
                    ws.Cells[i, 7].Value = item.TELWORK;
                    ws.Cells[i, 8].Value = item.TITLE;
                    ws.Cells[i, 9].Value = item.ORG;
                    ws.Cells[i, 10].Value = item.ADR;
                    ws.Cells[i, 11].Value = item.URL;
                    ws.Cells[i, 12].Value = item.EMAIL;
                    ws.Cells[i, 13].Value = item.NOTE1;
                    ws.Cells[i, 14].Value = item.EMAILHOME;
                    ws.Cells[i, 15].Value = item.EMAILWORK;
                    ws.Cells[i, 16].Value = item.TELHOME;
                    ws.Cells[i, 17].Value = item.TELPREF;
                    ws.Cells[i, 18].Value = item.TELVOICE;
                    ws.Cells[i, 19].Value = item.Suffix;
                    ws.Cells[i, 20].Value = item.ADRHOME;
                    ws.Cells[i, 21].Value = item.ADRWORK;
                    ws.Cells[i, 22].Value = item.NOTE2;
                    ws.Cells[i, 23].Value = item.NOTE3;
                    ws.Cells[i, 24].Value = item.OTHER1;
                    ws.Cells[i, 25].Value = item.OTHER2;
                    ws.Cells[i, 26].Value = item.OTHER3;
                    ws.Cells[i, 27].Value = item.OTHER4;
                    ws.Cells[i, 28].Value = item.OTHER5;
                    ws.Cells[i, 29].Value = item.OTHER6;
                    ws.Cells[i, 30].Value = item.OTHER7;
                    ws.Cells[i, 31].Value = item.OTHER8;
                    ws.Cells[i, 32].Value = item.OTHER9;
                }
                excelPackage.Save();
            }
        }
                
        private void CreateVcfFile(string outputPath, List<vCard> list)
        {

            StringBuilder sb = new StringBuilder();
            foreach (var card in list)
            {
                sb.AppendLine(card.ToString());
            }
            //File.WriteAllLines(outputPath,sb.ToString().Split(new string[] { Environment.NewLine },StringSplitOptions.RemoveEmptyEntries));
            File.WriteAllText(outputPath, sb.ToString());
        }

        private List<vCard> GetVCFs(List<string> AllLines)
        {

            List<vCard> cards = new List<vCard>();
            try
            {
                int startCard = -1;
                int endCard = -1;
                for (int i = 0; i < AllLines.Count; i++)
                {
                    if (endCard != -1)
                    {
                        var tmp = new List<string>();
                        for (int x = startCard; x <= endCard; x++)
                        {
                            tmp.Add(AllLines[x]);
                        }
                        var card = new vCard(tmp);
                        cards.Add(card);
                        startCard = endCard = -1;
                    }
                    if (AllLines[i] == "BEGIN:VCARD")
                    {
                        startCard = i;
                    }
                    if (AllLines[i] == "END:VCARD")
                    {
                        endCard = i;
                    }

                }
                //cards = cards.OrderByDescending(x => x.FirstName).ToList();
                return cards;
            }
            catch (Exception aa)
            {
                Console.WriteLine(aa.Message);
                return null;
            }
        }


        private List<vCard> GetVCFs(DataTable AllLines)
        {
            List<vCard> cards = new List<vCard>();
            try
            {
                for (int i = 0; i < AllLines.Rows.Count; i++)
                {
                    var row = AllLines.Rows[i];
                    vCard card = new vCard();
                    card.Prefix = row[0].ToString();
                    card.FirstName = row[1].ToString();
                    card.MiddleName = row[2].ToString();
                    card.LastName = row[3].ToString();
                    card.TEL = row[4].ToString();
                    card.TELCELL = row[5].ToString();
                    card.TELWORK = row[6].ToString();
                    card.TITLE = row[7].ToString();
                    card.ORG = row[8].ToString();
                    card.ADR = row[9].ToString();
                    card.URL = row[10].ToString();
                    card.EMAIL = row[11].ToString();
                    card.NOTE1 = row[12].ToString();
                    card.EMAILHOME = row[13].ToString();
                    card.EMAILWORK = row[14].ToString();
                    card.TELHOME = row[15].ToString();
                    card.TELPREF = row[16].ToString();
                    card.TELVOICE = row[17].ToString();
                    card.Suffix = row[18].ToString();
                    card.ADRHOME = row[19].ToString();
                    card.ADRWORK = row[20].ToString();
                    card.NOTE2 = row[21].ToString();
                    card.NOTE3 = row[22].ToString();
                    card.OTHER1 = row[23].ToString();
                    card.OTHER2 = row[24].ToString();
                    card.OTHER3 = row[25].ToString();
                    card.OTHER4 = row[26].ToString();
                    card.OTHER5 = row[27].ToString();
                    card.OTHER6 = row[28].ToString();
                    card.OTHER7 = row[29].ToString();
                    card.OTHER8 = row[30].ToString();
                    card.OTHER9 = row[31].ToString();
                    cards.Add(card);
                }
                return cards;
            }
            catch (Exception aa)
            {
                Console.WriteLine(aa.Message);
                return null;
            }
        }

        private DataTable GetDataTableFromExcel(string path, bool hasHeader = true)
        {
            using (var pck = new OfficeOpenXml.ExcelPackage())
            {
                using (var stream = File.OpenRead(path))
                {
                    pck.Load(stream);
                }
                var ws = pck.Workbook.Worksheets.First();
                DataTable tbl = new DataTable();
                foreach (var firstRowCell in ws.Cells[1, 1, 1, ws.Dimension.End.Column])
                {
                    tbl.Columns.Add(hasHeader ? firstRowCell.RichText.Text : string.Format("Column {0}", firstRowCell.Start.Column));
                }
                var startRow = hasHeader ? 2 : 1;
                for (int rowNum = startRow; rowNum <= ws.Dimension.End.Row; rowNum++)
                {
                    var wsRow = ws.Cells[rowNum, 1, rowNum, ws.Dimension.End.Column];
                    DataRow row = tbl.Rows.Add();
                    foreach (var cell in wsRow)
                    {
                        row[cell.Start.Column - 1] = cell.RichText.Text;
                    }
                }
                return tbl;
            }
        }
    }
}
