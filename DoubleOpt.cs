using System;

public class DoubleOpt
{
    public static void Main(String[] args)
    {
        // Creating an object of the class
        DoubleOpt op = new DoubleOpt();
        
        // Calling the method
        op.Operation();
    }

    // Creating a method Operation to display the result
    public void Operation()
    {
        // Taking user input for a, b, and c
        Console.Write("Enter value for a: ");
        double a = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Enter value for b: ");
        double b = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Enter value for c: ");
        double c = Convert.ToDouble(Console.ReadLine());
        
        // Compute the double operations
        double result1 = a + b * c; // Multiplication (*) has higher precedence than addition (+)
        double result2 = a * b + c; // Multiplication (*) has higher precedence than addition (+)
        double result3 = c + a / b; // Division (/) has higher precedence than addition (+)
        double result4 = a % b + c; // Modulus (%) has higher precedence than addition (+)
        
        // Displaying the results
        Console.WriteLine($"The results of Double Operations are {result1}, {result2}, {result3}, and {result4}");
    }
}
