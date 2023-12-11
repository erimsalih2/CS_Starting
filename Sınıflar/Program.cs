using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sınıflar
{
    internal class Program
    {
        static void Main(string[] args)
        {CustomerManager customerManager = new CustomerManager();
            customerManager.add(3.2);
            customerManager.lastName = "sevilmiş";
            customerManager.FirstName = "Salih";
            customerManager.City = "İstanbul";

            CustomerManager Mazlum = new CustomerManager()
            {
                City = "Çorum",
                Id=1,FirstName="Mazlum",lastName="Mehmet"
            };
            Console.WriteLine(Mazlum.FirstName);
        }
    }

    class CustomerManager
    {
        public string City { get; set; }
        public int Id { get; set; }
        private string _Firstname;
       
        public string FirstName {

            get { return "Mrs. " + _Firstname; }

            set { _Firstname = value; } }
        public string lastName { get; set; }
        public void add(int gay)
        {

            Console.WriteLine("Customer added"+gay);
        }
        public void add(double gay)
        {
            Console.WriteLine("Customer added but double" + gay);
        }
        public void update()
        {

            Console.WriteLine("Customer updated");
        }
    }
}
