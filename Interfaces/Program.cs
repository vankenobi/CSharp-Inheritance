using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            
            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerDal(),
                new OracleServerDal(),
                new MySqlDal()
            };

            foreach (var item in customerDals)  // customerDals dizi içerisinde bulunan sınflar için Add() metoddu çalıştırıldı.
            {
                item.Add();
            }
            
            IntarfacesIntro2(customerManager);
            InterfacesIntro();
            Console.ReadLine();
        }

        private static void IntarfacesIntro2(CustomerManager customermanager)
        {
            CustomerManager customerManager = new CustomerManager();
            customermanager.Add(new SqlServerDal()); // Sql server için ekleme işlemi yapıldı.
            customermanager.Add(new OracleServerDal()); // Oracle server için ekleme işlemi yapıldı.
        }

        private static void InterfacesIntro()
        {
            PersonManager personmanager = new PersonManager();
            personmanager.Add(new Student { Firstname = "Musa", Lastname = "Küçük", Id = 007, Departmant = "ComputerScience" });
            personmanager.Add(new Customer { Firstname = "Nursena", Lastname = "Küçük", Id = 001, Address = "İstanbul" });
        }
    }

    interface IPerson 
    {
        int Id { get; set; }
        String Firstname { get; set; }
        String Lastname { get; set; }
    }

    class Customer:IPerson
    {
       public int Id { get; set; }
       public String Firstname { get; set; }
       public String Lastname { get; set; }
       public String Address { get; set; }
    }

    class Student:IPerson 
    {
        public int Id { get; set; }
        public String Firstname { get; set; }
        public String Lastname { get; set; }
        public String Departmant { get; set; }
    }

    class PersonManager 
    {
        public void Add(IPerson person) 
        {
            Console.WriteLine(person.Firstname);
        }
    }
}
