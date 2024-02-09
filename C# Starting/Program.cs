using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Starting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte number=3;
            int count = 10;
#pragma warning disable CS0219 // Variable is assigned but its value is never used
            float totalPrice = 20.95f;
#pragma warning restore CS0219 // Variable is assigned but its value is never used
#pragma warning disable CS0219 // Variable is assigned but its value is never used
            double littleMoney = 0.3;
#pragma warning restore CS0219 // Variable is assigned but its value is never used
#pragma warning disable CS0219 // Variable is assigned but its value is never used
            char character = 'A';
#pragma warning restore CS0219 // Variable is assigned but its value is never used
#pragma warning disable CS0219 // Variable is assigned but its value is never used
            string SayHello = "Hello There";
#pragma warning restore CS0219 // Variable is assigned but its value is never used
            bool isWorking = true;
            Console.WriteLine(number);






            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Hello");
                Console.WriteLine(isWorking);
            }
        }
    }
}
