using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bip_Sound
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How old are you? :");
            string age = Console.ReadLine();
            Console.WriteLine(age+" is the best ages of life");
            Console.ReadLine();
            Console.Beep();


        }
    }
}
