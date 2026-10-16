public class Person {
    // 1. Private fields
    private String name = "";
    private int age;
    private String email = "";

    // 2. Constructor
    public Person(String name, int age, String email) {
        // Gọi thẳng Setter để kiểm tra điều kiện ngay khi khởi tạo
        setName(name);
        setAge(age);
        setEmail(email);
    }

    // 3. Getters & Setters (Đóng gói và Kiểm tra)
    public String getName() {
        return name;
    }

    public void setName(String name) {
        if (name == null || name.isEmpty()) {
            throw new IllegalArgumentException("Name cannot be empty."); // Lỗi nếu tên rỗng
        }
        this.name = name;
    }

    public int getAge() {
        return age;
    }

    public void setAge(int age) {
        if (age < 0 || age > 150) {
            throw new IllegalArgumentException("Age must be between 0 and 150."); // Lỗi nếu tuổi sai
        }
        this.age = age;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        if (email == null || !email.contains("@")) {
            throw new IllegalArgumentException("Email must contain '@'."); // Lỗi nếu thiếu @
        }
        this.email = email;
    }
}

class Main {
    public static void main(String[] args) {
        System.out.println("--- TEST VALID VALUES ---");
        try {
            // Khởi tạo đối tượng hợp lệ
            Person p1 = new Person("Han Minh Dinh", 22, "dinh@student.university.vn");
            System.out.println("Thanh cong: " + p1.getName() + ", " + p1.getAge() + ", " + p1.getEmail());
        } catch (IllegalArgumentException e) {
            System.out.println("Loi: " + e.getMessage());
        }

        System.out.println("\n--- TEST INVALID NAME ---");
        try {
            Person p2 = new Person("", 25, "test@mail.com"); // Cố tình để tên rỗng
        } catch (IllegalArgumentException e) {
            System.out.println("Da bat duoc loi Name: " + e.getMessage());
        }

        System.out.println("\n--- TEST INVALID AGE ---");
        try {
            Person p3 = new Person("Nguyen Van A", 200, "a@mail.com"); // Cố tình để tuổi > 150
        } catch (IllegalArgumentException e) {
            System.out.println("Da bat duoc loi Age: " + e.getMessage());
        }

        System.out.println("\n--- TEST INVALID EMAIL ---");
        try {
            Person p4 = new Person("Tran Van B", 30, "bmail.com"); // Cố tình thiếu chữ @
        } catch (IllegalArgumentException e) {
            System.out.println("Da bat duoc loi Email: " + e.getMessage());
        }
    }
}