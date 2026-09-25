class Program
{
    static void Main(string[] args)
    {
        Car myCar = new Car("Toyota", "Camry", 2022, 4);
        myCar.Describe();

        Console.WriteLine("----------------");

        Motorbike myBike = new Motorbike("Honda", "CBR1000RR", 2023, false);
        myBike.Describe();
    }
}