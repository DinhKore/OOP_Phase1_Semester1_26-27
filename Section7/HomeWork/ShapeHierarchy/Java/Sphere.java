public class Sphere extends SolidShape {
    private double radius;

    // Constructor chaining với super(name)
    public Sphere(String name, double radius) {
        super(name);
        this.radius = radius;
    }

    @Override
    public double calculateVolume() {
        return (4.0 / 3.0) * Math.PI * Math.pow(radius, 3);
    }

    @Override
    public void displayInfo() {
        // Gọi phương thức của lớp cha
        super.displayInfo();
        System.out.println("Bán kính: " + radius);
        System.out.printf("Thể tích: %.2f\n", calculateVolume());
    }
}