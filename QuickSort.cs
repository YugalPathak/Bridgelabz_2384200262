using System;

class QuickSort
{
    static int Partition(int[] prices, int low, int high)
    {
        int pivot = prices[high]; // Choosing last element as pivot
        int i = low - 1; // Pointer for smaller elements

        for (int j = low; j < high; j++)
        {
            if (prices[j] < pivot)
            {
                i++;
                // Swap prices[i] and prices[j]
                int temp = prices[i];
                prices[i] = prices[j];
                prices[j] = temp;
            }
        }

        // Swap pivot to correct position
        int temp2 = prices[i + 1];
        prices[i + 1] = prices[high];
        prices[high] = temp2;

        return i + 1; // Return pivot index
    }

    static void Sort(int[] prices, int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = Partition(prices, low, high);

            Sort(prices, low, pivotIndex - 1); // Sort left partition
            Sort(prices, pivotIndex + 1, high); // Sort right partition
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
        int[] productPrices = { 1200, 750, 1900, 500, 1000, 1500 };

        Console.WriteLine("Original Product Prices:");
        PrintArray(productPrices);

        Sort(productPrices, 0, productPrices.Length - 1);

        Console.WriteLine("Sorted Product Prices:");
        PrintArray(productPrices);
    }
}
