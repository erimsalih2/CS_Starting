using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kullanici adiniz:");

            string username = Console.ReadLine();
            Console.WriteLine("Sifreniz:");
            string password = Console.ReadLine();
            string realUsername="Ahmet";
            string realPassword="3252";

            if (username == realUsername & password==realPassword)
                
            {
                Console.WriteLine("Giris basarili");
            }
            else
            {
                Console.WriteLine("Giris basarisiz");
            }
        }
    }
}
