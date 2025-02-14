using System;

class HeapSort
{
    static void Heapify(int[] salaries, int n, int i)
    {
        int largest = i; // Root node (assume largest)
        int left = 2 * i + 1; // Left child
        int right = 2 * i + 2; // Right child

        // Check if left child exists and is greater than root
        if (left < n && salaries[left] > salaries[largest])
        {
            largest = left;
        }

        // Check if right child exists and is greater than the largest so far
        if (right < n && salaries[right] > salaries[largest])
        {
            largest = right;
        }

        // If largest is not root, swap and continue heapifying
        if (largest != i)
        {
            int temp = salaries[i];
            salaries[i] = salaries[largest];
            salaries[largest] = temp;

            Heapify(salaries, n, largest);
        }
    }

    static void Sort(int[] salaries)
    {
        int n = salaries.Length;

        // Build max heap (rearrange array)
        for (int i = n / 2 - 1; i >= 0; i--)
        {
            Heapify(salaries, n, i);
        }

        // Extract elements from heap one by one
        for (int i = n - 1; i > 0; i--)
        {
            // Move current root to end
            int temp = salaries[0];
            salaries[0] = salaries[i];
            salaries[i] = temp;

            // Call max heapify on the reduced heap
            Heapify(salaries, i, 0);
        }
    }

    static void PrintArray(int[] salaries)
    {
        foreach (int salary in salaries)
        {
            Console.Write(salary + " ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        int[] salaryDemands = { 50000, 75000, 60000, 90000, 45000, 80000 };

        Console.WriteLine("Original Salary Demands:");
        PrintArray(salaryDemands);

        Sort(salaryDemands);

        Console.WriteLine("Sorted Salary Demands:");
        PrintArray(salaryDemands);
    }
}
