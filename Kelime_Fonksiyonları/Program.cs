using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Security.Cryptography.X509Certificates;


namespace Kelime_Fonksiyonları
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] isimler =
            {
                "Ali","Ahmet","Mehmet"
            };
            string isim = "Ahmedullah";//10 harfli index sayısı 9 
            isim.Trim('A');
            Yazi.uzunluk(isim);
            Console.WriteLine(isim.Length);
            
            
            
        }
        class Yazi
        {
            public  bool varMi(string s)
            {
               
                Console.Write("Hangi harfi arıyon yaz");
                string girdi=Console.ReadLine();
                
                char[] harfler=s.ToCharArray();
                foreach(char y in harfler)
                {
                    if (y == Convert.ToChar(girdi.ToUpper())|| y == Convert.ToChar(girdi.ToLower()))
                    {
                        Console.WriteLine("Var");
                        return true;
                    }
                }
                Console.WriteLine("Yok");
                return false;

            }
            public static void birlestir(string[] a)
            {
                ArrayList arrayList = new ArrayList();
                
                foreach(string s in a)
                {
                   arrayList.Add(s);
                   arrayList.Add("-");
                }
               arrayList.RemoveAt(arrayList.Count-1);
                foreach(string s in arrayList)
                {
                    Console.Write(s);
                }
             
    


            }
            public static void uzunluk(string s)
            {
                char[] harfler = s.ToCharArray();
                ArrayList arrayList = new ArrayList();
                foreach(char c in harfler)
                {
                    arrayList.Add(c);
                }
                Console.WriteLine(arrayList.Count);
            }
            public static void Birlestir_s(string[] s)
            {
                string birlesmis="";
                foreach(string a in s)
                {
                    birlesmis = birlesmis+a+" ";
                }
                Console.WriteLine(birlesmis);

            }
            public static void parca_al(string s)
            {
                char[] harfler=s.ToCharArray();
                
                Console.WriteLine("Kacıncı indexten itibaren harf almak istiyorsun");
                int sayi=Convert.ToInt32(Console.ReadLine());
                if(harfler.Length-1 < sayi ) {
                    Console.WriteLine("indexi gectin gecersiz");
                
                }
                else { 

                    for(int i=sayi;i<harfler.Length;i++)
                    {
                        Console.Write(harfler[i]);
                        
                    }
                    Console.WriteLine();
                }
            }
            public static void index_bul(string s)
            {
                int sayac = 0;
                char[] harfler= s.ToCharArray();
                ArrayList arrayList = new ArrayList();
                Console.WriteLine("Hangi harfin indexini bulmak istiyorsunuz acep?");
                string ArananHarf=Console.ReadLine();
                for(int i=0;i<harfler.Length; i++)
                {
                    if (harfler[i] == Convert.ToChar(ArananHarf.ToUpper()) || harfler[i]==Convert.ToChar(ArananHarf.ToLower())) {
                        sayac++;
                        arrayList.Add(i);

                    }
                    
                }
                Console.WriteLine("Aradiginiz harf={0}", ArananHarf);
                Console.Write("Bu indexlerde bulunuyor:\n");
                foreach(int x in arrayList)
                {
                    Console.WriteLine(x);
                }

            }
        }
    }
}
