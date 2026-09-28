public abstract class Employee {
    protected String name;
    protected double baseSalary;

    public Employee(String name, double baseSalary) {
        this.name = name;
        this.baseSalary = baseSalary;
    }

    public abstract double calculateSalary();

    public void printPaySlip() {
        System.out.println("Nhan vien   : " + name);
        System.out.printf("Luong co ban: %,.0f VND\n", baseSalary);
        System.out.printf("Tong nhan   : %,.0f VND\n", calculateSalary());
    }
}