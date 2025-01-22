using System;

public class SwapTwoNumbers
{
    public static void Main(String[] args)
    {
        // Creating an object of the SwapTwoNumbers class
        SwapTwoNumbers s = new SwapTwoNumbers();
        
        // Calling the Swap method to swap two numbers
        s.Swap();
    }

    // Creating a method Swap to swap two numbers
    public void Swap()
    {
        // Taking user input for the first number
        Console.Write("Enter the first number: ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        // Taking user input for the second number
        Console.Write("Enter the second number: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        // Swapping the numbers using a temporary variable
        int temp = number1;
        number1 = number2;
        number2 = temp;

        // Displaying the swapped numbers
        Console.WriteLine($"The swapped numbers are {number1} and {number2}");
    }
}
