using System;

public class StudentGrade2
{
    public static void Main()
    {
        // Take user input for the number of students
        Console.Write("Enter the number of students: ");
        int numberOfStudents = Convert.ToInt32(Console.ReadLine());
       
        // Validate the number of students
        if (numberOfStudents < 1 || numberOfStudents > int.MaxValue)
        {
            Console.Error.WriteLine("Please enter a valid positive integer.");
            Environment.Exit(0); // Exit if input is invalid
        }

        // Define arrays to store marks, percentages, and grades of students
        int[,] marks = new int[numberOfStudents, 3];
        double[] percentages = new double[numberOfStudents];
        string[] grades = new string[numberOfStudents];

        // Take input for marks of each student using a method to collect marks
        for (int i = 0; i < numberOfStudents; i++)
        {
            Console.WriteLine($"Enter marks for student {i + 1}:");

            // Call the method GetStudentMarks() to collect marks for Physics, Chemistry, and Maths
            marks[i, 0] = GetStudentMarks("Physics");
            marks[i, 1] = GetStudentMarks("Chemistry");
            marks[i, 2] = GetStudentMarks("Maths");
        }

        // Calculate percentage and grade for each student
        for (int i = 0; i < numberOfStudents; i++)
        {
            // Calculate the total marks for each student (sum of marks in all 3 subjects)
            int totalMarks = marks[i, 0] + marks[i, 1] + marks[i, 2];
           
            // Calculate the percentage (totalMarks / 3 since there are 3 subjects)
            percentages[i] = (double)totalMarks / 3;
           
            // Determine the grade based on percentage using the DetermineGrade method
            grades[i] = DetermineGrade(percentages[i]);
        }

        // Display the marks, percentages, and grades of each student
        Console.WriteLine("\nDetails of each student:");
        for (int i = 0; i < numberOfStudents; i++)
        {
            // Display details for each student: marks, percentage, and grade
            Console.WriteLine($"Student {i + 1}: Physics = {marks[i, 0]}, Chemistry = {marks[i, 1]}, Maths = {marks[i, 2]}, Percentage = {percentages[i]}%, Grade = {grades[i]}");
        }
    }

    // Method to determine grade based on percentage
    static string DetermineGrade(double percentage)
    {
        // Check the percentage and return the appropriate grade
        if (percentage >= 80)
        {
            return "A - (Level 4, above agency-normalized standards)";
        }
        else if (percentage >= 70 && percentage <= 79)
        {
            return "B - (Level 3, at agency-normalized standards)";
        }
        else if (percentage >= 60 && percentage <= 69)
        {
            return "C - (Level 2, below but approaching agency-normalized standards)";
        }
        else if (percentage >= 50 && percentage <= 59)
        {
            return "D - (Level 1, well below agency-normalized standards)";
        }
        else if (percentage >= 40 && percentage <= 49)
        {
            return "F - (Level 1-, too below agency-normalized standards)";
        }
        else
        {
            return "R - (Remedial standards)";
        }
    }

    // Method to get valid integer input for each subject mark
    static int GetStudentMarks(string subject)
    {
        int mark;
        while (true)
        {
            Console.Write($"Enter valid {subject} marks (0-100): ");
            if (int.TryParse(Console.ReadLine(), out mark) && mark >= 0 && mark <= 100)
            {
                return mark; // Return the valid mark
            }
            // If input is invalid, prompt the user again
            Console.WriteLine("Invalid input. Please enter a valid mark between 0 and 100.");
        }
    }
}