using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        int[] testCases = { 10, 30, 50 };

        foreach (int n in testCases)
        {
            Console.WriteLine($"Computing Fibonacci({n})");

            // Measure Recursive Fibonacci (O(2^N))
            Stopwatch sw = Stopwatch.StartNew();
            if (n <= 40) // Prevent long execution for large n
                Console.WriteLine($"Recursive Result: {FibonacciRecursive(n)}");
            else
                Console.WriteLine("Recursive Skipped (Too Slow)");
            sw.Stop();
            Console.WriteLine($"Recursive Time: {sw.ElapsedMilliseconds} ms");

            // Measure Iterative Fibonacci (O(N))
            sw.Restart();
            Console.WriteLine($"Iterative Result: {FibonacciIterative(n)}");
            sw.Stop();
            Console.WriteLine($"Iterative Time: {sw.ElapsedMilliseconds} ms");

            Console.WriteLine();
        }
    }

    // Recursive Fibonacci (O(2^N)) - Inefficient
    public static int FibonacciRecursive(int n)
    {
        if (n <= 1) return n;
        return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
    }

    // Iterative Fibonacci (O(N)) - Efficient
    public static int FibonacciIterative(int n)
    {
        if (n <= 1) return n;
        int a = 0, b = 1, sum;
        for (int i = 2; i <= n; i++)
        {
            sum = a + b;
            a = b;
            b = sum;
        }
        return b;
    }
}