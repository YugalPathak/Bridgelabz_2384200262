using System;

class Table
{
    static void Main()
    {
        // Call the method to print the multiplication table
        PrintTable();
    }

    // Method to input a number and print its multiplication table from 6 to 9
    static void PrintTable()
    {
        // Input the number
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Using a for loop to print the multiplication table from 6 to 9
        for (int i = 6; i <= 9; i++)
        {
            Console.WriteLine($"{number} * {i} = {number * i}");
        }
    }
}
