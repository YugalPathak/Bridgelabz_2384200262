using System;

public class IntOperation
{
    public static void Main(String[] args)
    {
        // Creating an object of the class
        IntOperation op = new IntOperation();
        
        // Calling the method
        op.Operation();
    }
    
    // Creating a method Operation to display the result
    public void Operation()
    {
        // Taking user input for a, b, and c
        Console.Write("Enter value for a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter value for b: ");
        int b = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter value for c: ");
        int c = Convert.ToInt32(Console.ReadLine());
        
        // Compute the integer operations
        int result1 = a + b * c; // Multiplication (*) has higher precedence than addition (+)
        int result2 = a * b + c; // Multiplication (*) has higher precedence than addition (+)
        int result3 = c + a / b; // Division (/) has higher precedence than addition (+)
        int result4 = a % b + c; // Modulus (%) has higher precedence than addition (+)
        
        // Displaying the results
        Console.WriteLine($"The results of Int Operations are {result1}, {result2}, {result3}, and {result4}");
    }
}
