using System;

namespace Calculate
{
    public class AveragePercentMarks
    {
        public static void Main(string[] args)
        {
            // Creating object of class AveragePercentMarks
            AveragePercentMarks marks = new AveragePercentMarks();
            
            // Calling method Average that calculates average marks
            marks.Average();
        }

        public void Average()
        {
            // Create variables to store subject marks and name
            string name = "Sam";
            int mathsMarks = 94;
            int physicsMarks = 95;
            int chemistryMarks = 96;

            // Calculate the average marks
            int averageMarks = (mathsMarks + physicsMarks + chemistryMarks) / 3;

            // Print the result (average marks)
            Console.WriteLine($"{name}'s average mark in PCM is {averageMarks}");
        }
    }
}
