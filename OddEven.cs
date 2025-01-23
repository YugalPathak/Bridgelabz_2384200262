using System;

class OddEven
{
    static void Main()
    {
        // Call the method to print odd and even numbers
        PrintOddEven();
    }

    // Method to print odd and even numbers
    static void PrintOddEven()
    {
        Console.Write("Enter a positive integer: ");
        int number = Convert.ToInt32(Console.ReadLine());  // Take user input

        // Check if the entered number is a valid natural number
        if (number <= 0)
        {
            Console.WriteLine("Please enter a positive integer greater than 0.");
            return;  // Exit the method if the number is not valid
        }

        // Using a for loop to iterate from 1 to the number
        for (int i = 1; i <= number; i++)
        {
            // Check if the number is even or odd
            if (i % 2 == 0)
            {
                Console.WriteLine($"{i} is even.");
            }
            else
            {
                Console.WriteLine($"{i} is odd.");
            }
        }
    }
}
