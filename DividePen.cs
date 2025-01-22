using System;

namespace Calculate
{
    public class DividePen
    {
        public static void Main(string[] args)
        {
            // Creating an object of the DividePen class
            DividePen dp = new DividePen();
            
            // Calling the method EqualPenDivide to calculate the pens distribution
            dp.EqualPenDivide();
        }

        public void EqualPenDivide()  // Method to calculate how to divide pens equally among students and spare pens
        {
            // Creating variables to store the total number of pens and students
            int totalPens = 14;
            int totalStudents = 3;
            
            // Calculating spare pens (those that can't be divided equally)
            int sparePens = totalPens % totalStudents;
            
            // Calculating the total pens to be divided equally (removes the spare pens)
            int pensToDivide = totalPens - sparePens;
            
            // Calculating the number of pens each student gets
            int penPerStudent = pensToDivide / totalStudents;
            
            // Printing the result: pens per student and the number of remaining spare pens
            Console.WriteLine($"The Pen Per Student is {penPerStudent} and the remaining pen not distributed is {sparePens}");
        }
    }
}
