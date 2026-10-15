public class Cube extends SolidShape {
    private double side;

    public Cube(String name, double side) {
        // super() phải được gọi để truyền tham số lên hàm khởi tạo của lớp cha[cite: 8]
        super(name);
        this.side = side;
    }

    // Bắt buộc phải ghi đè hàm tính thể tích từ lớp abstract cha[cite: 9]
    // Sử dụng @Override để trình biên dịch kiểm tra lỗi chính tả hoặc sai chữ ký hàm[cite: 12]
    @Override
    public double calculateVolume() {
        return Math.pow(side, 3);
    }

    @Override
    public void displayInfo() {
        // Dùng super.displayInfo() để gọi lại phương thức in tên của lớp cha[cite: 8]
        super.displayInfo();
        System.out.println("Độ dài cạnh: " + side);
        System.out.printf("Thể tích: %.2f\n", calculateVolume());
    }
}