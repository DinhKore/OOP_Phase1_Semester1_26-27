public class Main {
    public static void main(String[] args) {
        System.out.println("=== THUC THI QUAN LY LUONG (JAVA) ===");

        Employee manager = new Manager("Nguyen Van Quan Ly", 20000000, 5000000);
        manager.printPaySlip();

        System.out.println("-----------------------------------");

        Employee dev = new Developer("Tran Lap Trinh", 15000000, 1200, 5000);
        dev.printPaySlip();
    }
}