using System;

public class FindFactor
{
    public static void Main()
    {
        // Call the method to find and display factors
        FindAndDisplayFactors();
    }

    // Method to find and display factors of a number
    public static void FindAndDisplayFactors()
    {
        // Take user input for the number
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        // Initialize a size array for factors
        int maxFactor = 20;  // Size of the array 
        int[] factors = new int[maxFactor];  // Array to store factors
        int index = 0;  // Index to store factors in the array

        // Loop to find factors of the number
        for (int i = 1; i <= num; i++)
        {
            if (num % i == 0)  // Check if i is a factor
            {
                if (index < maxFactor)  // If there is space in the array
                {
                    factors[index++] = i;  // Add the factor to the array
                }
                else
                {
                    Console.WriteLine("Array size is not enough to store all factors.");
                    break;
                }
            }
        }

        // Display the factors
        Console.WriteLine("The factors of " + num + " are:");
        for (int i = 0; i < index; i++)
        {
            Console.Write(factors[i] + " ");
        }
    }
}