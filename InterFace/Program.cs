using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFace
{
    internal class Program
    {
        static void Main(string[] args)
        {//Interfaceler soyuttur tek başına anlam ifade etmezler

            PersonManager personManager = new PersonManager();
            Customer customer = new Customer() {
                Id = 1,
                Firstname = "Can",
                Lastname="boz",
                Adress="istanbul"

            
            };
            personManager.Add(customer);
            Student student = new Student()
            {
                Id = 2,
                Firstname = "salih",
                Lastname = "sevilmiş",
                Department = "bilgisayar"
            };
            personManager.Add(student);
        }
    }

    interface IPerson {
         int Id { get; set; }
         string Firstname {  get; set; }
        string Lastname { get; set; }
    }

    class Customer:IPerson
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Adress {  get; set; }
    }
    class Student : IPerson
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Adress { get; set; }
        public string Department { get; set; }
    }
    class Worker : IPerson
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Adress { get; set; }
        public string Department { get; set; }
        public int Salary {  get; set; }
    }
    class PersonManager
    {
        public void Add(IPerson customer)
        {
            Console.WriteLine(customer.Firstname);
        }
    }
}
