using System;

class AddCompare
{
    static void Main()
    {
        // Call the method to handle computation, and comparison
        ComputeSum();
    }

    // method to handle input, computation, and comparison
    static void ComputeSum()
    {
        Console.Write("Enter a positive integer (natural number): ");
        int n = Convert.ToInt32(Console.ReadLine());  // Take user input

        // Check if the entered number is a valid natural number
        if (n <= 0)
        {
            Console.WriteLine("Please enter a positive integer greater than 0.");
            return;  // Exit the method if the number is not valid
        }

        // Sum using while loop
        int sumWhileLoop = 0;
        int i = 1;
        while (i <= n)
        {
            sumWhileLoop += i;  // Add the current number to sum
            i++;  // Increment i
        }

        // Sum using the formula
        int sumFormula = n * (n + 1) / 2;

        // Display the results
        Console.WriteLine($"Sum using while loop: {sumWhileLoop}");
        Console.WriteLine($"Sum using the formula n*(n+1)/2: {sumFormula}");

        // Compare the results
        if (sumWhileLoop == sumFormula)
        {
            Console.WriteLine("The results match! Both methods are correct.");
        }
        else
        {
            Console.WriteLine("The results do not match. Something went wrong.");
        }
    }
}
