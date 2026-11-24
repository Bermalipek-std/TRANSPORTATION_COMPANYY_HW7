using System;

enum FuelType
{
    Petrol,
    Diesel,
    Electric
}

class Vehicle
{
    public string Brand { get; }
    public string Model { get; }
    public int Year { get; }
    public FuelType Fuel { get; }

    public static int Count = 0;

    public Vehicle(string brand, string model, int year, FuelType fuel)
    {
        Brand = brand;
        Model = model;
        Year = year;
        Fuel = fuel;
        Count++;
    }

    public virtual void StartEngine()
    {
        Console.WriteLine("The vehicle engine starts.");
    }

    public string Info()
    {
        return $"{Brand} {Model} ({Year}, {Fuel})";
    }
}

class Car : Vehicle
{
    public Car(string brand, string model, int year, FuelType fuel)
        : base(brand, model, year, fuel)
    {
    }

    public override void StartEngine()
    {
        Console.WriteLine("The car is ready to drive.");
    }
}

class Truck : Vehicle
{
    public Truck(string brand, string model, int year, FuelType fuel)
        : base(brand, model, year, fuel)
    {
    }

    public override void StartEngine()
    {
        Console.WriteLine("The truck engine rumbles to life.");
    }
}

class Motorcycle : Vehicle
{
    public Motorcycle(string brand, string model, int year, FuelType fuel)
        : base(brand, model, year, fuel)
    {
    }

    public override void StartEngine()
    {
        Console.WriteLine("The motorcycle engine starts with a roar.");
    }
}

class Program
{
    static void Main()
    {
        Vehicle[] fleet =
        {
            new Car("Togg", "T10X", 2024, FuelType.Electric),
            new Truck("Volvo", "FH", 2023, FuelType.Diesel),
            new Motorcycle("Honda", "CBR500R", 2024, FuelType.Petrol)
        };

        foreach (Vehicle vehicle in fleet)
        {
            Console.WriteLine(vehicle.Info());
            vehicle.StartEngine();
            Console.WriteLine();
        }

        Console.WriteLine($"Total vehicles created: {Vehicle.Count}");
    }
}
