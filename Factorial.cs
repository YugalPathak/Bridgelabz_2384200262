using System;

class Factorial
{
    static void Main()
    {
        // Call the method to compute the factorial
        ComputeFactorial();
    }

    // Method to compute the factorial
    static void ComputeFactorial()
    {
        Console.Write("Enter a positive integer: ");
        int n = Convert.ToInt32(Console.ReadLine());  // Take user input

        // Check if the entered number is a positive integer
        if (n < 0)
        {
            Console.WriteLine("Please enter a positive integer.");
            return;  // Exit the method if the number is not valid
        }

        // Initialize factorial result to 1 (since 0! = 1)
        long factorial = 1;

        // Using a while loop to compute factorial
        int i = 1;
        while (i <= n)
        {
            factorial *= i;  // Multiply the current number with factorial
            i++;  // Increment i
        }

        // Print the result
        Console.WriteLine($"The factorial of {n} is: {factorial}");
    }
}
