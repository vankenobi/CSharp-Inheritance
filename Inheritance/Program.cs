using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Id = 5;
            customer.Name = "musa";

            Person[] person = new Person[3]
            {
                new Customer{ Name = "Musa" , Country = "Turkey",Surname = "Küçük"},
                new Student{ Name = "Mustafa" },
                new Person{ Name = "Nursena" }
            };

            foreach (var item in person)
            {
                Console.WriteLine(item.Name);
            }

            Console.ReadKey();
        }
    }
    class Person
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Surname { get; set; }
    }

    class Customer : Person
    {
        public String Country { get; set; }
        public String Province { get; set; }
    }
    class Student : Person
    {
        public String Country { get; set; }
        public String Province { get; set; }
        public int Mean { get; set; }
    }
}
