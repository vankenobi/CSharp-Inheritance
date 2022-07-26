using System;

namespace Polimorphism 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // You can show if you write "b.". You will access just the two method X and Y. 
            B b = new C();
            // b.
        }   
    }
}

class A
{
    public void X() { }
}
class B : A
{
    public void Y() { }
}
class C : B
{
    public void Z() { }
}