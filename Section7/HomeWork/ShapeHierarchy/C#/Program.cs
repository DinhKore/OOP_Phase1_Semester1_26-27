using System;

// 1. Base Class: SolidShape (Lớp cơ sở)
public class SolidShape
{
    protected string Name;

    // Constructor của lớp cha
    public SolidShape(string name)
    {
        Name = name;
    }

    // Phương thức tính thể tích cơ sở
    public virtual double CalculateVolume()
    {
        return 0.0;
    }

    // Phương thức in thông tin chung của lớp cha
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Tên hình: {Name}");
    }
}

// 2. Derived Class 1: Cube (Hình lập phương)
public class Cube : SolidShape
{
    private double _side;

    // Constructor chaining với base(name)
    public Cube(string name, double side) : base(name)
    {
        _side = side;
    }

    public override double CalculateVolume()
    {
        return Math.Pow(_side, 3);
    }

    public override void DisplayInfo()
    {
        // Gọi lại phương thức của lớp cha
        base.DisplayInfo();
        Console.WriteLine($"Độ dài cạnh: {_side}");
        Console.WriteLine($"Thể tích: {CalculateVolume():F2}");
    }
}

// 3. Derived Class 2: Sphere (Hình cầu)
public class Sphere : SolidShape
{
    private double _radius;

    // Constructor chaining với base(name)
    public Sphere(string name, double radius) : base(name)
    {
        _radius = radius;
    }

    public override double CalculateVolume()
    {
        return (4.0 / 3.0) * Math.PI * Math.Pow(_radius, 3);
    }

    public override void DisplayInfo()
    {
        // Gọi lại phương thức của lớp cha
        base.DisplayInfo();
        Console.WriteLine($"Bán kính: {_radius}");
        Console.WriteLine($"Thể tích: {CalculateVolume():F2}");
    }
}

// Driver program
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== THỰC THI HỆ THỐNG HÌNH KHỐI 3D (C#) ===");
        
        Cube cube = new Cube("Khối Rubik 3x3", 3.0);
        cube.DisplayInfo();

        Console.WriteLine("------------------------------------------");

        Sphere sphere = new Sphere("Quả bóng đá", 5.0);
        sphere.DisplayInfo();
    }
}