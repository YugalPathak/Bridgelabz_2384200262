using System;

public class StoreValues
{
    public static void StoreAndSumNumbers()
    {
        // Array to store up to 10 numbers
        double[] numbers = new double[10];
       
        // Variable to store the sum of numbers
        double total = 0.0;
       
        // Index to track the number of elements stored
        int index = 0;

        // Infinite loop to take user inputs until a stopping condition is met
        while (true)
        {
            Console.Write("Enter a number (0 or negative to stop): ");
           
            // Try to parse user input into a double
            if (double.TryParse(Console.ReadLine(), out double input))
            {
                // Stop the loop if input is 0 or a negative number
                if (input <= 0)
                {
                    break;
                }
               
                // Stop the loop if the array is full
                if (index == 10)
                {
                    break;
                }
               
                // Store valid input in the array and increment index
                numbers[index] = input;
                index++;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
       
        // Loop to calculate the total sum of entered numbers
        for (int i = 0; i < index; i++)
        {
            total += numbers[i];
        }
       
        // Display all entered numbers
        Console.WriteLine("You entered the following numbers:");
        for (int i = 0; i < index; i++)
        {
            Console.WriteLine(numbers[i]);
        }
       
        // Print the total sum of the numbers
        Console.WriteLine($"The total sum of the numbers is: {total}");
    }
   
    public static void Main(string[] args)
      {
          // Call the method to store and sum numbers
            StoreAndSumNumbers();
      }
}