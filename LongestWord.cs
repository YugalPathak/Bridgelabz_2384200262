using System;

class LongestWord
{
    // Creating a method to find the longest word
    public static void FindLongestWord()
    {
        // Take input sentence from user
        Console.WriteLine("Enter a sentence:");
        string sentence = Console.ReadLine();

        // Split the sentence into words using space as delimiter
        string[] words = sentence.Split(' ');

        // Initialize variables to keep track of the longest word
        string longestWord = "";
        
        // Loop through each word in the sentence
        foreach (string word in words)
        {
            // Update longestWord if the current word is longer than the previous longest
            if (word.Length > longestWord.Length)
            {
                longestWord = word;
            }
        }

        // Output the longest word
        Console.WriteLine("The longest word in the sentence is: " + longestWord);
    }
	
	public static void Main(string[] args)
    {
		// Calling the method
		FindLongestWord();
	}	
}

