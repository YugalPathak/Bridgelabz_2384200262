using System;

public class Heights
{
    public static void Main(string[] args)
    {
        // Arrays to store age and height of the friends
        int[] ages = new int[3];
        double[] heights = new double[3];
        string[] names = { "Amar", "Akbar", "Anthony" };

        // Input ages and heights for each friend
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Enter details for {0}:", names[i]);
           
            //Taking user input for the age
            Console.WriteLine("Enter age of {0}: ", names[i]);
            ages[i] = Convert.ToInt32(Console.ReadLine());
           
            // Validating the age
            if (ages[i] < 0 || ages[i] > 100) {
                Console.Error.WriteLine("Invalid input. Please enter a number between 0 and 100.");
               
                 // Exit the program if input is invalid
                Environment.Exit(0);
            }
           
            // Taking user input for the height
            Console.WriteLine("Enter height (in cm) of {0}: ", names[i]);
            heights[i] = Convert.ToDouble(Console.ReadLine());
           
            // Validating the height input
            if (heights[i] < 0 || heights[i] > 300) {
                Console.Error.WriteLine("Invalid input. Please enter a number between 0 and 300.");
                Environment.Exit(0);
            }
        }

        // Find the youngest friend
        int youngestIndex = FindYoungest(ages);

        // Find the tallest friend
        int tallestIndex = FindTallest(heights);

        // Displaying the results
        Console.WriteLine("\nResults:");
        Console.WriteLine("The youngest friend is {0} with an age of {1} years.", names[youngestIndex], ages[youngestIndex]);
        Console.WriteLine("The tallest friend is {0} with a height of {1} cm.", names[tallestIndex], heights[tallestIndex]);
    }

    // Method to find the youngest friend
    static int FindYoungest(int[] ages)
    {
        // Initialize minAge with the first element
        int minAge = ages[0];
       
        // Track the index of the youngest friend
        int youngestIndex = 0;
     
        // Iterate through the ages array to find the minimum age
        for (int i = 1; i < ages.Length; i++)
        {
            if (ages[i] < minAge)
            {
                minAge = ages[i];
                youngestIndex = i; // Update the index of the youngest friend
            }
        }

        return youngestIndex; // Return the index of the youngest friend
    }

    // Method to find the tallest friend
    static int FindTallest(double[] heights)
    {
        // Initialize maxHeight with the first element
        double maxHeight = heights[0];
       
        // Track the index of the tallest friend
        int tallestIndex = 0;
 
        // Iterate through the heights array to find the maximum height
        for (int i = 1; i < heights.Length; i++)
        {
            if (heights[i] > maxHeight)
            {
                maxHeight = heights[i];
                tallestIndex = i;  // Update the index of the tallest friend
            }
        }

        return tallestIndex; // Return the index of the tallest friend
    }
}