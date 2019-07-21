using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VCF;

namespace VCF.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Service service = new Service();
            service.ConvertvCardFileToExcelFile(@"C:\Users\said\Desktop\contacts00002.vcf", @"C:\Users\said\Desktop\tayfuntest.xlsx");
        }
    }
}
