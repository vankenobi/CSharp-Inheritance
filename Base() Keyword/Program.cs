using System;

namespace BaseKeyword
{
    internal class Program 
    {
        static void Main() 
        {
            // Using base() keyword we can access and use 
            Car car = new("Audi");
            Console.WriteLine(car.GetBrandOfVehicle);
        }
    }
}

class Vehicle 
{
    private string brand;
    public Vehicle(string brand)
    {
        this.brand = brand;
    }

    public string GetBrandOfVehicle { 
        get { return this.brand; } 
    }
}

class Car : Vehicle
{
    public Car(string brand) : base(brand)
    {

    }
}