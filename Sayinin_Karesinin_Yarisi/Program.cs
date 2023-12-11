using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sayinin_Karesinin_Yarisi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.Pow(sayi,2)/2);
        }
    }
}
