using System;

class BubbleSort
{
    static void Sort(int[] marks)
    {
        int n = marks.Length;
        bool swapped;

        for (int i = 0; i < n - 1; i++)
        {
            swapped = false;

            for (int j = 0; j < n - i - 1; j++)
            {
                if (marks[j] > marks[j + 1])
                {
                    // Swap marks[j] and marks[j+1]
                    int temp = marks[j];
                    marks[j] = marks[j + 1];
                    marks[j + 1] = temp;

                    swapped = true;
                }
            }

            // If no swaps occurred, the array is already sorted
            if (!swapped)
                break;
        }
    }

    static void PrintArray(int[] marks)
    {
        foreach (int mark in marks)
        {
            Console.Write(mark + " ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        int[] studentMarks = { 85, 42, 96, 74, 23, 58, 91, 67 };

        Console.WriteLine("Original Marks:");
        PrintArray(studentMarks);

        Sort(studentMarks);

        Console.WriteLine("Sorted Marks:");
        PrintArray(studentMarks);
    }
}
