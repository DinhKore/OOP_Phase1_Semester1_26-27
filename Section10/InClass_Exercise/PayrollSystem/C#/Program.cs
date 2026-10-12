using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== HE THONG TINH LUONG (PAYROLL SYSTEM) ===");

        PayrollProcessor processor = new PayrollProcessor();

        // 1. Thêm 5 nhân viên thuộc các loại khác nhau
        processor.AddEmployee(new SalariedEmployee("Nguyen Van A", 1500));
        processor.AddEmployee(new SalariedEmployee("Tran Thi B", 2000));
        processor.AddEmployee(new HourlyEmployee("Le Van C", 20, 80));      // 20$/h, lam 80h = 1600
        processor.AddEmployee(new HourlyEmployee("Pham Thi D", 25, 40));     // 25$/h, lam 40h = 1000
        processor.AddEmployee(new CommissionEmployee("Hoang Van E", 50000, 0.05)); // Doanh so 50000, hoa hong 5% = 2500

        // 2. Chạy thử nghiệm validation: Cố tình nhập giá trị âm
        Console.WriteLine("\n--- KIEM TRA NHAP LIEU SAI (VALIDATION TEST) ---");
        Employee invalidEmp = new HourlyEmployee("Nhan Vien Test Loi", -10, 50);
        processor.AddEmployee(invalidEmp);

        // 3. In phiếu lương và tổng tiền lương
        processor.ProcessPayroll();
    }
}