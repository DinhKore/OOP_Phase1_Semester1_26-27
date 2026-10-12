using System;

class Program
{
    static void Main(string[] args)
    {
        // Đúng theo đề bài kiểm tra: (1, 2) + (3, 4)
        Vector2D v1 = new Vector2D(1, 2);
        Vector2D v2 = new Vector2D(3, 4);

        Vector2D ketQuaCong = v1 + v2;
        Console.WriteLine("v1 + v2 = " + ketQuaCong); 

        Vector2D ketQuaTru = v1 - v2;
        Console.WriteLine("v1 - v2 = " + ketQuaTru);  

        // Kiểm tra so sánh bằng
        Vector2D v3 = new Vector2D(1, 2);
        Console.WriteLine("v1 == v3: " + (v1 == v3)); //true
    }
}