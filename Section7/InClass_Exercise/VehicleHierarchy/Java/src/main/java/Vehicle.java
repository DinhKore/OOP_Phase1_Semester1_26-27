public class Vehicle {
    protected String make;
    protected String model;
    protected int year;

    public Vehicle(String make, String model, int year) {
        this.make = make;
        this.model = model;
        this.year = year;
    }

    public void printInfo() {
        System.out.println("Vehicle: " + year + " " + make + " " + model);
    }

    // Hàm main để chạy thử chương trình được đặt luôn tại đây
    public static void main(String[] args) {
        Car myCar = new Car("Toyota", "Camry", 2022, 4);
        myCar.describe();

        System.out.println("----------------");

        Motorbike myBike = new Motorbike("Honda", "CBR1000RR", 2023, false);
        myBike.describe();
    }
}