using System;

class StringCompare
{
    public static void Main(string[] args)
    {
        // Take input strings from the user
        Console.WriteLine("Enter the first string:");
        string str1 = Console.ReadLine();

        Console.WriteLine("Enter the second string:");
        string str2 = Console.ReadLine();

        // Compare the strings lexicographically
        int result = CompareStrings(str1, str2);

        // Output the result based on the comparison
        if (result < 0)
        {
            Console.WriteLine($"\"{str1}\" comes before \"{str2}\" in lexicographical order.");
        }
        else if (result > 0)
        {
            Console.WriteLine($"\"{str1}\" comes after \"{str2}\" in lexicographical order.");
        }
        else
        {
            Console.WriteLine($"\"{str1}\" and \"{str2}\" are equal.");
        }
    }

    static int CompareStrings(string str1, string str2)
    {
        int length1 = str1.Length;
        int length2 = str2.Length;

        // Compare character by character
        for (int i = 0; i < Math.Min(length1, length2); i++)
        {
            // If the characters differ, return the difference
            if (str1[i] < str2[i])
            {
                return -1;  // str1 comes before str2
            }
            else if (str1[i] > str2[i])
            {
                return 1;  // str1 comes after str2
            }
        }

        // If one string is a prefix of the other, the shorter string comes first
        if (length1 < length2)
        {
            return -1;  // str1 comes before str2
        }
        else if (length1 > length2)
        {
            return 1;   // str1 comes after str2
        }

        // If both strings are identical
        return 0;  // str1 is equal to str2
    }
}

