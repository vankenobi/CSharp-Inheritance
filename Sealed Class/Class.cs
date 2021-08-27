using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed_Class
{

    // Sealed classtan nesne oluşturulabilir.
    sealed class SealedClass
    {
        public int age { get; set; }
        public string sex { get; set; }
    }

    class Printer 
    {
        public virtual void Print() 
        {
            Console.WriteLine("Printer çalıştı.");
        }

        public virtual void Show()
        {
            Console.WriteLine("printer gösterici çalıştı.");
        }
    }

    class LazerPrinter : Printer
    {
        sealed public override void Print() // sealed override metodu ile bu metod sadece bu sınıftan oluşturulan nesneler
                                            // için kullanılır.
        {
            Console.WriteLine("Lazer Printer sealed metod çalıştı.");
        }

        public override void Show()
        {
            Console.WriteLine("Lazer printer gösterici çalıştı.");
        }
    }

    class ThreeDPrinter : LazerPrinter
    {

        public override void Show()
        {
            Console.WriteLine("3D printer gösterici çalıştı.");
        }
    }


    /*
    class Person : SealedClass  sealed class herhangi bir sınıfa kalıtım veremez. (Hatalı)
    {
    }
    */



}
