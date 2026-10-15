public class Program
{
    public static void Main()
    {
        // Khởi tạo 3 objects sinh viên với dữ liệu khác nhau
        Student student1 = new Student("Nguyen Van A", 101, 3.5);
        Student student2 = new Student("Tran Thi B", 102, 4.0);
        Student student3 = new Student("Le Van C", 103, 2.8);

        // In chi tiết từng object ra console
        Console.WriteLine(student1.ToString());
        Console.WriteLine(student2.ToString());
        Console.WriteLine(student3.ToString());
    }
}