using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dongu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BreakVeContinue();
        }

        private static void BreakVeContinue()
        {
            //Break döngüyü sonlandırır
            //Continue ise bir sonraki adıma geçer

            for (int i = 0; i < 10; i++) {

                    Console.WriteLine(i);
                if (i == 3)
                {
                    break;//3 ü yazdırıp programı bitirir
                }

            }
            for (int i = 0; i < 10; i++)
            {

                if (i == 3)
                {
                    continue;//3 ü atlar
                }
                Console.WriteLine(i);

            }
        }

        private static void Faktoriyel()
        {
            int input = Convert.ToInt32(Console.ReadLine());
            int temp = 1;
            if (input != 0)
            {
                for (int i = input; i>0; i--) 
                {
                    temp = temp * i;
                    

                }
                Console.WriteLine(temp);
            }
            else
            {
                Console.WriteLine("0 ın faktöriyeli 0dır");
            }
            Console.ReadLine();

        }

        private static void Ornek5()
        {
            Console.WriteLine("11 haneli telefon numarasını girin ");
            string Numara=Console.ReadLine();

            Console.WriteLine(Numara.Substring(0,4)+" "+Numara.Substring(4,3)+" "+Numara.Substring(7,2)+" "+Numara.Substring(9,2));
        }

        private static void ZorOrnek()
        {
            int temp = 0;

            int[] sayiDizisi = {10,19, 45, -247, 212, -134, 319, -78,400 };
            for (int i=0;i<sayiDizisi.Length;i++)
            {
                
                if (sayiDizisi[i] > temp)
                {
                    
                    temp = sayiDizisi[i];
                }
                Console.WriteLine(temp);
            }
        }

        private static void ForEachDongusuOrnek()
        {
            int[] sayilar = { 5, 9, 15, 17 };

            foreach (int i in sayilar) {

                Console.WriteLine(i);

                    }
        }

        private static void ForEachDongusu()
        {
            //Dolaşmak istediğimiz döngüyü bunun içine  yazıyorsunuz
            string[] ulkeler = { "Türkiye", "Almanya", "Fransa" };

            foreach (var item in ulkeler)
            {
                Console.WriteLine(item);
            }
        }

        private static void Ornek2()
        {
            int sayi = 0;
            string sifre = "pikacu";
            

            while (sayi == 0)
            {
                string input = Console.ReadLine();
                if (input == sifre) {
                    Console.WriteLine("Sifre dogru Hosgeldiniz");
                    sayi++;
                }
                else {
                    Console.WriteLine("Sifre yanlis lutfen tekrar deneyin");
                }
            }

        }

        private static void Ornek1()
        {
            string[] a = { "Mahmut", "Kerem", "kamil", "Kazım", "Kürdan" };
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }

        }
    }
}
