using System;

public class Student
{
    public string Name { get; set; }
    public int StudentId { get; set; }

    // Backing field và Full property cho Gpa để thêm validation
    private double gpa;
    public double Gpa
    {
        get { return gpa; }
        set
        {
            if (value < 0.0 || value > 4.0)
            {
                throw new ArgumentException("GPA không hợp lệ! Phải nằm trong khoảng từ 0.0 đến 4.0.");
            }
            gpa = value;
        }
    }

    // Constructor để khởi tạo dữ liệu nhanh
    public Student(string name, int studentId, double gpa)
    {
        Name = name;
        StudentId = studentId;
        Gpa = gpa; // Gọi qua property 'Gpa' thay vì field 'gpa' để kích hoạt validation
    }

    public override string ToString()
    {
        return $"ID: {StudentId} | Tên: {Name} | GPA: {Gpa}";
    }
}

