using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] iworker = new IWorker[3]
            {
                new Worker(),
                new Robot(),
                new Manager()
            };

            // SOLID , Interface Segregation 
            ISalary[] isalary = new ISalary[2]
            {
                new Worker(),
                new Manager()
            };

            IEat[] ieat = new IEat[2]
            {
                new Worker(),
                new Manager()
            };

            foreach (var item in ieat)
            {
                item.Eat();
            }

            foreach (var item in iworker)
            {
                item.Work();
            }

            foreach (var item in isalary)
            {
                item.GetSalary();
            }

            Console.ReadKey();
        }
    }
    interface IWorker 
    {
        void Work();
    }

    interface ISalary
    {
        void GetSalary();
    }

    interface IEat
    {
        void Eat();
    }

    class Manager : IEat, ISalary, IWorker
    {
        public void Eat()
        {
            Console.WriteLine("Manager Ate.");
        }

        public void GetSalary()
        {
            Console.WriteLine("Manager got salary.");
        }

        public void Work()
        {
            Console.WriteLine("Manager worked");
        }
    }

    class Worker : IWorker, ISalary, IEat
    {
        public void Eat()
        {
            Console.WriteLine("Worker Ate.");
        }

        public void GetSalary()
        {
            Console.WriteLine("Worker got salary.");
        }

        public void Work()
        {
            Console.WriteLine("Worker worked");
        }
    }

    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Robot worked");
        }
    }
}
