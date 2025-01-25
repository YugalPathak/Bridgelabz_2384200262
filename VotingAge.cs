using System;

public class VotingAge
{
    // Method to take input and check voting eligibility
    public static void VotingEligibility()
    {
        // Declaring an array of 10 integers to store student ages
        int[] studentAges = new int[10];

        // Taking user input for student ages
        for (int i = 0; i < studentAges.Length; i++)
        {
            Console.Write($"Enter the age of student {i + 1}: ");
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                // If the input is valid, store the age in the studentAges array at index i
                studentAges[i] = age;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                i--; // Ask for input again if invalid
            }
        }

        // Checking voting eligibility
        foreach (int age in studentAges)
        {
            // Check if the age is less than zero
            if (age < 0)
            {
                Console.WriteLine($"The age {age} is invalid.");
            }
            // Check if the age is greater than or equal to 18
            else if (age >= 18)
            {
                Console.WriteLine($"The student with the age {age} can vote.");
            }
            else
            {
                Console.WriteLine($"The student with the age {age} cannot vote.");
            }
        }
    }
   
    public static void Main(string[] args)
      {
          // Call the method to check voting eligibility
          VotingEligibility();
      }
}