using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasKagitMakas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Taş kağıt Makas oyniyacağız\nTaş-1\nMakas-2\nKağıt-3\n");
            int tahmin=Convert.ToInt32(Console.ReadLine());
            int bilgisayar = Randomsayi();
            switch (bilgisayar) {
                    case 1: Console.WriteLine("Bilgisayar taş seçti");
                    break;
                    case 2: Console.WriteLine("Bilgisayar Makas seçti");
                    break;
                    case 3: Console.WriteLine("Bilgisayar Kağıt seçti");
                    break;
            
            }
            if (bilgisayar == tahmin) Console.WriteLine("iki seçim de aynı");
            else if (bilgisayar == 1 && tahmin == 3) Console.WriteLine("Kazandın tebrikler");
            else if (bilgisayar == 2 && tahmin == 1) Console.WriteLine("Kazandın tebrikler");
            else if (bilgisayar == 3 && tahmin == 2) Console.WriteLine("Kazandın tebrikler");
            else if (bilgisayar == 3 && tahmin == 1) Console.WriteLine("Kaybettin aptal");
            else if (bilgisayar == 1 && tahmin == 2) Console.WriteLine("Kaybettin aptal");
            else if (bilgisayar == 2 && tahmin == 3) Console.WriteLine("Kaybettin aptal");
        }

        private static int Randomsayi()
        {
            Random rand = new Random();

            return rand.Next(1,4);
        }
    }
}
