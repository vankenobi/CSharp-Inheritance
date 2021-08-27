using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sealed class ile abstract class arasındaki fark:

            // * Sealed class kendisinden nesne türetebilir fakat kalıtım veremez.
            // * Abstract class kendisinde nesne türetemez fakat kalıtım verir.
            SealedClass person = new SealedClass(); 
            person.age = 22;
            person.sex = "Male";


            // *******************************************************************

            Printer lazerPrint = new LazerPrinter();
            Printer threeDPrinter = new ThreeDPrinter();

            lazerPrint.Print();
            lazerPrint.Show();

            threeDPrinter.Print(); // ThreeDPrinter sınıfı LazerPrinter sınıfından kalıtım aldığı için ve print metodu sealed etikete sahip
                                   // olduğu için override edilemez ve sadece lazerprint sınıfının nesneleri tarafından kullanılır.
            threeDPrinter.Show();

            Console.ReadKey();
        }
    }
}
