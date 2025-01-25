using System;

public class Table6To9
{
    // Creating a method to generate table from 6 to 9
    public static void GenerateTable()
    {
        // Prompt user to enter a number
        Console.Write("Enter a number: ");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            // Define an array to store multiplication results
            int[] multiplicationResult = new int[4];

            // Loop through numbers 6 to 9 and store the results
            for (int i = 6; i <= 9; i++)
            {
                multiplicationResult[i - 6] = number * i;
            }

            // Display the multiplication table
            Console.WriteLine($"Multiplication table for {number} from 6 to 9:");
            for (int i = 6; i <= 9; i++)
            {
                Console.WriteLine($"{number} * {i} = {multiplicationResult[i - 6]}");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }
   
    public static void Main(string[] args)
      {
          // Call the method to generate the multiplication table
          GenerateTable();
      }
}