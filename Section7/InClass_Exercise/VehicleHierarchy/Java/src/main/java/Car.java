public class Car extends Vehicle {
    private int numDoors;

    public Car(String make, String model, int year, int numDoors) {
        super(make, model, year); // Gọi constructor của lớp cha (Vehicle)
        this.numDoors = numDoors;
    }

    public void describe() {
        printInfo(); // Gọi phương thức của lớp cha
        System.out.println("Number of doors: " + numDoors);
    }
}