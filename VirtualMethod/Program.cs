using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {SqlServer can=new SqlServer();
            can.Add();
            //Virtual methodu eğer hiçbir şey yapmassan içerde kullanmassan default olarak çalışır
            //overwrite yaparsan değişir virtual bunu yapmanı sağlar
        MySql canan = new MySql();  
            canan.Delete();
            canan.Add();
        }
    }
    class Database
    {
        public virtual void Add()
        {
            Console.WriteLine("Added by default");
        }
        public virtual void Delete()
        {
            Console.WriteLine("Deleted by default");
        }
    }
    class SqlServer : Database
    {
        public override void Add()
        {
            Console.WriteLine("Eklendi sql serverdan");
        }
    }
    class MySql : Database
    {
        public override void Delete()
        {
            Console.WriteLine("mysql den silindi");
        }
    }
}
