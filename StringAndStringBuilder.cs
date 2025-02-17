using System;
using System.Diagnostics;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        string filePath = "largefile.txt";  // Ensure this file exists and is large (e.g., 500MB)

        Console.WriteLine("Benchmarking File Reading Methods...\n");

        // Benchmark StreamReader
        Stopwatch sw = Stopwatch.StartNew();
        using (StreamReader reader = new StreamReader(filePath))
        {
            while (reader.ReadLine() != null) { }  // Reading line by line
        }
        sw.Stop();
        Console.WriteLine($"StreamReader Time: {sw.ElapsedMilliseconds} ms");

        // Benchmark FileStream (buffered reading)
        sw.Restart();
        using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read, bufferSize: 8192))
        {
            byte[] buffer = new byte[8192]; // 8KB buffer
            while (fs.Read(buffer, 0, buffer.Length) > 0) { }
        }
        sw.Stop();
        Console.WriteLine($"FileStream Time: {sw.ElapsedMilliseconds} ms");
    }
}