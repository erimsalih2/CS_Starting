using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarihFormatOrnek2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dogumTarihi=Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine(dogumTarihi.DayOfWeek);
          int Kacgun = (Int32)(DateTime.Now - dogumTarihi).TotalDays;
            Console.WriteLine(Kacgun);
        }
    }
}
