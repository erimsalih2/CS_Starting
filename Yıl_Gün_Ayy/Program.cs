using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yıl_Gün_Ayy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DateTime Sınıfının Today elemanın Year Elemanını bir değişkene atayalım
            //DateTime sınıfının Today elemanının Month elemanını bir değişkene atayalım
            //DateTime sınıfının Today elemanının Day elemanını bir değişkene atayalım.
            //Yarının tarihini ekrana yazdırın
            var Today_year = DateTime.Today.Year;
            var Today_Month=DateTime.Today.Month;   
            var Today_day=DateTime.Today.Day+1;
            Console.WriteLine(Today_day + "." + Today_Month + "." + Today_year);
        }
    }
}
