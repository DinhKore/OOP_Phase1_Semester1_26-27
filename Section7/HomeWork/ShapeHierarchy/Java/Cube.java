public class Cube extends SolidShape {
    private double side;

    // Constructor chaining với super(name)
    public Cube(String name, double side) {
        super(name);
        this.side = side;
    }

    @Override
    public double calculateVolume() {
        return Math.pow(side, 3);
    }

    @Override
    public void displayInfo() {
        // Gọi phương thức của lớp cha
        super.displayInfo();
        System.out.println("Độ dài cạnh: " + side);
        System.out.printf("Thể tích: %.2f\n", calculateVolume());
    }
}