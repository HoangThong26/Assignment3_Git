using System;

namespace hieuht24.module1
{
    public class Fibonacci : IFibonacci
    {
        public int Fibonacci(int n, bool flag)
        {

            if (flag)
                throw new ArgumentException("Flag must be false for impl2");

            if (n <= 1) return n;

            int a = 0, b = 1;
            for (int i = 2; i <= n; i++)
            {
                int temp = a + b;
                a = b;
                b = temp;
            }
            return b;

            if (!flag)
            {
                throw new ArgumentException("Flag must be true for recursive Fibonacci");
            }

            return FibRecursive(n);
        }

        private int FibRecursive(int n)
        {
            if (n <= 1)
                return n;

            return FibRecursive(n - 1) + FibRecursive(n - 2);

        }

    }
}
