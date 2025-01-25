using System;

public class ChangeArray
{
    public static void Main()
    {
        // Call the ProcessMatrix method 
        ProcessMatrix();
    }

    // Method to create a 2D array and copy elements to a 1D array
    static void ProcessMatrix()
    {
        // Take user input for the number of rows and columns
        Console.Write("Enter the number of rows: ");
        int rows = int.Parse(Console.ReadLine());  // Read and parse the number of rows

        Console.Write("Enter the number of columns: ");
        int columns = int.Parse(Console.ReadLine());  // Read and parse the number of columns

        // Create a 2D array with specified rows and columns
        int[,] matrix = new int[rows, columns];

        // Take user input to fill the 2D array
        Console.WriteLine("Enter the elements of the matrix:");

        // Loop through the rows and columns to get the matrix elements from the user
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"Enter element at [{i},{j}]: ");
                matrix[i, j] = int.Parse(Console.ReadLine());  // Assign the user input to the matrix
            }
        }

        // Create a 1D array to store the elements of the 2D array (size is rows * columns)
        int[] oneDArray = new int[rows * columns];
        int index = 0;  // Variable to track the index in the 1D array

        // Loop through the 2D array and copy its elements into the 1D array
        for (int i = 0; i < rows; i++)  // Outer loop for rows
        {
            for (int j = 0; j < columns; j++)  // Inner loop for columns
            {
                oneDArray[index++] = matrix[i, j];  // Copy the element to the 1D array and increment the index
            }
        }

        // Display the original 2D matrix
        Console.WriteLine("\nThe original 2D Matrix is:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(matrix[i, j] + " ");  // Display each element of the matrix
            }
            Console.WriteLine();  // Move to the next line after each row
        }

        // Display the copied 1D array
        Console.WriteLine("\nThe copied 1D Array is:");
        foreach (int element in oneDArray)
        {
            Console.Write(element + " ");  // Display each element of the 1D array
        }
    }
}