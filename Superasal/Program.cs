using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornekler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = Convert.ToInt32(Console.ReadLine());
            int sayac = 0;
            bool asal = false;
            int temp = sayi;

            while (temp > 0)
            {
                sayac++;//basamak sayisi
                temp /= 10;

            }
            Console.WriteLine("Sayiniz {0} basamaklıdır", sayac);
            int x = sayi;

            for (int i = 0; i < sayac; i++)
            {
                asal = true;

                if (x == 1||x==0) {
                    Console.WriteLine("ilk basamak ya 1 ya da girilen deger 0 sayi super asal degildir.");
                    break; }
                else if (x == 2)
                {
                    Console.WriteLine("Sayi super asaldır");
                }
                else
                {
                    for (int j = 2; j < x; j++)
                    {
                        if (x % j == 0)
                        {
                            Console.WriteLine("Sayi  super asal degildir");
                            asal = false;
                            break;
                        }

                    }
                    if (asal == false)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("{0}. basamak asaldir", sayac - i);
                    }
                    x = sayi / 10;

                }
                
            }















            Console.ReadLine();
        }
    }
}