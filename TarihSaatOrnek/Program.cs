using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarihSaatOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime _10gunsonra=DateTime.Now.AddDays(10);
            Console.WriteLine(_10gunsonra.ToString());   
        }
    }
}
