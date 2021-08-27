using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlserver = new SqlServer();
            OracleServer oracleserver = new OracleServer();

            sqlserver.Add();
            oracleserver.Add();

            Console.ReadKey();
        }
    }

    class Database
    {
        public virtual void Add() // virtual metodları olan sınıftan kalıtım alındığı zaman o methodlar üzerine override yapılabilir.
        {                         // eğer kalıtımı alan sınıf override yapmaz ise virtual sınıfları olduğu gibi kullanabilir.  
            Console.WriteLine("Added");
        }
        public virtual void Delete() 
        {
            Console.WriteLine("Deleted"); 
        }
    }

    class SqlServer : Database 
    {
        public override void Add()
        {
            Console.WriteLine("Add metodu sqlserver için override edildi."); // hem özel kod çalıştırabilir.
            base.Add(); // hem de varsayılan kodu base kullanarak bu şekilde çalıştırabilirsiniz. 
        }
    }

    class OracleServer : Database 
    {
        
    }
}   
