using System;

public class Vector2D
{
    // Thuộc tính X và Y
    public double X;
    public double Y;

    // Hàm khởi tạo (Constructor)
    public Vector2D(double x, double y)
    {
        X = x;
        Y = y;
    }

    // 1. Nạp chồng toán tử cộng (+)
    public static Vector2D operator +(Vector2D a, Vector2D b)
    {
        return new Vector2D(a.X + b.X, a.Y + b.Y);
    }

    // 2. Nạp chồng toán tử trừ (-)
    public static Vector2D operator -(Vector2D a, Vector2D b)
    {
        return new Vector2D(a.X - b.X, a.Y - b.Y);
    }

    // 3. Nạp chồng toán tử so sánh bằng (==) và khác (!=)
    public static bool operator ==(Vector2D a, Vector2D b)
    {
        return a.X == b.X && a.Y == b.Y;
    }

    public static bool operator !=(Vector2D a, Vector2D b)
    {
        return !(a == b);
    }

    // 4. Ghi đè Equals() và GetHashCode()
    public override bool Equals(object obj)
    {
        Vector2D other = (Vector2D)obj; // Ép kiểu thông thường
        return this.X == other.X && this.Y == other.Y;
    }

    public override int GetHashCode()
    {
        return (int)(X + Y); // Trả về một số nguyên để tránh compiler cảnh báo
    }

    // 5. Ghi đè ToString() để in dạng "(X, Y)"
    public override string ToString()
    {
        return "(" + X + ", " + Y + ")";
    }
}