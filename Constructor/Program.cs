using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Product canan = new Product {Id=1,Name="Computer" };
            Product urun = new Product(2, "Laptop");
            urun.Hoba();*/

            EmployeeeManager emp=new EmployeeeManager(new DatabaseLogger());
            //emp.logger = new DatabaseLogger();
            emp.Add();
            
            PersonManager can = new PersonManager("Mehmetin ");
            can.Add();
            Teacher.Number=15;
            Manager.DoSomething();
            

        }
        class CustomerManager
        {
            private int _count = 10;
            public CustomerManager(int a)
            {
                _count = a;
            }
            public void List()
            {
                Console.WriteLine("Listed {0} items",_count);
            }
            public void add()
            {
                Console.WriteLine("added");
            }
        }
        class Product
        {
            private int _id;
            private string _name;
            public Product()
            {
                
            }
            public Product(int id,string name)
            {
                _id = id+5;
                _name = name+"boz";
                
            }
            public void Hoba()
            {
                Console.WriteLine(_id+_name);
            }
            public int Id { get; set;}
            public string Name { get; set;} 
        }

        interface ILogger
        {//Interfaceler diğer classlardan tarafından erişilebilir bir method tanımlar 
            //ancak içi boştur
            //biz bu kodda diğer classlardan tanımladığımız bu methodu ana classımızda kullandık
            void Log();
        }
        class DatabaseLogger:ILogger
        {
            public void Log()
            {
                Console.WriteLine("Logged to Database");
            }
        }
        class FileLogger : ILogger
        {
            public void Log()
            {
                Console.WriteLine("Logged to File");
            }
        }
        class EmployeeeManager
        {
            //public ILogger logger { get; set; }

            private ILogger _logger;
            public EmployeeeManager(ILogger input)
            {

                _logger = input;

            }

            public void Add()
            {
                _logger.Log();
                Console.WriteLine("Added");
            }
        }

        class BaseClass
        {
            private string _entity;
            public BaseClass(string input)
            {
                _entity=input;
            }
            public void Message()
            {
                Console.WriteLine("{0} message ", _entity);
            }
        }
        class PersonManager : BaseClass
        {
            public PersonManager(string hoba):base(hoba)//Base class da constructor olduğu için parametreyi vermemiz zorunludur 
            {//Çünkü yukardaki message methodunu da kullanabileceğiz o da constructordaki parametreyi kullanıcak
                
                
            }
            public void Add()
            {
                Console.WriteLine("Added");
                Message();
            }
        }

        static class Teacher
        {//static classın her şeyi static olmalı
            //static classa new methodunu kullanmadan erişebilirsin
            public static  int Number { get; set; }

        }
        class Manager
        {
            public static void DoSomething()
            {
                Console.WriteLine("Done");
            }
            public  void DoSomething2()
            {
                Console.WriteLine("Done2");
            }
        }
        static class Utilities
        {
             static Utilities()
            {

            }
        }
    }
}
