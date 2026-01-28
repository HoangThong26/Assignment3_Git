using System;

public class Fibonacci : IFibonacci
{
    public int Fun(int n, bool flag)
    {
        if (flag)
            throw new InvalidOperationException("Impl2 chỉ xử lý flag = false");

        return Loop(n);
    }

    private int Loop(int n)
    {
        if (n <= 1) return n;

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
