using System;

class NumSum
{
    static void Main()
    {
        double total = CalculateSum(); // Call the method to calculate the sum
        Console.WriteLine("The total sum is: " + total);
    }

    // Method to calculate the sum until the user enters 0 or a negative number
    static double CalculateSum()
    {
        double total = 0.0; // Initialize total to 0.0
        double number; // Variable to store user input

        // Use an infinite while loop (loop will break if the user enters 0 or a negative number)
        while (true)
        {
            Console.Write("Enter a number (0 or negative number to stop): ");
            number = Convert.ToDouble(Console.ReadLine()); // Read and convert input

            if (number <= 0) // Break if the user enters 0 or a negative number
            {
                break;
            }

            total += number; // Add the entered number to the total
        }

        return total; // Return the total sum
    }
}
