using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kosullu_ifade_ornek4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Turkiyenin baskenti?");
            string baskent=Console.ReadLine();
            Console.WriteLine("Almanya hangi kitada");
            string kita=Console.ReadLine();
            Console.WriteLine("Renkleri siyah beyaz olan takim");
            string takim=Console.ReadLine();
            int dogru = 0;
            int yanlis = 0;

            if (baskent == "Ankara" || baskent == "ankara")
            {
                dogru++;

            }
            else
            {
                yanlis++;

            }
            if (takim == "Besiktas" || takim == "Besiktas")
            {
                dogru++;

            }
            else
            {
                yanlis++;

            }
            if (kita == "Avrupa" || kita == "avrupa")
            {
                dogru++;

            }
            else
            {
                yanlis++;

            }
            Console.WriteLine("Dogru sayisi:" + dogru + "\n" + "Yanlis sayisi:" + yanlis);
        }
    }
}
