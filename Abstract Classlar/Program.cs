using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Database sqlserver = new SqlServer();
            Database oracleserver = new OracleServer();

            sqlserver.Delete();
            sqlserver.Add();
            oracleserver.Delete();
            oracleserver.Add();
            Console.ReadKey();
        }
    }

    abstract class Database
    {
        public void Add()
        {
            Console.WriteLine("Added by default");
        }

        public abstract void Delete();  // Abstract Delete metod tanımlandı. Ve bu sınıftan kalıtım alınarak SqlServer ve OracleServer sınıflarında override metodları yazıldı. 
    }

    class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by SqlServer");
        }
    }

    class OracleServer : Database
    {
        public override void Delete()
        {
            Console.Write("Deleted by Oracle");
        }
    }
}
