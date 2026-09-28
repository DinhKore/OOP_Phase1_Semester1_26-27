public class Motorbike extends Vehicle {
    private boolean hasSidecar;

    public Motorbike(String make, String model, int year, boolean hasSidecar) {
        super(make, model, year); // Gọi constructor của lớp cha (Vehicle)
        this.hasSidecar = hasSidecar;
    }

    public void describe() {
        printInfo(); // Gọi phương thức của lớp cha
        System.out.println("Has sidecar: " + hasSidecar);
    }
}