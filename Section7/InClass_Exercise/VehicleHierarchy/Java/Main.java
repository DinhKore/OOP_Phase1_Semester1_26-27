public class Main {
    public static void main(String[] args) {
        // Tạo đối tượng Car
        Car myCar = new Car("Toyota", "Camry", 2022, 4);
        myCar.describe();

        System.out.println("----------------");

        // Tạo đối tượng Motorbike
        Motorbike myBike = new Motorbike("Honda", "CBR1000RR", 2023, false);
        myBike.describe();
    }
}