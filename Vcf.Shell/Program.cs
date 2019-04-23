using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using Vcf.Core;

namespace Vcf.Shell
{
    public class Program
    {
        static void Main(string[] args)
        {
            var path = @"D:\contacts00003.vcf";
            var cards = LoadVcf(File.ReadAllLines(path).ToList());
            CreateExcel("D:\\test.xls",cards);
        }

        static void CreateExcel(string outputPath, List<VCF> list)
        {
            using (var p = new ExcelPackage(new FileInfo(outputPath)))
            {
                ////Get the Worksheet created in the previous codesample. 
                //var ws = p.Workbook.Worksheets["MySheet"];
                //var a = list.ToArray();
                //ws.Cells.LoadFromArrays(a);

                //int i = 1;
                ////Başlıklar
                //foreach (PropertyInfo pi in typeof(VCF).GetProperties())
                //{
                //    ws.Cells[1, i].Value = pi.Name;
                //    i++;
                //}
                //i = 2;
                //foreach (var item in list)
                //{
                //    ws.Cells[i, 1].Value = item.Prefix;
                //    ws.Cells[i, 2].Value = item.FirstName;
                //    ws.Cells[i, 3].Value = item.MiddleName;
                //    ws.Cells[i, 4].Value = item.LastName;
                //    ws.Cells[i, 5].Value = item.Suffix;
                //    ws.Cells[i, 6].Value = item.URL;
                //    ws.Cells[i, 7].Value = item.ORG;
                //    ws.Cells[i, 8].Value = item.EMAIL;
                //    ws.Cells[i, 9].Value = item.EMAILHOME;
                //    ws.Cells[i, 10].Value = item.EMAILWORK;
                //    ws.Cells[i, 11].Value = item.TITLE;
                //    ws.Cells[i, 12].Value = item.TEL;
                //    ws.Cells[i, 13].Value = item.TELCELL;
                //    ws.Cells[i, 14].Value = item.TELWORK;
                //    ws.Cells[i, 15].Value = item.TELHOME;
                //    ws.Cells[i, 16].Value = item.TELPREF;
                //    ws.Cells[i, 17].Value = item.TELVOICE;
                //    ws.Cells[i, 18].Value = item.ADR;
                //    ws.Cells[i, 19].Value = item.ADRHOME;
                //    ws.Cells[i, 20].Value = item.ADRWORK;
                //    ws.Cells[i, 21].Value = item.NOTE1;
                //    ws.Cells[i, 22].Value = item.NOTE2;
                //    ws.Cells[i, 23].Value = item.NOTE3;
                //    ws.Cells[i, 24].Value = item.OTHER1;
                //    ws.Cells[i, 25].Value = item.OTHER2;
                //    ws.Cells[i, 26].Value = item.OTHER3;
                //    ws.Cells[i, 27].Value = item.OTHER4;
                //    ws.Cells[i, 28].Value = item.OTHER5;
                //    ws.Cells[i, 29].Value = item.OTHER6;
                //    ws.Cells[i, 30].Value = item.OTHER7;
                //    ws.Cells[i, 31].Value = item.OTHER8;
                //    ws.Cells[i, 32].Value = item.OTHER9;
                //    i++;
                //}
                //p.Save();
            }
        }

        public static List<VCF> LoadVcf(List<string> AllLines)
        {
            List<VCF> cards = new List<VCF>();
            try
            {
                int id = 0;
                int startCard = -1;
                int endCard = -1;
                for (int i = 0; i < AllLines.Count; i++)
                {
                    if (endCard != -1)
                    {
                        var card = BringVcf(AllLines, startCard, endCard);
                        //card.Id = id.ToString();
                        id++;
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


        private static VCF BringVcf(List<string> allLines, int startCard, int endCard)
        {
            var vcfStringList = new List<string>();
            for (int i = startCard; i <= endCard; i++)
            {
                vcfStringList.Add(allLines[i]);
            }
            VCF result = new VCF(vcfStringList);


            return result;
        }
    }
}
