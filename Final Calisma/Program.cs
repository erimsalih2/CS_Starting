using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Calisma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            Carp(ref x, 40);
            Console.WriteLine(x);
            string isim = "Mehmet";
            string isimler = "Mehmet,Ahmet,Kazım";
            Console.WriteLine(ayristir(isim,1,6));
            foreach(string s in bol(isimler, ','))
            {
                Console.WriteLine(s);
            }
        }



        static string ayristir(string x,int bas,int son)
        {
            ArrayList arrayList = new ArrayList();
            char[] harfler=x.ToCharArray();
            string anaKelime="";
            if(son>uzunluk(x))
            {
                Console.WriteLine("Yeni bir deger girin bu harf uzunlugunu asti");
                son=Convert.ToInt32(Console.ReadLine());
            }
            for(int i = bas; i < son;i++)
            {
                anaKelime += harfler[i];
            }
            return anaKelime;
            
            

            

        }
        static string[] bol(string x, char y)
        {
            string[] wow=x.Split(y);
            return wow;
        }
        static int Carp( ref int n,int x)
        {
            n=n*x; return n;
        }
        static int uzunluk(string x)
        {
            int i = 0;
            char[] harfler = x.ToCharArray();
            ArrayList arrayList = new ArrayList();  
            arrayList.AddRange(harfler);
            foreach(char c in arrayList)
            {
                i++;
            }
            return i;
        }
        static int tabela(int x)
        {
            if(x< 0)
            {
                return 
            }
        }
    }
}
