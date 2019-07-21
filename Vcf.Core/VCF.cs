using System;
using System.Collections.Generic;
using System.Text;

namespace Vcf.Core
{
    public class VCF
    {
        //public string Id { get; set; }
        public string Prefix { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Suffix { get; set; }
        public string URL { get; set; }
        public string ORG { get; set; }
        public string EMAIL { get; set; }
        public string EMAILHOME { get; set; }
        public string EMAILWORK { get; set; }
        public string TITLE { get; set; }
        public string TEL { get; set; }
        public string TELCELL { get; set; }
        public string TELWORK { get; set; }
        public string TELHOME { get; set; }
        public string TELPREF { get; set; }
        public string TELVOICE { get; set; }
        public string ADR { get; set; }
        public string ADRHOME { get; set; }
        public string ADRWORK { get; set; }
        public string NOTE1 { get; set; }
        public string NOTE2 { get; set; }
        public string NOTE3 { get; set; }
        public string OTHER1 { get; set; }
        public string OTHER2 { get; set; }
        public string OTHER3 { get; set; }
        public string OTHER4 { get; set; }
        public string OTHER5 { get; set; }
        public string OTHER6 { get; set; }
        public string OTHER7 { get; set; }
        public string OTHER8 { get; set; }
        public string OTHER9 { get; set; }
        public VCF()
        {
            init();
        }
        void init()
        {
            //Id = "-1";
            Prefix = "";
            FirstName = "";
            MiddleName = "";
            LastName = "";
            Suffix = "";
            URL = "";
            ORG = "";
            EMAIL = "";
            EMAILHOME = "";
            EMAILWORK = "";
            TITLE = "";
            TEL = "";
            TELCELL = "";
            TELWORK = "";
            TELHOME = "";
            TELPREF = "";
            TELVOICE = "";
            ADR = "";
            ADRHOME = "";
            ADRWORK = "";
            NOTE1 = "";
            NOTE2 = "";
            NOTE3 = "";
            OTHER1 = "";
            OTHER2 = "";
            OTHER3 = "";
            OTHER4 = "";
            OTHER5 = "";
            OTHER6 = "";
            OTHER7 = "";
            OTHER8 = "";
            OTHER9 = "";
        }
        public VCF(List<string> bulkData)
        {
            init();
            #region e.g.

            //BEGIN:VCARD
            //VERSION:2.1
            //N;CHARSET=UTF-8;ENCODING=QUOTED-PRINTABLE:=53=6F=79=61=64=20;=41=64;=C4=B0=6B=69=6E=63=69=20=41=64;=41=64=20=C3=96=6E=20=45=6B;=41=64=2E=20=53=6F=6E=20=45=6B
            //FN;CHARSET=UTF-8;ENCODING=QUOTED-PRINTABLE:=41=64=20=C3=96=6E=20=45=6B=20=41=64=20=C4=B0=6B=69=6E=63=69=20=41=64=
            //=20=53=6F=79=61=64=2C=20=41=64=2E=20=53=6F=6E=20=45=6B
            //X-PHONETIC-FIRST-NAME:fonetik ad
            //X-PHONETIC-MIDDLE-NAME:fonetik ikinci ad
            //X-PHONETIC-LAST-NAME:fonetik soyad 
            //X-ANDROID-CUSTOM:vnd.android.cursor.item/nickname;Rumuz;1;;;;;;;;;;;;;
            //TEL;CELL:111-222
            //TEL;WORK:222-333
            //TEL;HOME:333-444
            //TEL;PREF:444-555
            //TEL;VOICE:666-777
            //EMAIL;HOME:eposta1
            //EMAIL;WORK:eposta2
            //ADR;HOME;CHARSET=UTF-8;ENCODING=QUOTED-PRINTABLE:=50=6F=73=74=61=20=4B=75=74=75=73=75=20;;=43=61=64=64=65;=C5=9E=65=68=69=72=20=20=4D=61=68=61=6C=6C=65=20;=45=79=61=6C=65=74=20;=50=6F=73=74=61=20=4B=6F=64=75;=C3=9C=6C=6B=65=20
            //ADR;WORK;CHARSET=UTF-8;ENCODING=QUOTED-PRINTABLE:=50=6F=73=74=61=20=4B=75=74=75=73=75=20=32;;=43=61=64=64=65=20=32;=C5=9E=65=68=69=72=20=32=20=4D=61=68=61=6C=6C=65=20=32;=45=79=61=6C=65=74=20=32;=50=6F=73=74=61=20=4B=6F=64=75=20=32;=C3=9C=6C=6B=65=20
            //ORG;CHARSET=UTF-8;ENCODING=QUOTED-PRINTABLE:=C5=9E=69=72=6B=65=74
            //TITLE;CHARSET=UTF-8;ENCODING=QUOTED-PRINTABLE:=42=61=C5=9F=6C=C4=B1=6B
            //URL:websitesi
            //NOTE:Notlar 1
            //NOTE:Notlar 2
            //X-SKYPE-USERNAME:im
            //X-ANDROID-CUSTOM;CHARSET=UTF-8;ENCODING=QUOTED-PRINTABLE:vnd.android.cursor.item/relation;=C4=B0=6C=69=C5=9F=6B=69=20;=31;;;;;;;;;;;;;
            //END:VCARD 
            #endregion

            foreach (var item in bulkData)
            {
                if (item.StartsWith("FN") || item.StartsWith("VERSION"))
                    continue;

                var value = item.Contains("CHARSET=UTF-8;ENCODING=QUOTED-PRINTABLE") ? Decode(GetValue(item)) : GetValue(item);
                if (item.StartsWith("N;") || item.StartsWith("N:"))
                {
                    //Soyad ;Ad;İkinci Ad;Ad Ön Ek;Ad. Son Ek
                    var Splitted = value.Split(';');
                    Prefix = Splitted[3];
                    FirstName = Splitted[1];
                    MiddleName = Splitted[2];
                    LastName = Splitted[0];
                    Suffix = Splitted[4];
                }
                else if (item.StartsWith("TEL")) AddToTel(value.Replace("-", ""));
                else if (item.StartsWith("EMAIL")) AddToEMail(value);
                else if (item.StartsWith("ADR")) AddToAddress(value);
                else if (item.StartsWith("ORG;") || item.StartsWith("ORG:")) ORG = value;
                else if (item.StartsWith("TITLE;") || item.StartsWith("TITLE:")) TITLE = value;
                else if (item.StartsWith("URL;") || item.StartsWith("URL:")) URL = value;
                else if (item.StartsWith("NOTE;") || item.StartsWith("NOTE:")) AddToNote(value);
                else if (!item.StartsWith("BEGIN:VCARD") && !item.StartsWith("END:VCARD")) AddToOther(item);
            }
        }

        private void AddToOther(string item)
        {
            if (string.IsNullOrEmpty(item))
                return;
            if (string.IsNullOrEmpty(this.OTHER1))
                this.OTHER1 = item;
            else if (string.IsNullOrEmpty(this.OTHER2))
                this.OTHER2 = item;
            else if (string.IsNullOrEmpty(this.OTHER3))
                this.OTHER3 = item;
            else if (string.IsNullOrEmpty(this.OTHER4))
                this.OTHER4 = item;
            else if (string.IsNullOrEmpty(this.OTHER5))
                this.OTHER5 = item;
            else if (string.IsNullOrEmpty(this.OTHER6))
                this.OTHER6 = item;
            else if (string.IsNullOrEmpty(this.OTHER7))
                this.OTHER7 = item;
            else if (string.IsNullOrEmpty(this.OTHER8))
                this.OTHER8 = item;
            else if (string.IsNullOrEmpty(this.OTHER9))
                this.OTHER9 = item;
        }
        private void AddToAddress(string value)
        {
            //Posta Kutusu ;;Cadde;Şehir  Mahalle ;Eyalet ;Posta Kodu;Ülke 
            if (string.IsNullOrEmpty(value))
                return;
            else if (string.IsNullOrEmpty(this.ADR))
                this.ADR = value;
            else if (string.IsNullOrEmpty(this.ADRHOME))
                this.ADRHOME = value;
            else if (string.IsNullOrEmpty(this.ADRWORK))
                this.ADRWORK = value;
            else
                AddToOther("ADR:" + value);
        }
        private void AddToNote(string value)
        {
            if (string.IsNullOrEmpty(value))
                return;
            else if (string.IsNullOrEmpty(this.NOTE1))
                this.NOTE1 = value;
            else if (string.IsNullOrEmpty(this.NOTE2))
                this.NOTE2 = value;
            else if (string.IsNullOrEmpty(this.NOTE3))
                this.NOTE3 = value;
            else
                AddToOther("NOTE:" + value);
        }
        private void AddToEMail(string value)
        {
            if (string.IsNullOrEmpty(value))
                return;
            else if (string.IsNullOrEmpty(this.EMAIL))
                this.EMAIL = value;
            else if (string.IsNullOrEmpty(this.EMAILWORK))
                this.EMAILWORK = value;
            else if (string.IsNullOrEmpty(this.EMAILHOME))
                this.EMAILHOME = value;
            else
                AddToOther("EMAIL:" + value);
        }
        private void AddToTel(string value)
        {
            if (string.IsNullOrEmpty(value))
                return;
            else if (
                value.Equals(this.TEL) ||
                value.Equals(this.TELCELL) ||
                value.Equals(this.TELHOME) ||
                value.Equals(this.TELWORK) ||
                value.Equals(this.TELVOICE) ||
                value.Equals(this.TELPREF))
            {
                return;
            }
            else if (string.IsNullOrEmpty(this.TEL))
                this.TEL = value;
            else if (string.IsNullOrEmpty(this.TELCELL))
                this.TELCELL = value;
            else if (string.IsNullOrEmpty(this.TELHOME))
                this.TELHOME = value;
            else if (string.IsNullOrEmpty(this.TELWORK))
                this.TELWORK = value;
            else if (string.IsNullOrEmpty(this.TELVOICE))
                this.TELVOICE = value;
            else if (string.IsNullOrEmpty(this.TELPREF))
                this.TELPREF = value;
            else
                AddToOther("TEL:" + value);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("BEGIN:VCARD");
            sb.AppendLine("VERSION:4.0");
            //Soyad ;Ad;İkinci Ad;Ad Ön Ek;Ad. Son Ek
            sb.AppendLine($"N:{LastName};{FirstName};{MiddleName};{Prefix};{Suffix}");
            sb.AppendLine($"FN:{Prefix}{FirstName}{MiddleName}{LastName}{Suffix}");//nasıl görüneceği

            if (TEL.Length > 0) sb.AppendLine($"TEL:{TEL}");
            if (TELHOME.Length > 0) sb.AppendLine($"TEL;HOME:{TELHOME}");
            if (TELCELL.Length > 0) sb.AppendLine($"TEL;CELL:{TELCELL}");
            if (TELPREF.Length > 0) sb.AppendLine($"TEL;PREF:{TELPREF}");
            if (TELVOICE.Length > 0) sb.AppendLine($"TEL;VOICE:{TELVOICE}");

            if (EMAIL.Length > 0) sb.AppendLine($"EMAIL:{EMAIL}");
            if (EMAILHOME.Length > 0) sb.AppendLine($"EMAIL;HOME:{EMAILHOME}");
            if (EMAILWORK.Length > 0) sb.AppendLine($"EMAIL;WORK:{EMAILWORK}");

            if (ADR.Length > 0) sb.AppendLine($"ADR:{ADR}");
            if (ADRHOME.Length > 0) sb.AppendLine($"ADR;HOME:{ADRHOME}");
            if (ADRWORK.Length > 0) sb.AppendLine($"ADR;WORK:{ADRWORK}");

            if (ORG.Length > 0) sb.AppendLine($"ORG:{ORG}");
            if (TITLE.Length > 0) sb.AppendLine($"TITLE:{TITLE}");
            if (URL.Length > 0) sb.AppendLine($"ADR:{URL}");

            if (NOTE1.Length > 0) sb.AppendLine($"NOTE:{NOTE1}");
            if (NOTE2.Length > 0) sb.AppendLine($"NOTE:{NOTE2}");
            if (NOTE3.Length > 0) sb.AppendLine($"NOTE:{NOTE3}");

            if (OTHER1.Length > 0) sb.AppendLine(OTHER1);
            if (OTHER2.Length > 0) sb.AppendLine(OTHER2);
            if (OTHER3.Length > 0) sb.AppendLine(OTHER3);
            if (OTHER4.Length > 0) sb.AppendLine(OTHER4);
            if (OTHER5.Length > 0) sb.AppendLine(OTHER5);
            if (OTHER6.Length > 0) sb.AppendLine(OTHER6);
            if (OTHER7.Length > 0) sb.AppendLine(OTHER7);
            if (OTHER8.Length > 0) sb.AppendLine(OTHER8);
            if (OTHER9.Length > 0) sb.AppendLine(OTHER9);

            sb.AppendLine("END:VCARD");

            return sb.ToString();
        }
        private string GetValue(string raw)
        {
            if (string.IsNullOrEmpty(raw))
                return "";
            var value = raw.Substring(raw.IndexOf(':') + 1);
            return value;
        }

        //DecodeQuotedPrintablesWithTurkishChars
        private string Decode(string raw)
        {
            if (string.IsNullOrEmpty(raw))
                return "";
            string encodedString = raw;
            List<KeyValuePair<string, string>> TurkishChars = new List<KeyValuePair<string, string>>();
            TurkishChars.Add(new KeyValuePair<string, string>(";", "=3B"));
            TurkishChars.Add(new KeyValuePair<string, string>(" ", "=20"));
            TurkishChars.Add(new KeyValuePair<string, string>("=C3=96", "=4F")); //Ö -> O
            TurkishChars.Add(new KeyValuePair<string, string>("=C3=B6", "=6F")); //ö -> o
            TurkishChars.Add(new KeyValuePair<string, string>("=C5=9E", "=53")); //Ş -> S
            TurkishChars.Add(new KeyValuePair<string, string>("=C5=9F", "=73")); //ş -> s
            TurkishChars.Add(new KeyValuePair<string, string>("=C4=B0", "=69")); //İ -> i
            TurkishChars.Add(new KeyValuePair<string, string>("=C4=B1", "=69")); //ı -> i
            TurkishChars.Add(new KeyValuePair<string, string>("=C3=87", "=43")); //Ç -> C
            TurkishChars.Add(new KeyValuePair<string, string>("=C3=A7", "=63")); //ç -> c
            TurkishChars.Add(new KeyValuePair<string, string>("=C3=9C", "=55")); //Ü -> U
            TurkishChars.Add(new KeyValuePair<string, string>("=C3=BC", "=75")); //ü -> u
            TurkishChars.ForEach(ch => encodedString = encodedString.Replace(ch.Key, ch.Value));
            StringBuilder sb = new StringBuilder();
            List<string> strList = ToList(encodedString.Split(new string[] { "=" }, StringSplitOptions.RemoveEmptyEntries));
            List<char> charList = new List<char>();
            strList.ForEach(item => charList.Add((char)Int32.Parse(item, System.Globalization.NumberStyles.HexNumber)));//AllowHexSpecifier
            charList.ForEach(item => sb.Append(item.ToString()));
            string result = sb.ToString();
            return result + " ";
        }

        private List<T> ToList<T>(T[] ts)
        {
            var Result = new List<T>();
            for (int i = 0; i < ts.Length; i++)
            {
                Result.Add(ts[i]);
            }
            return Result;
        }
    }
}
