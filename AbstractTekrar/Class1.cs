using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractTekrar
{
    // Araç adında abstract sınıfı oluşturuldu.
    // Abstract türündeki sınıf içerisine abstract metod eklendi.
    abstract class Vehicle
    {
        abstract public void Go();
    }

    class Toyota : Vehicle
    {
        public override void Go()   // kalıtım alınan abstract türündeki sınfın abstract metodu override edildi.
        {
            Console.WriteLine("Toyota run");
        } 
    }

    class Ford : Vehicle 
    {
        public override void Go()   
        {
            Console.WriteLine("Ford Go");
        }
    }

    class Ferrari : Vehicle 
    {
        private int Speed;

        public Ferrari(int value = 0) 
        {
            Speed = value;
        }

        public override void Go()
        {
            Console.WriteLine("Ferrari Run with" + Speed);
        }
    }
}
