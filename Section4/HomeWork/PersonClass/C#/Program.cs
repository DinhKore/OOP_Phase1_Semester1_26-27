using System;

public class Person
{
    // 1. Private fields (Dữ liệu nội bộ)
    private string name = "";
    private int age;
    private string email = "";

    // 2. Constructor
    public Person(string name, int age, string email)
    {
        // Gán qua Properties để bắt buộc chạy logic kiểm tra (validation)
        this.name = name;
        this.age = age;
        this.email = email;
    }

    // 3. Properties (Đóng gói và Kiểm tra)
    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Name cannot be empty."); // Lỗi nếu tên rỗng
            }
            name = value;
        }
    }

    public int Age
    {
        get { return age; }
        set
        {
            if (value < 0 || value > 150)
            {
                throw new ArgumentException("Age must be between 0 and 150."); // Lỗi nếu tuổi sai
            }
            age = value;
        }
    }

    public string Email
    {
        get { return email; }
        set
        {
            if (!value.Contains("@"))
            {
                throw new ArgumentException("Email must contain '@'."); // Lỗi nếu thiếu @
            }
            email = value;
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("--- TEST VALID VALUES ---");
        try
        {
            // Khởi tạo đối tượng hợp lệ
            Person p1 = new Person("Han Minh Dinh", 22, "dinh@student.university.vn");
            Console.WriteLine($"Thanh cong: {p1.Name}, {p1.Age}, {p1.Email}");
        }
        catch (ArgumentException e)
        {
            Console.WriteLine($"Loi: {e.Message}");
        }

        Console.WriteLine("\n--- TEST INVALID NAME ---");
        try
        {
            Person p2 = new Person("", 25, "test@mail.com"); // Cố tình để tên rỗng
        }
        catch (ArgumentException e)
        {
            Console.WriteLine($"Da bat duoc loi Name: {e.Message}");
        }

        Console.WriteLine("\n--- TEST INVALID AGE ---");
        try
        {
            Person p3 = new Person("Nguyen Van A", 200, "a@mail.com"); // Cố tình để tuổi > 150
        }
        catch (ArgumentException e)
        {
            Console.WriteLine($"Da bat duoc loi Age: {e.Message}");
        }

        Console.WriteLine("\n--- TEST INVALID EMAIL ---");
        try
        {
            Person p4 = new Person("Tran Van B", 30, "bmail.com"); // Cố tình thiếu chữ @
        }
        catch (ArgumentException e)
        {
            Console.WriteLine($"Da bat duoc loi Email: {e.Message}");
        }
    }
}