using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
    }

    class SqlServerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Customer Sql Added.");
        }

        public void Delete()
        {
            Console.WriteLine("Customer Sql Deleted.");
        }

        public void Update()
        {
            Console.Write("Customer Sql Updated.");
        }
    }

    class OracleServerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Customer Oracle Added.");
        }

        public void Delete()
        {
            Console.WriteLine("Customer Oracle Deleted.");
        }

        public void Update()
        {
            Console.Write("Customer Oracle Updated.");
        }
    }

    class MySqlDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Customer MySql Added.");
        }

        public void Delete()
        {
            Console.WriteLine("Customer MySql Deleted.");
        }

        public void Update()
        {
            Console.Write("Customer MySql Updated.");
        }
    }

    class CustomerManager 
    {
        public void Add(ICustomerDal customerDal) 
        {
            customerDal.Add();
        }
    }

}
