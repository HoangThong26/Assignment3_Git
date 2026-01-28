namespace hieuht24.module1
{
    public class Fibonacci : IFibonacci
    {
        public int Fibonacci(int n, bool flag)
        {
            if (n < 0)
                throw new ArgumentException("n must be >= 0");

            if (flag)
            {
                // Recursive
                return FibonacciRecursive(n);
            }
            else
            {
                // Iterative
                return FibonacciIterative(n);
            }
        }

        private int FibonacciRecursive(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;

            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }

        private int FibonacciIterative(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;

            int a = 0;
            int b = 1;

            for (int i = 2; i <= n; i++)
            {
                int temp = a + b;
                a = b;
                b = temp;
            }

            return b;
        }
    }
}
