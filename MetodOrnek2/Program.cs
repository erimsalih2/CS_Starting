using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodOrnek2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıya doğduğu yılı sorup yılı geri taşıyan bir metod yazın
            //Az önceki metodu kullanarak kullanıcının yaşını hesaplayıp geri taşıyan bir metod yazın


            Console.WriteLine(Hangiyil());   

        }
        static int Hangiyil()
        {
            Console.WriteLine("Hangi yilda dogdun?");
            int yil=Convert.ToInt32(Console.ReadLine());
            
            return yasHesaplama(yil);
        }
        static int yasHesaplama(int x)
        {



            return 2023 - x;
        }
        
    }
}
