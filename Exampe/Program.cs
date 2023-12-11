using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exampe
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            rastgele();
        }

        private static void rastgele()
        {
            Random RandSayiUret = new Random();
            int[] sayilar= new int[50];
            for(int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = RandSayiUret.Next(0,100);
            }
            foreach(int i in sayilar)
            {
                Console.WriteLine(i);
            }
        }

        private static void Asal(int x)
        {
            bool asalsayi=true;
            for (int i = 2; i < x; x--)
            {


                asalsayi = true;

                for (int j = 2; j < x; j++)
                {
                    if (x % j == 0)
                    {
                        asalsayi = false;
                        break;
                    }
                }
                if (asalsayi == true) {
                    Console.WriteLine(x);
                }
                
            }
        }
    }
}
