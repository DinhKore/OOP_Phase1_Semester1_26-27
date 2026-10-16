import java.util.ArrayList;
import java.util.List;
public class Main {
    public static void main(String[] args) {
        // Khởi tạo ít nhất 5 đối tượng Book khác nhau
        List<Book> library = new ArrayList<>();
        library.add(new Book("Clean Code", "Robert C. Martin", "978-0132350884", 32.00));
        library.add(new Book("The Pragmatic Programmer", "Andrew Hunt", "978-0135957059", 28.75));
        library.add(new Book("Design Patterns", "Erich Gamma", "978-0201633610", 45.50));
        library.add(new Book("Refactoring", "Martin Fowler", "978-0134757599", 35.00));
        library.add(new Book("Free E-book", "Unknown Author", "000-0000000000", 0.0)); // Giá bằng 0 hợp lệ

        // In danh sách sách đã định dạng
        System.out.println("--- DANH SÁCH THƯ VIỆN SÁCH ---");
        for (Book b : library) {
            System.out.printf("Title: %s | Author: %s | Price: $%.2f%n", 
                              b.getTitle(), b.getAuthor(), b.getPrice());
        }
    }
}