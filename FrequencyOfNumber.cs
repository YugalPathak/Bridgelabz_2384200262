using System;

public class FrequencyOfNumber
{
    public static void Main()
    {
        // Take user input for a number
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine()); 
        
        // Validate the input number
        if (number < 0 || number > int.MaxValue) 
        {
            Console.Error.WriteLine("Please enter a valid positive integer.");
            Environment.Exit(0); // Exit if the input is not a valid positive integer
        }

        // Define an array to store the frequency of digits (0-9)
        int[] frequency = new int[10]; 

        // Call the method to find the frequency of each digit in the number
        CalculateFrequency(number, frequency);

        // Display the frequency of each digit
        Console.WriteLine("\nFrequency of each digit:");
        DisplayFrequency(frequency); // Call the method to display the frequency
    }

    // Method to calculate the frequency of digits in the number
    static void CalculateFrequency(int number, int[] frequency)
    {
        // Loop through each digit of the number until the number becomes 0
        while (number > 0)
        {
            // Extract the last digit of the number using modulus
            int digit = number % 10;
            
            // Increment the frequency count of the extracted digit
            frequency[digit]++;
            
            // Remove the last digit from the number
            number /= 10;
        }
    }

    // Method to display the frequency of each digit
    static void DisplayFrequency(int[] frequency)
    {
        // Loop through the frequency array (0 to 9)
        for (int i = 0; i < frequency.Length; i++)
        {
            // If the frequency of the digit is greater than 0, display the digit and its frequency
            if (frequency[i] > 0)
            {
                Console.WriteLine($"Digit {i}: {frequency[i]}");
            }
        }
    }
}
