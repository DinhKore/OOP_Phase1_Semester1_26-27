using System;

public class Vehicle
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    public Vehicle(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Vehicle: {Year} {Make} {Model}");
    }
}

public class Car : Vehicle
{
    public int NumDoors { get; set; }

    public Car(string make, string model, int year, int numDoors) : base(make, model, year)
    {
        NumDoors = numDoors;
    }

    public void Describe()
    {
        PrintInfo();
        Console.WriteLine($"Number of doors: {NumDoors}");
    }
}

public class Motorbike : Vehicle
{
    public bool HasSidecar { get; set; }

    public Motorbike(string make, string model, int year, bool hasSidecar) : base(make, model, year)
    {
        HasSidecar = hasSidecar;
    }

    public void Describe()
    {
        PrintInfo();
        Console.WriteLine($"Has sidecar: {HasSidecar}");
    }
}

