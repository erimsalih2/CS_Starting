using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormApp1
{
    internal class Class1
    {
        public string AdSoyad{ get; set; }
        public bool CanliMi { get; set; }
        


        public Class1()
        {
            CanliMi = true;
        }

        public Class1(string adSoyad)
        {
            AdSoyad = adSoyad;
            CanliMi &= true;
        }


        public static string SelamVer()
        {
            return "Merhaba!";
        }
        public string AdiniSoyle()
        {
            return "Benim adim "+AdSoyad;
        }
    }
}
