using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipguvenli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,string> dic = new Dictionary<string,string>();
            dic.Add("Book", "Kitap");
            dic.Add("Table", "Masa");
            dic.Add("Key", "Anahtar");

            Console.WriteLine(dic["Book"]);

        }

        private static void a()
        {
            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("Istanbul");
            foreach (string city in cities)
            {
                Console.WriteLine(city);
            }

            List<Customer> canan = new List<Customer> {
            new Customer{ Id=5,Name="kerhan"} };
            var customer2 = new Customer()
            {
                Id = 5,
                Name = "Osman"
            };
            canan.Add(customer2);
            canan.AddRange(new Customer[2]{//Toplu ekleme
                new Customer() {Id=8,Name="orhan"},
                new Customer() {Id=9,Name="korhan"}

            });
            Console.WriteLine(canan.Contains(customer2));
            canan.Add(new Customer() { Id = 3, Name = "Salih" });
            canan.Add(new Customer() { Id = 6, Name = "Mehmet" });
            foreach (Customer customer in canan)
            {
                Console.WriteLine(customer.Id);
            }
            var index = canan.IndexOf(customer2);
            Console.WriteLine(index);
        }
    }
    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    
}
