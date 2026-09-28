public class Main {
    public static void main(String[] args) {
        System.out.println("=== THỰC THI HỆ THỐNG HÌNH KHỐI 3D (JAVA) ===");

        Cube cube = new Cube("Khối Rubik 3x3", 3.0);
        cube.displayInfo();

        System.out.println("------------------------------------------");

        Sphere sphere = new Sphere("Quả bóng đá", 5.0);
        sphere.displayInfo();
    }
}