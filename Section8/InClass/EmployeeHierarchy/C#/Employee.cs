using System;

// 1. Abstract Base Class
public abstract class Employee
{
    protected string Name;
    protected double BaseSalary;

    public Employee(string name, double baseSalary)
    {
        Name = name;
        BaseSalary = baseSalary;
    }

    // Abstract method: Bắt buộc các lớp con phải tự triển khai
    public abstract double CalculateSalary();

    // Concrete method: Template method in phiếu lương
    public void PrintPaySlip()
    {
        Console.WriteLine($"Nhân viên   : {Name}");
        Console.WriteLine($"Lương cơ bản: {BaseSalary:N0} VND");
        Console.WriteLine($"Tổng nhận   : {CalculateSalary():N0} VND");
    }
}

// 2. Manager
public class Manager : Employee
{
    private double _teamBonus;

    public Manager(string name, double baseSalary, double teamBonus) 
        : base(name, baseSalary)
    {
        _teamBonus = teamBonus;
    }

    public override double CalculateSalary()
    {
        return BaseSalary + _teamBonus;
    }
}

// 3. Developer
public class Developer : Employee
{
    private int _linesShipped;
    private double _ratePerLine;

    public Developer(string name, double baseSalary, int linesShipped, double ratePerLine) 
        : base(name, baseSalary)
    {
        _linesShipped = linesShipped;
        _ratePerLine = ratePerLine;
    }

    public override double CalculateSalary()
    {
        return BaseSalary + (_linesShipped * _ratePerLine);
    }
}