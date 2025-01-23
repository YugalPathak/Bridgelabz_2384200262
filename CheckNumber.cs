using System;

public class CheckNum
{
    // Method to check if a number is positive
    static bool IsPositive(double number)
    {
        return number > 0;
    }
	
    // Method to check if a number is negative
    static bool IsNegative(double number)
    {
        return number < 0;
    }
	
    // Method to check if a number is zero
    static double IsZero(double number)
    {
        return number = 0;
    }

    public static void Main(String[] args)
    {
        // Taking user input to enter an age
        Console.Write("Enter a number: ");
	  double number = Convert.ToDouble(Console.ReadLine());
        
	  // Calling the method to check age by using if-else statement
        if (IsPositive(number))
        {	
		// Displaying the result
            Console.WriteLine("Positive");
        }
        else if(IsNegative(number))
        {
		// Displaying the result
            Console.WriteLine("Negative");
        }
	  else 
	  {
		// Displaying the result
            Console.WriteLine("Zero");
        }	
    }
}