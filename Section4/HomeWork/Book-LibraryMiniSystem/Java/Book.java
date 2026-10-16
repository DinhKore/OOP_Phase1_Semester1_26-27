public class Book {
    // 1. Private fields
    private String title;
    private String author;
    private String isbn;
    private double price;

    // 2. Constructor
    public Book(String title, String author, String isbn, double price) {
        this.title = title;
        this.author = author;
        this.isbn = isbn;
        setPrice(price); // Gọi setter để áp dụng validation
    }

    // 3. Getters và Setters (Encapsulation)
    public String getTitle() {
        return title;
    }

    public void setTitle(String title) {
        this.title = title;
    }

    public String getAuthor() {
        return author;
    }

    public void setAuthor(String author) {
        this.author = author;
    }

    public String getIsbn() {
        return isbn;
    }

    public void setIsbn(String isbn) {
        this.isbn = isbn;
    }

    public double getPrice() {
        return price;
    }

    // Setter có Validation
    public void setPrice(double price) {
        if (price < 0) {
            throw new IllegalArgumentException("Price must not be negative.");
        }
        this.price = price;
    }
}

class Main {
    public static void main(String[] args) {
        // Khởi tạo 5 đối tượng Book
        Book b1 = new Book("Dac Nhan Tam", "Dale Carnegie", "111", 50000);
        Book b2 = new Book("Nha Gia Kim", "Paulo Coelho", "222", 65000);
        Book b3 = new Book("Tuoi Tre Dang Gia Bao Nhieu", "Rosie Nguyen", "333", 45000);
        Book b4 = new Book("Toi Thay Hoa Vang", "Nguyen Nhat Anh", "444", 55000);
        Book b5 = new Book("Harry Potter", "J.K. Rowling", "555", 120000);

        // In danh sách ra màn hình
        System.out.println("--- DANH SACH CUON SACH ---");
        System.out.println("1. Title: " + b1.getTitle() + ", Author: " + b1.getAuthor() + ", Price: " + b1.getPrice());
        System.out.println("2. Title: " + b2.getTitle() + ", Author: " + b2.getAuthor() + ", Price: " + b2.getPrice());
        System.out.println("3. Title: " + b3.getTitle() + ", Author: " + b3.getAuthor() + ", Price: " + b3.getPrice());
        System.out.println("4. Title: " + b4.getTitle() + ", Author: " + b4.getAuthor() + ", Price: " + b4.getPrice());
        System.out.println("5. Title: " + b5.getTitle() + ", Author: " + b5.getAuthor() + ", Price: " + b5.getPrice());
    }
}