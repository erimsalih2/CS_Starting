using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kosullu_İfade_Ornek3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kare mi daire mi?");
            string soru=Console.ReadLine();
            

            if (soru == "Kare"||soru=="kare")
            {
                Console.WriteLine("Karenin 1 kenarı nedir?");
                var kenar= Convert.ToInt64(Console.ReadLine());
                var KareAlan=Math.Pow(kenar, 2);
            }
            else if (soru == "Daire"||soru=="daire")
            {
                Console.WriteLine("Dairenin yaricapi nedir?");
                var r=Convert.ToInt64(Console.ReadLine());
                double daireAlan = Math.Pow(r,2) * Math.PI;
            }
        }
    }
}
