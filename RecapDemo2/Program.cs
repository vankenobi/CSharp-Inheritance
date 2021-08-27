using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customermanager = new CustomerManager();
            customermanager.logger = new DocumentLogger();
            customermanager.Add();
            Console.ReadKey();
        }
    }

    interface ILogger
    {
        void log();
    }

    class CustomerManager 
    {
        public ILogger logger { get; set; }
        public void Add() 
        {
            logger.log();
            Console.WriteLine("Customer Manager Added.");
        }
    }
    class DatabaseLogger : ILogger
    {
        public void log()
        {
            Console.WriteLine("Database logger worked.");
        }
    }

    class DocumentLogger : ILogger
    {
        public void log()
        {
            Console.WriteLine("DocumentLogger worked.");
        }
    }

    class SmsLogger : ILogger
    {
        public void log()
        {
            Console.WriteLine("SmsLogger worked.");
        }
    }
}
