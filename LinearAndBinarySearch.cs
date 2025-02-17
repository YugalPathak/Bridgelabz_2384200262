using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        int[] sizes = { 1000, 10000, 1000000 };
        Random rand = new Random();

        foreach (int size in sizes)
        {
            int[] data = new int[size];
            for (int i = 0; i < size; i++)
                data[i] = rand.Next(size); // Random data for sorting

            Console.WriteLine($"Dataset Size: {size}");

            // Bubble Sort (Inefficient for large data)
            int[] bubbleData = (int[])data.Clone();
            Stopwatch stopwatch = Stopwatch.StartNew();
            BubbleSort(bubbleData);
            stopwatch.Stop();
            Console.WriteLine($"Bubble Sort Time: {stopwatch.Elapsed.TotalMilliseconds} ms");

            // Merge Sort
            int[] mergeData = (int[])data.Clone();
            stopwatch.Restart();
            MergeSort(mergeData);
            stopwatch.Stop();
            Console.WriteLine($"Merge Sort Time: {stopwatch.Elapsed.TotalMilliseconds} ms");

            // Quick Sort
            int[] quickData = (int[])data.Clone();
            stopwatch.Restart();
            QuickSort(quickData, 0, quickData.Length - 1);
            stopwatch.Stop();
            Console.WriteLine($"Quick Sort Time: {stopwatch.Elapsed.TotalMilliseconds} ms\n");
        }
    }

    static void BubbleSort(int[] data)
    {
        int n = data.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (data[j] > data[j + 1])
                {
                    int temp = data[j];
                    data[j] = data[j + 1];
                    data[j + 1] = temp;
                }
            }
        }
    }

    static void MergeSort(int[] data)
    {
        if (data.Length <= 1)
            return;
        int mid = data.Length / 2;
        int[] left = new int[mid];
        int[] right = new int[data.Length - mid];
        Array.Copy(data, 0, left, 0, mid);
        Array.Copy(data, mid, right, 0, data.Length - mid);
        MergeSort(left);
        MergeSort(right);
        Merge(data, left, right);
    }

    static void Merge(int[] data, int[] left, int[] right)
    {
        int i = 0, j = 0, k = 0;
        while (i < left.Length && j < right.Length)
        {
            if (left[i] <= right[j])
                data[k++] = left[i++];
            else
                data[k++] = right[j++];
        }
        while (i < left.Length)
            data[k++] = left[i++];
        while (j < right.Length)
            data[k++] = right[j++];
    }

    static void QuickSort(int[] data, int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = Partition(data, low, high);
            QuickSort(data, low, pivotIndex - 1);
            QuickSort(data, pivotIndex + 1, high);
        }
    }

    static int Partition(int[] data, int low, int high)
    {
        int pivot = data[high];
        int i = low - 1;
        for (int j = low; j < high; j++)
        {
            if (data[j] <= pivot)
            {
                i++;
                (data[i], data[j]) = (data[j], data[i]);
            }
        }
        (data[i + 1], data[high]) = (data[high], data[i + 1]);
        return i + 1;
    }
}