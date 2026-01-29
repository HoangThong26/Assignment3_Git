using System;

namespace AnhNT.Module1
{
    public class FibonacciRecursive : IFibonacci
    {
        public void Fibonacci(int n, bool flag)
        {
            if (!flag)
            {
                Console.WriteLine("Flag = false, recursion not executed.");
                return;
            }

            Console.WriteLine($"Fibonacci({n}) = {Fib(n)}");
        }

        private int Fib(int n)
        {
            if (n <= 1)
                return n;

            return Fib(n - 1) + Fib(n - 2);
        }
    }
}
