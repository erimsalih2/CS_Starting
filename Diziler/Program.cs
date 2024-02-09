using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ornek3();
        }

        private static void Ornek3()
        {
            string[] sorular = { "33 plakayalı ilimiz?", "Muzu meşhur olan ilçe", "Mersin hangi bölgede" };
            string[] cevaplar=new string[sorular.Length];
            //Sırasıyla bu soruları soran, cevaplarını değerlendiren, en sonunda doğru yanlış sayısını ekrana yazdıran uygulamayı yazınız
            for (int i = 0; i < sorular.Length; i++)
            {
                Console.WriteLine("sırasıyla sorulara cevap veriniz lütfen");
                Console.WriteLine(sorular[i]);
                string temp= Console.ReadLine();
                cevaplar[i] = temp;
               
            }
            int dogru = 0;
            if (cevaplar[0] == "Mersin" || cevaplar[0] == "mersin")
            {
                dogru++;
            }
            if (cevaplar[1] == "Diyarbakır" || cevaplar[1] == "diyarbakır")
            {
                dogru++;
            }
            if (cevaplar[2] == "ege" || cevaplar[2] == "Ege")
            {
                dogru++;
            }
            Console.WriteLine(sorular.Length+" sorudan şu kadarını bildiniz: "+dogru);
        }

        private static void Ornek2()
        {
            string[] dosyalar = Directory.GetFiles(@"C:\Users\USER\source\repos\C# Starting\Diziler");
            Console.WriteLine("C sürücüsünde " + dosyalar.Length +" Dosya var");
            Console.WriteLine("İlk dosya " + dosyalar[0]);
            string[] dosyaBolumu = dosyalar[0].Split('\\');
            Console.WriteLine(dosyaBolumu[dosyaBolumu.Length-1]);
        }

        private static void Ornek1()
        {
            string tarih = "29.11.2018";
            string[] parcalar=tarih.Split('.');
            Console.Write(parcalar[2]);
            int index = parcalar.Length - 3;
            Console.Write(parcalar[index]);
        }

        private static void Dizi_Tanimlama()
        {
            string[] kisiler = {"Ali:Can:Tuba:Cansu" };
            int[] sayilar = { 1, 3, 21, 45, 732, 52 };
            char[] karakter = { 'a', 'b', 'c', };
            Console.WriteLine(kisiler[0]);
            Console.ReadLine();

        }
    }
}
