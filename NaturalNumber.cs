using System;

public class NaturalNo
{
    // Method to check if a number is a natural number
    static bool IsNaturalNo(int number)
    {
        return number >= 0;
    }

    // Method to calculate the sum of first n natural numbers using the formula: n * (n + 1) / 2
    static int SumOfNaturalNo(int number)
    {
        return number * (number + 1) / 2;
    }

    public static void Main(String[] args)
    {
        // Taking user input to enter a number
        Console.Write("Enter a number: ");
	  int number = Convert.ToInt32(Console.ReadLine());
        
	  // Calling the method to check number is natural by using if-else statement
        if (IsNaturalNo(number))
        {
		// Calling the method to calculate sum of natural number
            int sum = SumOfNaturalNo(number);

			
		// Displaying the result
            Console.WriteLine($"The sum of {number} natural numbers is {sum}");
        }
        else 
        {
		// Displaying the result
            Console.WriteLine($"The number {number} is not a natural number");
        }
    }
}