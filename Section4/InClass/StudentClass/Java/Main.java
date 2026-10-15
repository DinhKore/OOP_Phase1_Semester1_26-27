public class Main {
    public static void main(String[] args) {
        Student student1 = new Student("Nguyen Van A", 101, 3.5);
        Student student2 = new Student("Tran Thi B", 102, 4.0);
        Student student3 = new Student("Le Van C", 103, 2.8);

        System.out.println(student1.toString());
        System.out.println(student2.toString());
        System.out.println(student3.toString());
    }
}