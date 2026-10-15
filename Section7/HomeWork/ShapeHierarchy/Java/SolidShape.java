public abstract class SolidShape {
    // Sử dụng protected để các lớp con (Cube, Sphere) có thể truy cập trực tiếp
    protected String name;

    // Hàm khởi tạo của lớp cha
    public SolidShape(String name) {
        this.name = name;
    }

    // Abstract method: chỉ có chữ ký hàm, bắt buộc các lớp con phải tự ghi đè (override)
    public abstract double calculateVolume();

    // Phương thức chung cho tất cả các hình[cite: 9]
    public void displayInfo() {
        System.out.println("Tên hình: " + name);
    }
}