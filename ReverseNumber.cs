using System;

class ReverseNumber
{
    static void Main()
    {
        // Call the ReverseNumber method to start processing
        ReverseNumberMethod();
    }

    // Method to reverse the digits of the number and display the reversed number
    static void ReverseNumberMethod()
    {
        // Take user input for a number
        Console.Write("Enter a number: ");
        int num;

        // Check if the input is a valid integer
        if (int.TryParse(Console.ReadLine(), out num) && num > 0)
        {
            // Create a list or array to store digits temporarily
            string numString = num.ToString();  // Convert number to string for easy manipulation
            int length = numString.Length;      // Get the length (number of digits)

            // Create an array to store the digits in reverse order
            char[] reversedDigits = new char[length];

            // Loop through the number and store digits in reverse order
            for (int i = 0; i < length; i++)
            {
                reversedDigits[i] = numString[length - 1 - i];  // Reverse the order of digits
            }

            // Display the reversed number as a string
            Console.WriteLine("Reversed number: ");
            Console.WriteLine(new string(reversedDigits));  // Convert the character array back to string
        }
        else
        {
            // If the input is not a valid number or not a positive integer
            Console.WriteLine("Invalid input. Please enter a valid positive integer.");
        }
    }
}