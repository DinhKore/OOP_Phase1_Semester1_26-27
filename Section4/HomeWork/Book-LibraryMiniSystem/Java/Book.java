import java.util.ArrayList;
import java.util.List;

public class Book {
    // Private fields
    private String title;
    private String author;
    private String isbn;
    private double price;

    // Constructor
    public Book(String title, String author, String isbn, double price) {
        this.setTitle(title);
        this.setAuthor(author);
        this.setIsbn(isbn);
        this.setPrice(price); // Gọi qua setter để kích hoạt validation
    }

    // Getters & Setters
    public String getTitle() { return title; }
    public void setTitle(String title) { this.title = title; }

    public String getAuthor() { return author; }
    public void setAuthor(String author) { this.author = author; }

    public String getIsbn() { return isbn; }
    public void setIsbn(String isbn) { this.isbn = isbn; }

    public double getPrice() { return price; }
    
    // Setter có validation
    public void setPrice(double price) {
        if (price < 0) {
            throw new IllegalArgumentException("Giá (Price) không được là số âm.");
        }
        this.price = price;
    }
}
