using System;
using System.Collections.Generic;

abstract class Vehicle
{
    public string Brand { get; set; }
    public int Speed { get; set; }

    public Vehicle(string brand, int speed)
    {
        Brand = brand;
        Speed = speed;
    }

    public abstract void Move();

    public virtual void Refill()
    {
        
    }
}

class Car : Vehicle
{
    public Car(string brand, int speed) : base(brand, speed) { }

    public override void Move()
    {
        Console.WriteLine($"Машина {Brand} їде зі швидкістю {Speed} км/год.");
    }

    public override void Refill()
    {
        Console.WriteLine($"Машина {Brand} заправляється.");
    }
}

class Bicycle : Vehicle
{
    public Bicycle(string brand, int speed) : base(brand, speed) { }

    public override void Move()
    {
        Console.WriteLine($"Велосипед {Brand} їде зі швидкістю {Speed} км/год.");
    }
}

class Airplane : Vehicle
{
    public Airplane(string brand, int speed) : base(brand, speed) { }

    public override void Move()
    {
        Console.WriteLine($"Літак {Brand} летить зі швидкістю {Speed} км/год.");
    }

    public override void Refill()
    {
        Console.WriteLine($"Літак {Brand} заправляється.");
    }
}

class Program
{
    static void Main()
    {
        List<Vehicle> vehicles = new List<Vehicle>
        {
            new Car("Skoda", 120),
            new Bicycle("Giant", 25),
            new Airplane("Boeing", 850)
        };

        foreach (Vehicle vehicle in vehicles)
        {
            vehicle.Move();
            vehicle.Refill(); 
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}
