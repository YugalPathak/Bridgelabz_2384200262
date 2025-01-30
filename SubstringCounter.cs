using System;

class SubstringCounter
{
	// Creating a method to find the substring
    public static void FindSubstring()
    {
        // Take the input string from the user
        Console.WriteLine("Enter the main string:");
        string input = Console.ReadLine();

        // Take the substring to count from the user
        Console.WriteLine("Enter the substring:");
        string substring = Console.ReadLine();

        // Initialize variables
        int count = 0;
        int inputLength = input.Length;
        int subLength = substring.Length;

        // Loop through the input string and check each position for the substring
        for (int i = 0; i <= inputLength - subLength; i++)
        {
            // Compare the substring starting at index i with the given substring
            bool match = true;
            for (int j = 0; j < subLength; j++)
            {
                if (input[i + j] != substring[j])
                {
                    match = false;
                    break;
                }
            }

            // If a match is found, increment the count
            if (match)
            {
                count++;
            }
        }

        // Output the result
        Console.WriteLine($"The substring '{substring}' occurs {count} times in the main string.");
    }
	
	public static void Main(string[] args)
	{
		// Calling the method
		FindSubstring();
	}	
}