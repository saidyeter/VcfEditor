using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VcfEditor
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void miLoadVcf_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Vcf Dosyası |*.vcf";
            file.CheckFileExists = false;
            file.Title = "Vcf Dosyası Seçiniz..";

            if (file.ShowDialog() == DialogResult.OK)
            {
                string DosyaYolu = file.FileName;
                string DosyaAdi = file.SafeFileName;
            }
        }
        void LoadVcf(List<string> AllLines)
        {
            List<List<string>> BulkCards = new List<List<string>>();
            List<string> BulkCard = new List<string>();
            int startCard = -1;
            int endCard = -1;
            for (int i = 0; i < AllLines.Count; i++)
            {
                if (AllLines[i] == "BEGIN:VCARD")
                {

                }

            }
        }
        void Backup(List<VCF> cards)
        {
            DataAccess.Write(cards);
        }
        List<VCF> Restore()
        {
            return DataAccess.Read<VCF>();
        }
        void VcfToListString(VCF card)
        {
            var Result = new List<string>();
            Result.Add("BEGIN:VCARD");
            Result.Add("VERSION:4.0");
            Result.Add($"N:{card.LastName};{card.FirstName};{card.MiddleName};;");//versiyona göre property ayrılmış
            Result.Add($"FN:{card.FirstName}{card.MiddleName} {card.LastName}");//nasıl görüneceği
            Result.Add($"EMAIL:{card.Mail}");
            Result.Add($"ORG:{card.Company}");
            Result.Add($"TEL;CELL:{card.Number1}");
            Result.Add($"TEL;WORK:{card.Number2}");
            Result.Add($"ADR:;;;istanbul;;;");
            Result.Add($"NOTE:{card.Note}");
            Result.Add("END:VCARD");
        }
    }
    class VCF
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public string Mail { get; set; }
        public string Note { get; set; }
        public string Number1 { get; set; }
        public string Number2 { get; set; }
        public VCF()
        {
            Id = -1;
        }
    }
    class ListBoxItem
    {
        public string Value { get; set; }
        public string Text { get; set; }
    }
    public static class DataAccess
    {
        static string dataPath = Directory.GetParent(System.Reflection.Assembly.GetEntryAssembly().Location) + @"\" + typeof(T).Name + "s.Json";

        public static bool Write<T>(List<T> records)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(dataPath, false))
                {
                    writer.Write(JsonConvert.SerializeObject(records));
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }
        public static List<T> Read<T>()
        {
            List<T> result = new List<T>();
            string jsonObj = "";
            try
            {
                using (StreamReader reader = new StreamReader(dataPath))
                {
                    jsonObj = reader.ReadToEnd();
                }
                result = JsonConvert.DeserializeObject<List<T>>(jsonObj);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }
    }
}
