
    public class Fibonacci : IFibonacci
    {
        public int Fibonacci(int n, bool flag)
        {
            if (!flag)
                throw new ArgumentException("Flag must be true for impl1");

            return FibonacciRecursive(n);
        }

        private int FibonacciRecursive(int n)
        {
            if (n <= 1)
                return n;

            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }
    }

