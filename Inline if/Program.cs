using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inline_if
{
    internal class Program
    {
        static void Main(string[] args)
        {
           MyFunction();
        }

        private static void MyFunction()
        {
            //if else if else if else
            int sayi = 9;
            string _3unkatimi = (sayi % 3 == 0) ? "3 e tam bolunuyor" : "3 e kalanli bolunuyor";
        }
    }
}
