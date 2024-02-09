using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KilavuzOgrenme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            var kelimeler=new Dictionary<string, string>() 
       
        
        
        {
            
            {"Привет","Merhaba" },
            {"Да","Evet" },
            {"Нет","Hayır" },
            {"турецкий","Türk" },
            {"я","Ben" }

        };
            int i = 0;
            foreach(var k in kelimeler) {
                
                i++;
            }
            Console.WriteLine(kelimeler.ElementAt(random.Next(i)));
            Console.ReadLine();
        }
    }
}
