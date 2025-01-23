using System;

public class Divisibile
{   
    // Creating a method to check the divisibility of 5
    static bool IsDivisibleByFive(int number)
    {
        return number % 5 == 0; // return the divisibility
    }

    public static void Main(String[] args)
    {
	  // Taking user input to enter the number
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Store the result in the variable by using ternary operator
        string result = IsDivisibleByFive(number) ? "Yes" : "No";
	  
        // Displaying the result	
        Console.WriteLine($"Is the number {number} divisible by 5? {result}");
    }
}