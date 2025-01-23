using System;

public class LargestNum
{
    // Method to check first number is the largest among the three numbers
    static bool IsFirstNumLargest(int number1, int number2, int number3)
    {
        return number1 > number2 && number1 > number3;
    }
	
	// Method to check second number is the largest among the three numbers
    static bool IsSecondNumLargest(int number1, int number2, int number3)
    {
        return number2 > number1 && number2 > number3;
    }
	
	// Method to check third number is the largest among the three numbers
    static bool IsThirdNumLargest(int number1, int number2, int number3)
    {
        return number3 > number1 && number3 > number2;
    }
	
    public static void Main(String[] args)
    {
        // Taking user input to enter the first number
        Console.Write("Enter the first number: ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        // Taking user input to enter the second number
        Console.Write("Enter the second number: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        // Taking user input to enter the third number
        Console.Write("Enter the third number: ");
        int number3 = Convert.ToInt32(Console.ReadLine());

        // Calling the method to check which number is the largest
        string firstResult = IsFirstNumLargest(number1, number2, number3) ? "Yes" : "No";
	    string secondResult = IsSecondNumLargest(number1, number2, number3) ? "Yes" : "No";
	    string thirdResult = IsThirdNumLargest(number1, number2, number3) ? "Yes" : "No";

        // Displaying the result
        Console.WriteLine($"Is the first number the largest? {firstResult}");
		Console.WriteLine($"Is the second number the largest? {secondResult}");
		Console.WriteLine($"Is the third number the largest? {thirdResult}");
		
    }
}