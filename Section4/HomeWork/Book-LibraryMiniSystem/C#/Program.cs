using System;

public class Book
{
    // 1. Private fields
    private string title;
    private string author;
    private string isbn;
    private double price;

    // 2. Constructor cơ bản
    public Book(string title, string author, string isbn, double price)
    {
        this.title = title;
        this.author = author;
        this.isbn = isbn;
        this.price = price; // Gọi qua Property để áp dụng luôn logic kiểm tra
    }

    // 3. Properties (Encapsulation)
    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    public string Author
    {
        get { return author; }
        set { author = value; }
    }

    public string Isbn
    {
        get { return isbn; }
        set { isbn = value; }
    }

    // Property có Validation (kiểm tra điều kiện)
    public double Price
    {
        get { return price; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Price must not be negative."); // Báo lỗi nếu giá âm
            }
            price = value;
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Khởi tạo 5 đối tượng Book với các dữ liệu khác nhau
        Book b1 = new Book("Dac Nhan Tam", "Dale Carnegie", "111", 50000);
        Book b2 = new Book("Nha Gia Kim", "Paulo Coelho", "222", 65000);
        Book b3 = new Book("Tuoi Tre Dang Gia Bao Nhieu", "Rosie Nguyen", "333", 45000);
        Book b4 = new Book("Toi Thay Hoa Vang", "Nguyen Nhat Anh", "444", 55000);
        Book b5 = new Book("Harry Potter", "J.K. Rowling", "555", 120000);

        // In danh sách ra màn hình theo phương pháp thủ công
        Console.WriteLine("--- DANH SACH CUON SACH ---");
        Console.WriteLine($"1. Title: {b1.Title}, Author: {b1.Author}, Price: {b1.Price}");
        Console.WriteLine($"2. Title: {b2.Title}, Author: {b2.Author}, Price: {b2.Price}");
        Console.WriteLine($"3. Title: {b3.Title}, Author: {b3.Author}, Price: {b3.Price}");
        Console.WriteLine($"4. Title: {b4.Title}, Author: {b4.Author}, Price: {b4.Price}");
        Console.WriteLine($"5. Title: {b5.Title}, Author: {b5.Author}, Price: {b5.Price}");
    }
}