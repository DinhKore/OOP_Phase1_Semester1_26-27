using System;

public class Rectangle
{
    // C# sử dụng Properties (đã học ở Bài 4) để lưu trữ dữ liệu
    public double Width { get; set; }
    public double Height { get; set; }

    // Yêu cầu 1: Constructor "Master" nhận 2 tham số[cite: 81, 94]
    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    // Yêu cầu 1: Constructor không tham số (mặc định 1x1). 
    // Dùng chaining : this(...) để gọi tới master[cite: 81, 94]
    public Rectangle() : this(1, 1) { }

    // Yêu cầu 1: Constructor 1 tham số tạo hình vuông (width = height = side)[cite: 81, 94]
    public Rectangle(double side) : this(side, side) { }

    // Yêu cầu 2: Thêm phương thức tính diện tích[cite: 81, 94]
    public double GetArea()
    {
        return Width * Height;
    }

    // Yêu cầu 2: Thêm phương thức tính chu vi[cite: 81, 94]
    public double GetPerimeter()
    {
        return 2 * (Width + Height);
    }

    // Yêu cầu 3: Ghi đè ToString để in ra tóm tắt[cite: 81, 94]
    public override string ToString()
    {
        return $"Rectangle [{Width}x{Height}] - Area: {GetArea():F2}, Perimeter: {GetPerimeter():F2}";
    }
    public Rectangle(Rectangle other)
    {
        this.Width = other.Width;
        this.Height = other.Height;
    }

    // Thêm một hàm setter để lát nữa có thể thử thay đổi dữ liệu bản copy
    public void setWidth(double width)
    {
        this.Width = width;
    }
}

public class Program
{
    public static void Main()
    {
        // Yêu cầu 4: Khởi tạo ít nhất 4 hình chữ nhật bằng các constructor khác nhau[cite: 81, 94]
        Rectangle r1 = new Rectangle();             // Dùng constructor không tham số (1x1)
        Rectangle r2 = new Rectangle(4.5, 5.0);       // Dùng constructor 2 tham số
        Rectangle r3 = new Rectangle(3.0);            // Dùng constructor 1 tham số (hình vuông 3x3)
        Rectangle r4 = new Rectangle(10.0, 2.5);      // Dùng constructor 2 tham số

        // In ra thông tin từng hình chữ nhật (Tự động gọi ToString())[cite: 81, 94]
        Console.WriteLine(r1);
        Console.WriteLine(r2);
        Console.WriteLine(r3);
        Console.WriteLine(r4);


        // Yêu cầu 2: Chứng minh việc sửa bản sao (copy) KHÔNG ảnh hưởng bản gốc (original)[cite: 83]
        System.Console.WriteLine("--- Test Copy Constructor ---");
        Rectangle original = new Rectangle(5.0, 10.0);

        // Sử dụng copy-constructor để tạo ra bản sao[cite: 83]
        Rectangle copy = new Rectangle(original);

        // Thử thay đổi thuộc tính của bản copy[cite: 83]
        copy.setWidth(99.9);

        // In ra để chứng minh bản gốc không bị ảnh hưởng[cite: 83]
        System.Console.WriteLine("Original: " + original);
        System.Console.WriteLine("Copy: " + copy);

    }
}