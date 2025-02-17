using System;
using System.Diagnostics;
using System.Text;

class Program
{
    static void Main()
    {
        int[] testCases = { 1000, 10000, 1000000 };

        foreach (int N in testCases)
        {
            Console.WriteLine($"Testing with N = {N}");

            // String concatenation (O(N²))
            Stopwatch sw = Stopwatch.StartNew();
            string testString = "";
            for (int i = 0; i < N; i++)
            {
                testString += "a";  // Creates a new object every time (inefficient)
            }
            sw.Stop();
            Console.WriteLine($"String concatenation took: {sw.ElapsedMilliseconds} ms");

            // StringBuilder concatenation (O(N))
            sw.Restart();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < N; i++)
            {
                sb.Append("a");  // Efficient mutable approach
            }
            sw.Stop();
            Console.WriteLine($"StringBuilder concatenation took: {sw.ElapsedMilliseconds} ms");

            Console.WriteLine();
        }
    }
}