using System;

public class IncomeCalculator
{
    public static void Main(String[] args)
    {
        // Creating an object of the class
        IncomeCalculator ic = new IncomeCalculator();
        
        // Calling the method
        ic.Calculation();
    }

    // Creating a method Calculation to calculate total income
    public void Calculation()
    {
        // Taking user input for salary
        Console.Write("Enter your salary (INR): ");
        double salary = Convert.ToDouble(Console.ReadLine());
        
        // Taking user input for bonus
        Console.Write("Enter your bonus (INR): ");
        double bonus = Convert.ToDouble(Console.ReadLine());
        
        // Calculating total income
        double totalIncome = salary + bonus;
        
        // Displaying the result
        Console.WriteLine($"The salary is INR {salary} and bonus is INR {bonus}. Hence, Total Income is INR {totalIncome}");
    }
}
