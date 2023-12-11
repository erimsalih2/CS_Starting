using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CokluImplemantasyon
{
    internal class Program
    {
        static void Main(string[] args)
        { IWorker[] worker = new IWorker[3] {
        new Manager(),new Worker(),new Robot()
        
        };
            foreach (var item in worker)
            {
                item.Work();
            }
        }
    }
    interface Isalary
    {
        void GetSalary();
    }
    interface Ieat
    {
        void Eat();
    }
    interface IWorker
    {
        void Work();
        
        
    }
    class Manager : IWorker,Ieat,Isalary
    {
        public void Eat()
        {
            Console.WriteLine("Al ekmek kırıntısı ye");
        }

        public void GetSalary()
        {
            Console.WriteLine("Maaşına 1 lira zam yaptım");
        }

        public void Work()
        {
            Console.WriteLine("Çalış Köle");
        }
    }
    class Worker : IWorker, Ieat, Isalary
    {
        public void Eat()
        {
           Console.WriteLine("Al ekmek kırıntısı ye");
        }

        public void GetSalary()
        {
            Console.WriteLine("Maaşına 1 lira zam yaptım");
        }

        public void Work()
        {
            Console.WriteLine("Çalış Köle");
        }
    }
    class Robot : IWorker
    {
        
        public void Work()
        {
            Console.WriteLine("Çalış Köle");
        }
    }
}
