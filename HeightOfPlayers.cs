using System;

public class HeightOfPlayers
{
    // Creating a method to calculate the mean height
    public static void CalculateHeight()
    {
        // Declare an array to store the heights of 11 players
        double[] heights = new double[11];
        double sum = 0.0;

        // Get user input for each player's height
        for (int i = 0; i < heights.Length; i++)
        {
            Console.Write($"Enter the height of player {i + 1}: ");
            if (double.TryParse(Console.ReadLine(), out double height))
            {
                heights[i] = height;
                sum += height;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid height.");
                i--; // Ask for input again if invalid
            }
        }

        // Calculate the mean height
        double meanHeight = sum / heights.Length;

        // Display the mean height of the football team
        Console.WriteLine($"The mean height of the football team is: {meanHeight:F2}");
    }
   
    public static void Main(string[] args)
      {
          // Call the method to calculate the mean height
          CalculateHeight();
      }
}