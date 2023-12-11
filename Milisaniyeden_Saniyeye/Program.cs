using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milisaniyeden_Saniyeye
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Environment sınıfının TickCount elemanını bir değişkene atayın
            //ms cinsinden olan bu değeri dakika olarak ekrana yazdırın
            //not küsüratlı olabilsin


            var tms = Environment.TickCount;
            var ts = tms / 1000;
            var dk = ts / 60;
            var s = dk / 60;
            Console.WriteLine(s+" saat")

        }
    }
}
