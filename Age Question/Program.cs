using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_Question
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yasinizi girin 3 le carpiyim:");
            var age=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Yasinin 3 ile carpilmis hali budur:"+age*3);
            
        }
    }
}
