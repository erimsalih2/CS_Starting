using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kosullu_İfade_Ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yasinizi giriniz");
            int yas=Convert.ToInt32(Console.ReadLine());
            if(yas>18)
            {
                Console.WriteLine("Ehliyet alabilirsiniz");

            }
            else
            {
                Console.WriteLine("Ehliyet alamazsınız");
            }
        }
    }
}
