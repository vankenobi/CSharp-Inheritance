using System;

namespace Casting
{
    internal class MyApp 
    {
        static void Main() 
        {
            // We can convert with casting 
            C c = new C();
            B b = (B)c;
            b.WriteForB();
        }
    }
}

class A 
{
    public void WriteForA() 
    {
        Console.WriteLine("A");
    }
}

class B : A 
{
    public void WriteForB() 
    {
        Console.WriteLine("B");
    }
}

class C : B 
{
    public void WriteForC() 
    {
        Console.WriteLine("C");
    }
}