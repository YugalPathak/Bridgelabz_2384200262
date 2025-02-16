using System;

class Program
{
    static void Main()
    {
        int[] array = { 1, 3, 5, 4, 2 };
        int peakIndex = FindPeakElement(array);
        
        Console.WriteLine($"A peak element is at index: {peakIndex}, value: {array[peakIndex]}");
    }
    
    static int FindPeakElement(int[] arr)
    {
        int left = 0, right = arr.Length - 1;
        
        while (left < right)
        {
            int mid = left + (right - left) / 2;
            
            if (arr[mid] > arr[mid + 1])
            {
                right = mid;
            }
            else
            {
                left = mid + 1;
            }
        }
        return left;
    }
}