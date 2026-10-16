public class Program
{
    public static void Main()
    {
        // Khởi tạo ít nhất 5 đối tượng Book khác nhau
        List<Book> library = new List<Book>
        {
            new Book("Clean Code", "Robert C. Martin", "978-0132350884", 32.00),
            new Book("The Pragmatic Programmer", "Andrew Hunt", "978-0135957059", 28.75),
            new Book("Design Patterns", "Erich Gamma", "978-0201633610", 45.50),
            new Book("Refactoring", "Martin Fowler", "978-0134757599", 35.00),
            new Book("Free E-book", "Unknown Author", "000-0000000000", 0.0) // Giá bằng 0 hợp lệ
        };

        // In danh sách sách đã định dạng
        Console.WriteLine("--- DANH SÁCH THƯ VIỆN SÁCH ---");
        foreach (Book b in library)
        {
            Console.WriteLine($"Title: {b.Title} | Author: {b.Author} | Price: ${b.Price:F2}");
        }
    }
}