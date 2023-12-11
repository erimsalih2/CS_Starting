using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Çarpım_Programı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan 1-5 arası bir sayı isteyelim
            //Math sınıfının PI elemanını bir değişkene atayalım.
            //(not küsüratsız)
            //iki değeri çarpıp ekrana yazdıralım
            Console.WriteLine("1 ve 5 arası bir sayi giriniz lutfen");
            int sayi=Convert.ToInt32(Console.ReadLine());
            int PI = Convert.ToInt32(Math.PI);
            Console.WriteLine(sayi * PI);
        }
    }
}
