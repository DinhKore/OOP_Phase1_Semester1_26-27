public class BankAccount {
    private String owner;
    private double balance;

    // Yêu cầu 1: Thêm trường interestRate[cite: 1]
    private double interestRate;

    // Overload 1: 1 tham số.
    // Chaining đến constructor 2 tham số với startingBalance = 0[cite: 66]
    public BankAccount(String owner) {
        this(owner, 0);
    }

    // Yêu cầu 3: Constructor 2 tham số chaining đến constructor 3 tham số với lãi
    // suất mặc định là 0.01[cite: 1, 22]
    public BankAccount(String owner, double startingBalance) {
        this(owner, startingBalance, 0.01);
    }

    // Yêu cầu 2: Thêm constructor nạp chồng thứ 3 gồm 3 tham số[cite: 1]
    public BankAccount(String owner, double startingBalance, double interestRate) {
        this.owner = owner;
        setBalance(startingBalance); // Sử dụng setter có kiểm tra dữ liệu[cite: 66]
        this.interestRate = interestRate;
    }

    public void setBalance(double balance) {
        if (balance < 0)
            throw new IllegalArgumentException("Negative!");
        this.balance = balance;
    }

    public double getBalance() {
        return balance;
    }

    // Thêm phương thức này vào bên trong class BankAccount
    public void transfer(BankAccount target, double amount) {
        // Tương tự như C#, gọi hàm rút tiền trước
        this.withdraw(amount);

        // Nếu rút thành công thì mới nạp tiền vào tài khoản đích
        target.deposit(amount);
    }

    public void deposit(double amount) {
        if (amount < 0)
            throw new IllegalArgumentException("Negative!");
        balance += amount;
    }

    public void withdraw(double amount) {
        if (amount < 0)
            throw new IllegalArgumentException("Negative!");
        if (amount > balance)
            throw new IllegalArgumentException("Insufficient funds!");
        balance -= amount;
    }

    // Ghi đè phương thức toString() để in ra lãi suất[cite: 59]
    @Override
    public String toString() {
        return String.format("Account[%s]: $%.2f - Rate: %.2f", owner, balance, interestRate);
    }

    public static void main(String[] args) {
        // Yêu cầu 4: Kiểm thử việc tạo tài khoản với 1, 2 và 3 tham số[cite: 1]
        BankAccount acc1 = new BankAccount("Lan");
        BankAccount acc2 = new BankAccount("Hoa", 1000);
        BankAccount acc3 = new BankAccount("Nam", 1500, 0.05);
        BankAccount acc4 = new BankAccount("An", 1000);
        BankAccount acc5 = new BankAccount("Binh", 500);

        acc4.transfer(acc5, 200);

        System.out.println(acc1);
        System.out.println(acc2);
        System.out.println(acc3);
        // In ra kết quả để kiểm tra (sử dụng hàm toString() đã ghi đè)
        System.out.println(acc4); // Kết quả mong muốn: Account[An]: $800 - Rate: 0.01
        System.out.println(acc5); // Kết quả mong muốn: Account[Binh]: $700 - Rate: 0.01
    }
}