using System;

public class SimpleInterest
{
    public static void Main(String[] args)
    {
        // Creating an object of the SimpleInterest class
        SimpleInterest si = new SimpleInterest();
        
        // Calling the Simple method to calculate simple interest
        si.Simple();
    }

    // Creating a method Simple for calculating simple interest
    public void Simple()
    {
        // Taking user input for Principal amount
        Console.Write("Enter the Principal amount: ");
        double principal = Convert.ToDouble(Console.ReadLine());

        // Taking user input for Rate of Interest
        Console.Write("Enter the Rate of Interest: ");
        double rate = Convert.ToDouble(Console.ReadLine());

        // Taking user input for Time (in years)
        Console.Write("Enter the Time (in years): ");
        double time = Convert.ToDouble(Console.ReadLine());

        // Calculating Simple Interest using the formula
        double simpleInterest = (principal * rate * time) / 100;

        // Displaying the result
        Console.WriteLine($"The Simple Interest is {simpleInterest} for Principal {principal}, Rate of Interest {rate}% and Time {time} years.");
    }
}
