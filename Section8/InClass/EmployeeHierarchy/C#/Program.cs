using System;

class Program
{
    static void Main(string[] args)
    {
        // THỬ NGHIỆM ĐỀ BÀI YÊU CẦU:
        // Bỏ comment dòng dưới đây sẽ gây lỗi biên dịch (Compile Error: CS0144)
        // Employee emp = new Employee("Test", 1000);

        Console.WriteLine("=== THỰC THI QUẢN LÝ LƯƠNG NHÂN VIÊN (C#) ===");

        Employee manager = new Manager("Nguyễn Văn Quản Lý", 20000000, 5000000);
        manager.PrintPaySlip();

        Console.WriteLine("---------------------------------------------");

        Employee dev = new Developer("Trần Lập Trình", 15000000, 1200, 5000);
        dev.PrintPaySlip();
    }
}
