using System;

class OddEvenNumbers
{
    static void Main()
    {
        // Call the ProcessNumbers method
        ProcessNumbers();
    }

    // Method to process and display even and odd numbers
    static void ProcessNumbers()
    {
        // Prompt the user for input
        Console.Write("Enter a natural number: ");
        string input = Console.ReadLine();  // Read the input from the user
        int num;

        // Check if the input is a valid integer and greater than 0 (natural number)
        if (int.TryParse(input, out num) && num > 0)
        {
            // Display even numbers
            Console.Write("Even numbers: ");
            for (int i = 1; i <= num; i++)  // Loop from 1 to the entered number
            {
                // Check if the number is even
                if (i % 2 == 0)
                    Console.Write(i + " ");  // Print the even number followed by a space
            }
            Console.WriteLine();  // Print a new line after displaying even numbers

            // Display odd numbers
            Console.Write("Odd numbers: ");
            for (int i = 1; i <= num; i++)  // Loop from 1 to the entered number
            {
                // Check if the number is odd
                if (i % 2 != 0)
                    Console.Write(i + " ");  // Print the odd number followed by a space
            }
            Console.WriteLine();  // Print a new line after displaying odd numbers
        }
        else
        {
            // If the input is invalid (not a number or not a positive integer)
            Console.WriteLine("Invalid input. Please enter a natural number.");
        }
    }
}