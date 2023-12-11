using System;
using System.Collections;
namespace Quiz2_Training
    
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string kelime = Console.ReadLine(); // string ifadeyi okuduk.
            char[] karakter = kelime.ToCharArray(); //string ifadenin tek tek karakterlerini aldım.

            for (int i = 0; i < karakter.Length; i++)
            {
                int sayi = Convert.ToInt32(karakter[i]);
                sayi -= 32; //ToLower - ToUpper için (-) kullan. 
                karakter[i] = Convert.ToChar(sayi);
                Console.Write(karakter[i]);
            }

            Console.ReadKey();
        }
    }
}



