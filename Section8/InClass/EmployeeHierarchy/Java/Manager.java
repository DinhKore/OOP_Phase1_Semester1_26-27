public class Manager extends Employee {
    private double teamBonus;

    public Manager(String name, double baseSalary, double teamBonus) {
        super(name, baseSalary);
        this.teamBonus = teamBonus;
    }

    @Override
    public double calculateSalary() {
        return baseSalary + teamBonus;
    }
}