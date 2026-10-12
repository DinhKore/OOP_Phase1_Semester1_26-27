using System;
using System.Collections.Generic;

// 1. LỚP CHA: Shape
public abstract class Shape
{
    public string Name;

    public Shape(string name)
    {
        Name = name;
    }

    // Phương thức trừu tượng tính diện tích
    public abstract double Area();
}

// 2. LỚP CON 1: Hình tròn (Circle)
public class Circle : Shape
{
    public double Radius; // Bán kính

    public Circle(string name, double radius) : base(name)
    {
        Radius = radius;
    }

    public override double Area()
    {
        // Diện tích = Pi * r * r (Math.PI ≈ 3.14159)
        return Math.PI * Radius * Radius;
    }
}

// 3. LỚP CON 2: Hình chữ nhật (Rectangle)
public class Rectangle : Shape
{
    public double Width;
    public double Height;

    public Rectangle(string name, double width, double height) : base(name)
    {
        Width = width;
        Height = height;
    }

    public override double Area()
    {
        return Width * Height;
    }
}

// 4. LỚP CON 3: Hình tam giác (Triangle)
public class Triangle : Shape
{
    public double BaseLength; // Đáy
    public double Height;     // Chiều cao

    public Triangle(string name, double baseLength, double height) : base(name)
    {
        BaseLength = baseLength;
        Height = height;
    }

    public override double Area()
    {
        // Diện tích = 1/2 * đáy * cao
        return 0.5 * BaseLength * Height;
    }
}

// 5. BỘ QUẢN LÝ: ShapeManager (Tương đương PayrollProcessor)
public class ShapeManager
{
    public List<Shape> shapeList = new List<Shape>();

    public void AddShape(Shape shape)
    {
        shapeList.Add(shape);
    }

    public void PrintAllAreas()
    {
        double totalArea = 0;

        Console.WriteLine("\n--- DANH SACH DIEN TICH CAC HINH ---");
        foreach (Shape s in shapeList)
        {
            double area = s.Area();
            Console.WriteLine("Hinh: " + s.Name + " | Dien tich: " + Math.Round(area, 2));
            totalArea = totalArea + area;
        }

        Console.WriteLine("------------------------------------");
        Console.WriteLine("TONG DIEN TICH: " + Math.Round(totalArea, 2));
    }
}