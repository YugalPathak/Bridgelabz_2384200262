using System;

class MergeSort
{
    static void Merge(int[] prices, int left, int mid, int right)
    {
        int n1 = mid - left + 1;  // Size of left subarray
        int n2 = right - mid;      // Size of right subarray

        int[] leftArray = new int[n1];
        int[] rightArray = new int[n2];

        // Copy data to temporary arrays
        for (int i = 0; i < n1; i++)
            leftArray[i] = prices[left + i];
        for (int j = 0; j < n2; j++)
            rightArray[j] = prices[mid + 1 + j];

        // Merge the two subarrays back into the original array
        int iIndex = 0, jIndex = 0, kIndex = left;

        while (iIndex < n1 && jIndex < n2)
        {
            if (leftArray[iIndex] <= rightArray[jIndex])
            {
                prices[kIndex] = leftArray[iIndex];
                iIndex++;
            }
            else
            {
                prices[kIndex] = rightArray[jIndex];
                jIndex++;
            }
            kIndex++;
        }

        // Copy any remaining elements from leftArray
        while (iIndex < n1)
        {
            prices[kIndex] = leftArray[iIndex];
            iIndex++;
            kIndex++;
        }

        // Copy any remaining elements from rightArray
        while (jIndex < n2)
        {
            prices[kIndex] = rightArray[jIndex];
            jIndex++;
            kIndex++;
        }
    }

    static void Sort(int[] prices, int left, int right)
    {
        if (left < right)
        {
            int mid = left + (right - left) / 2; // Find the middle index

            Sort(prices, left, mid);    // Recursively sort the left half
            Sort(prices, mid + 1, right); // Recursively sort the right half

            Merge(prices, left, mid, right); // Merge sorted halves
        }
    }

    static void PrintArray(int[] prices)
    {
        foreach (int price in prices)
        {
            Console.Write(price + " ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        int[] bookPrices = { 450, 200, 150, 300, 500, 350 };

        Console.WriteLine("Original Book Prices:");
        PrintArray(bookPrices);

        Sort(bookPrices, 0, bookPrices.Length - 1);

        Console.WriteLine("Sorted Book Prices:");
        PrintArray(bookPrices);
    }
}
