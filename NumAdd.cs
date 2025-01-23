using System;

class NumAdd
{
    static void Main()
    {
        double total = CalculateSum();
        Console.WriteLine("The total sum is: " + total);
    }

    // Method to calculate the sum
    static double CalculateSum()
    {
        double total = 0.0;  // Initialize total to 0.0
        double number;  // Variable to store user input

        // Use a while loop to get user input until 0 is entered
        while (true)
        {
            Console.Write("Enter a number (0 to stop): ");
            number = Convert.ToDouble(Console.ReadLine());  // Read and convert input

            if (number == 0)
            {
                break;  // Exit the loop if 0 is entered
            }

            total += number;  // Add the number to the total
        }

        return total;  // Return the total sum
    }
}
