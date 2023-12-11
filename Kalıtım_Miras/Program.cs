using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtım_Miras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] can = new Person[3] { 
            new Customer
            {
                Id = 1,
            },
            new Student { Id = 2,},
             new  Person{
                    Id = 3,
                }
            
            };
            foreach (Person person in can)
            {
                Console.WriteLine(person.Id);
            }
            
        }
    }
    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
    class Customer:Person
    {
        
        public string city { get; set; }
    }
    class Student:Person
    {

        public int Department { get; set; }
    }
}
