using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== HE THONG QUAN LY HINH HOC (SHAPE SYSTEM) ===");

        ShapeManager manager = new ShapeManager();

        // Thêm các hình tròn, chữ nhật, tam giác
        manager.AddShape(new Circle("Hinh tron A", 3));          // Dien tich: ~28.27
        manager.AddShape(new Rectangle("Hinh chu nhat B", 4, 5)); // Dien tich: 20
        manager.AddShape(new Triangle("Hinh tam giac C", 6, 4));  // Dien tich: 12

        // In diện tích từng hình và tổng diện tích
        manager.PrintAllAreas();
    }
}