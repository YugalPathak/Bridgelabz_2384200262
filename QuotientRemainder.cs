using System;

public class QuotientRemainder
{
    public static void Main(string[] args)
    {
        // Creating an object of the class
        QuotientRemainder qr = new QuotientRemainder();
        
        // Calling the method to calculate quotient and remainder
        qr.Divide();
    }

    // Creating a method Divide to find the quotient and remainder
    public void Divide()
    {
        // Taking user input to enter two numbers
        Console.Write("Enter the first number: ");
        double number1 = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Enter the second number: ");
        double number2 = Convert.ToDouble(Console.ReadLine());
        
        // Calculating the quotient
        double quotient = number1 / number2;
        
        // Calculating the remainder
        double remainder = number1 % number2;
        
        // Displaying the result
        Console.WriteLine($"The Quotient is {quotient} and remainder is {remainder} of two numbers {number1} and {number2}");
    }
}
