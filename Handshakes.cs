using System;

namespace Calculate
{
    public class Handshakes
    {
        public static void Main(string[] args)
        {
            // Creating object of Handshakes class
            Handshakes s1 = new Handshakes();
            
            // Calling method to calculate maximum number of handshakes
            s1.CalculateHandshakes();
        }

        public void CalculateHandshakes()  // Method to calculate maximum handshakes
        {
            // Prompting the user to enter number of students
            Console.WriteLine("Enter number of students: ");
            
            // Taking input for number of students
            double numberOfStudents = Convert.ToDouble(Console.ReadLine());
            
            // Calculating the maximum number of handshakes using formula
            double maxHandshakes = (numberOfStudents * (numberOfStudents - 1)) / 2;
            
            // Displaying the result
            Console.WriteLine($"The maximum number of handshakes is {maxHandshakes}");
        }
    }
}
