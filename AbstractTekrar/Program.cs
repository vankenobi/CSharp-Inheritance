using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractTekrar
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle car = new Toyota();
            Vehicle car2 = new Ford();
            Vehicle car3 = new Ferrari(250);


            car.Go();
            car2.Go();
            car3.Go();
            Console.ReadKey();
        }
    }
}
