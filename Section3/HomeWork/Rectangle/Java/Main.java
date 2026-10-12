public class Main {
    public static void main(String[] args) {
        Rectangle rect1 = new Rectangle(5, 3);
        Rectangle rect2 = new Rectangle(10, 4);

        System.out.println("Hinh 1 - Dien tich: " + rect1.getArea() + " - Chu vi: " + rect1.getPerimeter());
        System.out.println("Hinh 2 - Dien tich: " + rect2.getArea() + " - Chu vi: " + rect2.getPerimeter());
    }
}