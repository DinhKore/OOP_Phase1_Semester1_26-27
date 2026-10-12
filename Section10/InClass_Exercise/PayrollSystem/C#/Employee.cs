using System;
using System.Collections.Generic;

// 1. LỚP CHA: Employee
public abstract class Employee
{
    public string Name;

    public Employee(string name)
    {
        Name = name;
    }

    public abstract double CalculateSalary();
}

// 2. LỚP CON 1: Nhân viên lương cố định
public class SalariedEmployee : Employee
{
    public double Salary;

    public SalariedEmployee(string name, double salary) : base(name)
    {
        // Kiểm tra validation: lương không được âm
        if (salary < 0)
        {
            Console.WriteLine("[Lỗi] Lương của " + name + " không được âm! Gán về 0.");
            Salary = 0;
        }
        else
        {
            Salary = salary;
        }
    }

    public override double CalculateSalary()
    {
        return Salary;
    }
}

// 3. LỚP CON 2: Nhân viên theo giờ
public class HourlyEmployee : Employee
{
    public double Wage; // Tiền mỗi giờ
    public double Hours; // Số giờ làm

    public HourlyEmployee(string name, double wage, double hours) : base(name)
    {
        if (wage < 0 || hours < 0)
        {
            Console.WriteLine("[Lỗi] Giờ hoặc tiền công của " + name + " không được âm! Gán về 0.");
            Wage = 0;
            Hours = 0;
        }
        else
        {
            Wage = wage;
            Hours = hours;
        }
    }

    public override double CalculateSalary()
    {
        return Wage * Hours;
    }
}

// 4. LỚP CON 3: Nhân viên hưởng hoa hồng
public class CommissionEmployee : Employee
{
    public double Sales;          // Doanh số bán hàng
    public double CommissionRate; // Tỷ lệ hoa hồng (ví dụ: 0.1 là 10%)

    public CommissionEmployee(string name, double sales, double commissionRate) : base(name)
    {
        if (sales < 0 || commissionRate < 0)
        {
            Console.WriteLine("[Lỗi] Doanh số hoặc hoa hồng của " + name + " không được âm! Gán về 0.");
            Sales = 0;
            CommissionRate = 0;
        }
        else
        {
            Sales = sales;
            CommissionRate = commissionRate;
        }
    }

    public override double CalculateSalary()
    {
        return Sales * CommissionRate;
    }
}

// 5. BỘ XỬ LÝ BẢNG LƯƠNG: PayrollProcessor
public class PayrollProcessor
{
    // Danh sách lưu nhân viên
    public List<Employee> employeeList = new List<Employee>();

    public void AddEmployee(Employee emp)
    {
        employeeList.Add(emp);
    }

    public void ProcessPayroll()
    {
        double totalPayroll = 0;

        Console.WriteLine("\n--- PHIEU LUONG NHAN VIEN ---");
        foreach (Employee emp in employeeList)
        {
            double salary = emp.CalculateSalary();
            Console.WriteLine("Nhan vien: " + emp.Name + " | Luong: " + salary);
            totalPayroll = totalPayroll + salary;
        }

        Console.WriteLine("-----------------------------");
        Console.WriteLine("TONG TIEN LUONG TOAN CONG TY: " + totalPayroll);
    }
}