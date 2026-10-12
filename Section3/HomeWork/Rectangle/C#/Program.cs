using System;

class Program
{
    static void Main(string[] args)
    {
        Rectangle rect1 = new Rectangle(5, 3);
        Rectangle rect2 = new Rectangle(10, 4);

        Console.WriteLine("Hinh 1 - Dien tich: " + rect1.GetArea() + " - Chu vi: " + rect1.GetPerimeter());
        Console.WriteLine("Hinh 2 - Dien tich: " + rect2.GetArea() + " - Chu vi: " + rect2.GetPerimeter());
    }
}