using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Database can = new Oracle();
            can.Add();
            Oracle canan = new Oracle();
            canan.Add();
            canan.Delete();
            can.Delete();
        }
    }
    abstract class Database
    {
        public void Add()
        {
            Console.WriteLine("Added by deafault");
        }
        public abstract void Delete();//inheritance gibi değiştirilmesi lazım 
        //override yapılmalı
        
    }
    class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by sql");
        }
    }
    class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by oracle");
        }
    }
}
