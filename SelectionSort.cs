using System;

class SelectionSort
{
    static void Sort(int[] scores)
    {
        int n = scores.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i; // Assume the first unsorted element is the smallest

            // Find the minimum element in the remaining array
            for (int j = i + 1; j < n; j++)
            {
                if (scores[j] < scores[minIndex])
                {
                    minIndex = j;
                }
            }

            // Swap the found minimum element with the first unsorted element
            int temp = scores[minIndex];
            scores[minIndex] = scores[i];
            scores[i] = temp;
        }
    }

    static void PrintArray(int[] scores)
    {
        foreach (int score in scores)
        {
            Console.Write(score + " ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        int[] examScores = { 85, 72, 90, 60, 95, 80 };

        Console.WriteLine("Original Exam Scores:");
        PrintArray(examScores);

        Sort(examScores);

        Console.WriteLine("Sorted Exam Scores:");
        PrintArray(examScores);
    }
}
