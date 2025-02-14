using System;

class InsertionSort
{
    static void Sort(int[] employeeIds)
    {
        int n = employeeIds.Length;
        for (int i = 1; i < n; i++)
        {
            int key = employeeIds[i]; // Pick the current element
            int j = i - 1;

            // Move elements that are greater than key one position ahead
            while (j >= 0 && employeeIds[j] > key)
            {
                employeeIds[j + 1] = employeeIds[j];
                j--;
            }
            employeeIds[j + 1] = key; // Place key in the correct position
        }
    }

    static void PrintArray(int[] employeeIds)
    {
        foreach (int id in employeeIds)
        {
            Console.Write(id + " ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        int[] employeeIds = { 105, 101, 109, 103, 107, 102 };

        Console.WriteLine("Original Employee IDs:");
        PrintArray(employeeIds);

        Sort(employeeIds);

        Console.WriteLine("Sorted Employee IDs:");
        PrintArray(employeeIds);
    }
}
