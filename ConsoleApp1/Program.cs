using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ornek3();
        }

        private static void Ornek3()
        {
            int asalmi = 0;
            int input=Convert.ToInt32(Console.ReadLine());
            int x = input;
            for (int i = 1; i < input; i++)
            {

                if (isAsalmi(i))
                    asalmi++;
               
            }
            Console.WriteLine(asalmi);
        }

        private static bool isAsalmi(int sayi)
        {
            bool asalMi = true;
            if (sayi == 1 || sayi == 0)
            {
                return false;
            }
            for(int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                    asalMi = false;

            }
            return asalMi;
        }

        private static void Asalmi()
        {
            int sayi=Convert.ToInt32(Console.ReadLine());



            bool asalmi = true;
            if (sayi == 1 || sayi == 0)
            {
                throw new Exception("Başka sayı girmeliydiniz");
            }
            for (int i = 2; i < sayi; i++)
            {
                if(sayi%i == 0) {
                    asalmi = false;break;
                }
            }
            Console.WriteLine("Sayi asalmidir:"+asalmi);
        }

        private static void Ornek1()
        {
            for (int i = 1; i < 10; i++)
            {
                for(int j = 1; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
