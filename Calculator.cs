using System;

namespace Calculate
{
    public class Calculator
    {
        public static void Main(string[] args)
        {
            // Creating object of Calculator class
            Calculator c1 = new Calculator();
            
            // Calling method to perform the arithmetic operations
            c1.CalculateOperations();
        }

        public void CalculateOperations()  // Method to calculate sum, difference, product, and division
        {
            // Prompting user to enter the first number
            Console.WriteLine("Enter a number: ");
            
            // Taking input for the first number
            double number1 = Convert.ToDouble(Console.ReadLine());
            
            // Prompting user to enter the second number
            Console.WriteLine("Enter another number: ");
            
            // Taking input for the second number
            double number2 = Convert.ToDouble(Console.ReadLine());
            
            // Calculating the sum of the two numbers
            double sum = number1 + number2;
            
            // Calculating the difference of the two numbers
            double difference = number1 - number2;
            
            // Calculating the product of the two numbers
            double product = number1 * number2;
            
            // Calculating the division of the two numbers
            double division = number1 / number2;
            
            // Displaying the results of the operations
            Console.WriteLine($"The addition, subtraction, multiplication, and division of {number1} and {number2} are: {sum}, {difference}, {product}, and {division}");
        }
    }
}
