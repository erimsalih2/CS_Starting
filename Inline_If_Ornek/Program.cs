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
            Gay();
            Console.ReadLine();
        }

        private static void Gay()
        {
            Console.WriteLine("ilk sayiyi giriniz");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ikinci sayiyi giriniz");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            string cevap = (sayi1 > sayi2) ? "ilk sayi ikincisinden büyüktür" : (sayi1 == sayi2) ? "iki sayi birbirine esittir" :  "ikinci sayi birinciden büyüktür";
            Console.WriteLine(cevap);
        }
        
    }
}
