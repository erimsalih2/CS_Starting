using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            string[] kartlar = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "10", "10", "10", "A" };

            
           
          Console.WriteLine("ilk kartin cekiliyor...\nIlk Kartın:{0}", kartlar[rnd.Next(14)]);
          Console.WriteLine("Dealer kartini cekiyor...\nIlk Kartı{0}", kartlar[rnd.Next(14)]);
        }
    }
}
