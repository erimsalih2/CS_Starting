using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type_Conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            byte b = (byte)i;

            string number = "1234";
            i=Convert.ToInt32(number);
            Console.WriteLine(i+3);
        }
    }
}
