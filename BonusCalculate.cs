using System;

class BonusCalculate
{
    static void Main()
    {
        // Call the method to calculate and print bonus
        ComputeBonus();
    }

    // Method to calculate bonus, and print the result
    static void ComputeBonus()
    {
        // Input salary and years of service
        Console.Write("Enter the salary of the employee: ");
        double salary = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the years of service: ");
        double yearsOfService = Convert.ToDouble(Console.ReadLine());

        // Calculate bonus
        double bonus = 0;
        if (yearsOfService > 5)
        {
            bonus = salary * 0.05;  // 5% bonus for more than 5 years of service
        }

        // Print the bonus amount
        Console.WriteLine($"The bonus amount is: {bonus}");
    }
}
