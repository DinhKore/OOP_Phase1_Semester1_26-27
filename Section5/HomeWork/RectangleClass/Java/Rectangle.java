public class Rectangle {
    // Java sử dụng private fields (đã học ở Bài 4)
    private double width;
    private double height;

    // Yêu cầu 1: Constructor "Master" nhận 2 tham số[cite: 81, 94]
    public Rectangle(double width, double height) {
        this.width = width;
        this.height = height;
    }

    // Yêu cầu 1: Constructor không tham số (mặc định 1x1).
    // Dùng chaining this(...) và phải là lệnh đầu tiên trong body[cite: 81, 94]
    public Rectangle() {
        this(1, 1);
    }

    // Yêu cầu 1: Constructor 1 tham số tạo hình vuông[cite: 81, 94]
    public Rectangle(double side) {
        this(side, side);
    }

    // Yêu cầu 2: Thêm phương thức tính diện tích[cite: 81, 94]
    public double getArea() {
        return width * height;
    }

    // Yêu cầu 2: Thêm phương thức tính chu vi[cite: 81, 94]
    public double getPerimeter() {
        return 2 * (width + height);
    }

    // Yêu cầu 3: Ghi đè toString để in ra tóm tắt[cite: 81, 94]
    @Override
    public String toString() {
        return String.format("Rectangle [%.1fx%.1f] - Area: %.2f, Perimeter: %.2f",
                width, height, getArea(), getPerimeter());
    }

    public Rectangle(Rectangle other) {
        this.width = other.width;
        this.height = other.height;
    }

    // Thêm một hàm setter để lát nữa có thể thử thay đổi dữ liệu bản copy
    public void setWidth(double width) {
        this.width = width;
    }

    public static void main(String[] args) {
        // Yêu cầu 4: Khởi tạo ít nhất 4 hình chữ nhật bằng các constructor khác
        // nhau[cite: 81, 94]
        Rectangle r1 = new Rectangle(); // Constructor không tham số (1x1)
        Rectangle r2 = new Rectangle(4.5, 5.0); // Constructor 2 tham số
        Rectangle r3 = new Rectangle(3.0); // Constructor 1 tham số (hình vuông)
        Rectangle r4 = new Rectangle(10.0, 2.5); // Constructor 2 tham số

        // In ra thông tin từng hình chữ nhật (Tự động gọi toString())[cite: 81, 94]
        System.out.println(r1);
        System.out.println(r2);
        System.out.println(r3);
        System.out.println(r4);

        // Yêu cầu 2: Chứng minh việc sửa bản sao (copy) KHÔNG ảnh hưởng bản gốc
        // (original)[cite: 83]
        System.out.println("--- Test Copy Constructor ---");
        Rectangle original = new Rectangle(5.0, 10.0);

        // Sử dụng copy-constructor để tạo ra bản sao[cite: 83]
        Rectangle copy = new Rectangle(original);

        // Thử thay đổi thuộc tính của bản copy[cite: 83]
        copy.setWidth(99.9);

        // In ra để chứng minh bản gốc không bị ảnh hưởng[cite: 83]
        System.out.println("Original: " + original);
        System.out.println("Copy: " + copy);

    }
}