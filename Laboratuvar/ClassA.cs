using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratuvar
{
    class ClassA
    {
        public void Yaz1() 
        {
            Console.WriteLine("yaz1 çalıştı.");
        }
    }
    class classB 
    {
        public void  Yaz2()
        {
            Console.WriteLine("yaz2 çalıştı.");
        }
    }
                        
    interface IClassA   
    {
        void yaz1();
    }
    interface IClassB
    {
        void yaz2();
    }

    class ClassC : IClassA , IClassB
    {
        public void yaz1() 
        {
            Console.WriteLine("yaz 1 calisti.");
        }
        public void yaz2() 
        {
            Console.WriteLine("yaz 2 calisti.");
        }

    }
}
