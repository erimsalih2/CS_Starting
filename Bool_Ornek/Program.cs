using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bool_Ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kac Yasindasin");
            int yas=Convert.ToInt32(Console.ReadLine());
            bool resit = yas > 18;
            Console.WriteLine(resit);
            bool varmi = Directory.Exists("root");
            Console.WriteLine(varmi);
        }
    }
}
