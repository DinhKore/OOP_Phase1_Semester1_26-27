using System;

public class BankAccount
{
    public string Owner { get; set; }

    private double balance;
    public double Balance
    {
        get { return balance; }
        set
        {
            if (value < 0) throw new ArgumentException("Negative!");
            balance = value;
        }
    }

    // Yêu cầu 1: Thêm thuộc tính InterestRate[cite: 1]
    public double InterestRate { get; set; }

    // Overload 1: 1 tham số. 
    // Chaining đến constructor 2 tham số với startingBalance = 0[cite: 63]
    public BankAccount(string owner) : this(owner, 0) { }

    // Yêu cầu 3: Constructor 2 tham số vẫn hoạt động bằng cách chaining đến constructor mới với lãi suất mặc định là 0.01[cite: 1]
    public BankAccount(string owner, double startingBalance) : this(owner, startingBalance, 0.01) { }

    // Yêu cầu 2: Thêm constructor nạp chồng thứ 3 gồm 3 tham số[cite: 1]
    public BankAccount(string owner, double startingBalance, double interestRate)
    {
        Owner = owner;
        Balance = startingBalance;
        InterestRate = interestRate;
    }

    // Ghi đè phương thức ToString() để in ra lãi suất[cite: 58]
    public override string ToString()
    {
        return $"Account [{Owner}]: ${Balance:F2} - Rate: {InterestRate}";
    }

    // Yêu cầu 5: Thêm phương thức Transfer để chuyển tiền giữa 2 tài khoản[cite: 1]

    public void Deposit(double amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Deposit must be positive.");
        Balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Withdrawal must be positive.");
        if (amount > Balance)
            throw new InvalidOperationException("Insufficient funds.");
        Balance -= amount;
    }

    public void Transfer(BankAccount target, double amount)
    {
        // Rút từ tài khoản hiện tại, nếu lỗi sẽ dừng ngay lập tức[cite: 80]
        this.Withdraw(amount);

        // Nạp vào tài khoản đích[cite: 80]
        target.Deposit(amount);
    }
}

public class Program
{
    public static void Main()
    {
        // Yêu cầu 4: Kiểm thử việc tạo tài khoản với 1, 2 và 3 tham số[cite: 1]
        BankAccount acc1 = new BankAccount("Lan");
        BankAccount acc2 = new BankAccount("Hoa", 1000);
        BankAccount acc3 = new BankAccount("Nam", 1500, 0.05);
        BankAccount acc4 = new BankAccount("An", 1000);
        BankAccount acc5 = new BankAccount("Binh", 500);

        acc4.Transfer(acc5, 200);

        Console.WriteLine(acc1);
        Console.WriteLine(acc2);
        Console.WriteLine(acc3);
        // In ra kết quả để kiểm tra (sử dụng hàm ToString đã ghi đè)
        Console.WriteLine(acc4); // Kết quả mong muốn: Account[Lan]: $800
        Console.WriteLine(acc5); // Kết quả mong muốn: Account[Hoa]: $700
    }
}