using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RussianPractice
{
    internal class Kilavuz
    {
        static Random rand = new Random();
        public static IDictionary<string, string> ruscaKelimeler = new Dictionary<string, string>() {

            {"Привет","Merhaba" },
            {"Да","Evet" },
            {"Нет","Hayır" },
            {"турецкий","Türk" },
            {"я","Ben" }






        };
        public static int DicLength { get {
                int x = 0;
            foreach(var item in ruscaKelimeler)
                {
                    x++;
                }
                return x;
            
            } set { } }



    }
}