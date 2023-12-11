using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rastgele_Sayi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ornek2();
        }

        private static void Ornek2()
        {
           Random random = new Random();
            string[] sehir = { "İstanbul", "Ankara", "Karabük" };
            Console.WriteLine(sehir[random.Next(sehir.Length)]);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(random.Next(10));
            }
        }

        private static void Ornek1()
        {
            Random random = new Random();
            int sayi=random.Next(1,100);
            Console.WriteLine(sayi);
        }
    }
}
