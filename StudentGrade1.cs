using System;

public class StudentGrade1
{
    public static void Main()
    {
        // Take user input for the number of students
        Console.Write("Enter the number of students: ");
        int numberOfStudents = Convert.ToInt32(Console.ReadLine());
        if (numberOfStudents < 1 || numberOfStudents > int.MaxValue)
        {
            Console.Error.WriteLine("Please enter a valid positive integer.");
            Environment.Exit(0);// Exit if input is invalid
        }

        // Define arrays to store marks, percentages, and grades of students
        int[] physics = new int[numberOfStudents];
        int[] chemistry = new int[numberOfStudents];
        int[] maths = new int[numberOfStudents];

         // Array to store Percentage for each student
        double[] percentages = new double[numberOfStudents];
       
        // Array to store Grade for each student
        string[] grades = new string[numberOfStudents];

        // Take input for marks of each student using a method
        for (int i = 0; i < numberOfStudents; i++)
        {
            Console.WriteLine($"Enter marks for student {i + 1}:");

            // Collecting marks for each student through a method call
            int[] marks = GetStudentMarks(i + 1);
           
            // Assign Physics marks to the array
            physics[i] = marks[0];
            // Assign Chemistry marks to the array
            chemistry[i] = marks[1];
             // Assign Maths marks to the array
            maths[i] = marks[2];
        }

        // Calculate percentage and grade for each student
        for (int i = 0; i < numberOfStudents; i++)
        {
             // Calculate total marks for the student
            int totalMarks = physics[i] + chemistry[i] + maths[i];
            // Calculate percentage based on total marks out of 300 (for 3 subjects)
            percentages[i] = (double)totalMarks / 3;
            // Determine the grade based on the calculated percentage
            grades[i] = DetermineGrade(percentages[i]);
        }

        // Display marks, percentages, and grades of each student
        Console.WriteLine("\nDetails of each student:");
        for (int i = 0; i < numberOfStudents; i++)
        {
            // Display details for each student
            Console.WriteLine($"Student {i + 1}: Physics = {physics[i]}, Chemistry = {chemistry[i]}, Maths = {maths[i]}, Percentage = {percentages[i]}%, Grade = {grades[i]}");
        }
    }

    // Method to determine grade based on percentage
    static string DetermineGrade(double percentage)
    {
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

    // Method to get marks for each student (Physics, Chemistry, Maths)
    static int[] GetStudentMarks(int studentNumber)
    {
        int[] marks = new int[3]; // Array to hold marks for Physics, Chemistry, Maths

        // Collect valid marks for each subject
        marks[0] = GetValidInput($"Enter valid Physics marks for student {studentNumber} (0-100): ", 0, 100);
        marks[1] = GetValidInput($"Enter valid Chemistry marks for student {studentNumber} (0-100): ", 0, 100);
        marks[2] = GetValidInput($"Enter valid Maths marks for student {studentNumber} (0-100): ", 0, 100);

        return marks;
    }

    // Method to get valid integer input
    static int GetValidInput(string promptMessage, int min, int max)
    {
        int input;
        while (true)
        {
            Console.Write(promptMessage);// Prompt the user for input
            if (int.TryParse(Console.ReadLine(), out input) && input >= min && input <= max)
            {
                return input;// Return the valid input
            }
           
             // If input is invalid, show an error message and ask for input again
            Console.WriteLine("Invalid input. Please enter a value between {0} and {1}.", min, max);
        }
    }
}