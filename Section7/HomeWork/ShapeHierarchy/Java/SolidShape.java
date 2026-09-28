public class SolidShape {
    protected String name;

    // Constructor lớp cha
    public SolidShape(String name) {
        this.name = name;
    }

    public double calculateVolume() {
        return 0.0;
    }

    // Phương thức in dùng chung
    public void displayInfo() {
        System.out.println("Tên hình: " + name);
    }
}