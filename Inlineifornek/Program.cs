using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlineifornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            gay();
        }

        private static void gay()
        {
            Console.WriteLine("ilk sayiyi giriniz");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ikinci sayiyi giriniz");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            string cevap = (sayi1 > sayi2) ? "ilk sayi ikincisinden büyüktür" : (sayi1 == sayi2) ? "iki sayi birbirine esittir" : (sayi1 < sayi2) ? "ikinci sayi birinciden büyüktür";
        }
    }
}
