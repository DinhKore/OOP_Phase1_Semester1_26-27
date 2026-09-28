public class Developer extends Employee {
    private int linesShipped;
    private double ratePerLine;

    public Developer(String name, double baseSalary, int linesShipped, double ratePerLine) {
        super(name, baseSalary);
        this.linesShipped = linesShipped;
        this.ratePerLine = ratePerLine;
    }

    @Override
    public double calculateSalary() {
        return baseSalary + (linesShipped * ratePerLine);
    }
}