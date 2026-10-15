public class Student {
    private String name;
    private int studentId;
    private double gpa;

    // Constructor
    public Student(String name, int studentId, double gpa) {
        this.name = name;
        this.studentId = studentId;
        setGpa(gpa); // Kích hoạt hàm setter để chạy validation
    }

    // Getters
    public String getName() { return name; }
    public int getStudentId() { return studentId; }
    public double getGpa() { return gpa; }

    // Setters
    public void setName(String name) { this.name = name; }
    public void setStudentId(int studentId) { this.studentId = studentId; }
    
    // Validation cho GPA nằm trong setter
    public void setGpa(double gpa) {
        if (gpa < 0.0 || gpa > 4.0) {
            throw new IllegalArgumentException("GPA không hợp lệ! Phải nằm trong khoảng từ 0.0 đến 4.0.");
        }
        this.gpa = gpa;
    }

    // Ghi đè toString để in thông tin
    @Override
    public String toString() {
        return "ID: " + studentId + " | Tên: " + name + " | GPA: " + gpa;
    }
}