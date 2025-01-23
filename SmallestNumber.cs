using System;

public class SmallestNum
{
    // Method to check if the first number is the smallest among the three numbers
    static bool IsFirstNumSmallest(int number1, int number2, int number3)
    {
        return number1 < number2 && number1 < number3;
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

        // Calling the method to check if the first number is the smallest
        string result = IsFirstNumSmallest(number1, number2, number3) ? "Yes" : "No";

        // Displaying the result
        Console.WriteLine($"Is the first number the smallest? {result}");
    }
}