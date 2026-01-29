using System;

namespace AnhNT.Module1
{
    public class FibonacciForLoop : IFibonacci
    {
        public void Fibonacci(int n, bool flag)
        {
            if (flag)
            {
                Console.WriteLine("Flag = true, for-loop not executed.");
                return;
            }

            int a = 0, b = 1, c;

            if (n == 0)
            {
                Console.WriteLine("Fibonacci(0) = 0");
                return;
            }

            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }

            Console.WriteLine($"Fibonacci({n}) = {b}");
        }
    }
}
