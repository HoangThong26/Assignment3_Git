public class Fibonacci : IFibonacci
{
    public int Fun(int n, bool flag)
    {
        if (n < 0)
            throw new ArgumentException("n must be >= 0");

        return flag ? FibonacciRecursive(n) : FibonacciLoop(n);
    }

    // Đệ quy
    private int FibonacciRecursive(int n)
    {
        if (n <= 1)
            return n;

        return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
    }

    // Vòng lặp
    private int FibonacciLoop(int n)
    {
        if (n <= 1)
            return n;

        int a = 0, b = 1, c = 0;

        for (int i = 2; i <= n; i++)
        {
            c = a + b;
            a = b;
            b = c;
        }

        return c;
    }
}
