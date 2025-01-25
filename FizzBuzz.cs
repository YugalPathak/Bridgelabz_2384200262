using System;

public class FizzBuzz
{
    public static void Main()
    {
        // Call the ProcessFizzBuzz method 
        PrintFizzBuzz();
    }

    // Method to process FizzBuzz logic and display the results
    static void PrintFizzBuzz()
    {
        // Take user input for a positive integer
        Console.Write("Enter a positive number: ");
        int num;

        // Check if the input is a valid integer and is positive
        if (int.TryParse(Console.ReadLine(), out num) && num > 0)
        {
            // Create array to store the results
            string[] results = new string[num];

            // Loop from 1 to the entered number
            for (int i = 1; i <= num; i++)
            {
                // Check if the current number is divisible by both 3 and 5
                if (i % 3 == 0 && i % 5 == 0)
                {
                    results[i - 1] = "FizzBuzz";  // Store "FizzBuzz"
                }
                // Check if the current number is divisible by 3
                else if (i % 3 == 0)
                {
                    results[i - 1] = "Fizz";  // Store "Fizz"
                }
                // Check if the current number is divisible by 5
                else if (i % 5 == 0)
                {
                    results[i - 1] = "Buzz";  // Store "Buzz"
                }
                else
                {
                    results[i - 1] = i.ToString();  // Store the number as a string
                }
            }

            // Display the results from the array
            Console.WriteLine("\nFizzBuzz Results:");
            for (int i = 0; i < results.Length; i++)
            {
                Console.WriteLine($"Position {i + 1} = {results[i]}");
            }
        }
        else
        {
            // If the input is not a valid positive integer
            Console.WriteLine("Invalid input. Please enter a positive integer.");
        }
    }
}
