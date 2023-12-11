using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodlardaReturn
{
    internal class Program
    {
        static void Main(string[] args)
        {//Kullanıcıdan ayrı ayrı 2 sayı isteyip ortalamasını ekrana yazdıralım
            int sayi1=Convert.ToInt32(Console.ReadLine());
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Ortalama(sayi1, sayi2));
        }
        static int Ortalama(int ilk,int ilk2)
        {
            return (ilk+ilk2)/2;
        }
    }
}
