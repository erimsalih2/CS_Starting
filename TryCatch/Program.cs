using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ornek3();
            Console.ReadLine();
        }

        private static void Ornek3()
        {
            try
            {
                Console.WriteLine("500 gr kuruyemişi kaç kişiye paylaştıracaksınız");
                int kisi = Convert.ToInt32(Console.ReadLine());
                if (kisi == 0)
                    throw new DivideByZeroException();
                double gram = 500.0 / kisi;
                Console.WriteLine("Kisi basi " + gram + "kuruyemis düşer");
            }
            catch (DivideByZeroException sifirHatasi) {
                Console.WriteLine("0 kisi olamaz");
            }
            catch(FormatException formatHatasi)
            {
                Console.WriteLine("Yalnizca sayi giriniz");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Baska bir hata ");
            }
        }

        private static void Loglama()
        {
            try { 
            Console.WriteLine("bir sayi giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());


            if (sayi == 3)
            {
                throw new Exception("Boyle sayi mi olur ");

            }
            }
            catch (Exception hata)//Hatanın bilgilerine ulaşmak için exception kullanılır
            {
                File.AppendAllText("log.txt", Environment.UserName);
                File.AppendAllText("log.txt", Environment.NewLine);
                File.AppendAllText("log.txt", DateTime.Now.ToString("dd.MM.yyyy HH:mm"));
                File.AppendAllText("log.txt", "\r\n");
                File.AppendAllText("log.txt", hata.Message);
                File.AppendAllText("log.txt", "@");
                File.AppendAllText("log.txt", hata.StackTrace);
                File.AppendAllText("log.txt", Environment.NewLine+"************"+Environment.NewLine);
            }
        }

        private static void Ornek2()
        {
            Console.WriteLine("Aklindan bir sayi tut");
            string sayi=Console.ReadLine(); 


            switch (sayi)
            {
                case "1":
                    throw new Exception("Begenmedim");
                    break;
                case "2":
                    throw new Exception("Baska sayi bulamadin mi");
                    break;
                case "3": throw new Exception("Boyle sayi mi olur calismiyom");
                    break;
            }
        }

        private static void Ornek1()
        {
            Console.WriteLine("Lutfen sinav notunuzu giriniz");
            try
            {
                int not = Convert.ToInt32(Console.ReadLine());

                if (not >= 0 && not <= 50)
                {
                    Console.WriteLine("daha cok calismalisin");

                }
                else if (not < 50 && not <= 70)
                {
                    Console.WriteLine("Daha iyi olabilirsin");

                }
                else if (not < 100 && not > 70)
                {
                    Console.WriteLine("Basarilisin");
                }

            }
            catch
            {
                Console.WriteLine("Sayi girmediniz. isleme devam edilmiyor");
            }
        }
    }
}

