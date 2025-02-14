using System;

class CountingSort
{
    static void Sort(int[] ages, int minAge, int maxAge)
    {
        int range = maxAge - minAge + 1;
        int[] count = new int[range]; // Count array
        int[] output = new int[ages.Length]; // Sorted output array

        // Step 1: Count occurrences of each age
        for (int i = 0; i < ages.Length; i++)
        {
            count[ages[i] - minAge]++;
        }

        // Step 2: Compute cumulative count
        for (int i = 1; i < count.Length; i++)
        {
            count[i] += count[i - 1];
        }

        // Step 3: Place elements in the correct position
        for (int i = ages.Length - 1; i >= 0; i--)
        {
            output[count[ages[i] - minAge] - 1] = ages[i];
            count[ages[i] - minAge]--;
        }

        // Copy sorted values back to original array
        for (int i = 0; i < ages.Length; i++)
        {
            ages[i] = output[i];
        }
    }

    static void PrintArray(int[] ages)
    {
        foreach (int age in ages)
        {
            Console.Write(age + " ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        int[] studentAges = { 12, 15, 10, 18, 14, 13, 12, 17, 16, 11 };

        Console.WriteLine("Original Student Ages:");
        PrintArray(studentAges);

        Sort(studentAges, 10, 18);

        Console.WriteLine("Sorted Student Ages:");
        PrintArray(studentAges);
    }
}
