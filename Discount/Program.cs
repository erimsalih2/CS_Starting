using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ne kadar alisveris yaptin");
            var Harcama=Convert.ToInt32(Console.ReadLine());
            double discount = 0.1;
            double result = Harcama - Harcama * discount;
            Console.WriteLine(result+" Bu sizin indirimli yeni fiyatinizdir H.O");

        }
    }
}
