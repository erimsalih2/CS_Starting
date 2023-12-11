using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeyaOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kac yasindasiniz?");
            int yas=Convert.ToInt32(Console.ReadLine());
            if(yas<=20) {
            Console.WriteLine("Tesekkurler");
                    }
            else if (yas <= 50 && yas > 20)
            {
                Console.WriteLine("Calisiyor musunuz? (e/h)");
                string soru=Console.ReadLine();
                string result=(soru == "e" || soru == "E") ? "Helal" : "Yuh be";
                Console.WriteLine("Tesekkurler");
            }
            else
            {
                Console.WriteLine("Tesekkurler");
            }
            Console.ReadLine();
        }
    }
}
