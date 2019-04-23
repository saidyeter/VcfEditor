using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vcf.Core;
using Vcf.Shell;

namespace VcfEditor
{
    public partial class Main : Form
    {
        List<VCF> cards;

        public Main()
        {
            InitializeComponent();
            cards = new List<VCF>();
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
            var lines = File.ReadAllLines(file.FileName).ToList(); lines.Add("");
            //var prg = new Vcf.Shell.Program();
            //if (prg.LoadVcf(lines))
            //{
            //    CardList.Items.Clear();
            //    foreach (var card in cards)
            //    {
            //        var lbItem = new ListBoxItem();
            //        lbItem.Value = card.Id;
            //        lbItem.Text = $"{card.Prefix}{card.FirstName}{card.MiddleName}{card.LastName}{card.Suffix}";

            //        CardList.Items.Add(lbItem);

            //    }
            //}
        }
        


        void Backup(List<VCF> cards)
        {
            DataAccess.Write(cards);
        }
        List<VCF> Restore()
        {
            return DataAccess.Read<VCF>();
        }

    }
    class ListBoxItem
    {
        public string Value { get; set; }
        public string Text { get; set; }
        public override string ToString()
        {
            return Text;
        }
    }
    public static class DataAccess
    {

        public static bool Write<T>(List<T> records)
        {
            string dataPath = Directory.GetParent(System.Reflection.Assembly.GetEntryAssembly().Location) + @"\" + typeof(T).Name + "s.Json";
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
            string dataPath = Directory.GetParent(System.Reflection.Assembly.GetEntryAssembly().Location) + @"\" + typeof(T).Name + "s.Json";
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
