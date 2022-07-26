namespace NameHidden
{
    internal class Program 
    {
        static void Main(string[] args)
        {
           // There is "Write the console method" in two class. both same.
           // But it will run in child class  
           B b = new B();
           b.WriteTheConsole();
        }
    }
}

class A
{
    public void WriteTheConsole()
    {
        Console.WriteLine("Class A");
    }
}

class B : A
{
    public void WriteTheConsole()
    {
        Console.WriteLine("Class B");
    }
}

