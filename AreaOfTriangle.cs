using System;

namespace Calculate
{
    public class AreaOfTriangle
    {
        public static void Main(string[] args)
        {
            // Creating object of AreaOfTriangle class
            AreaOfTriangle triangle1 = new AreaOfTriangle();
            
            // Calling method to calculate area of the triangle
            triangle1.CalculateArea();
        }

        public void CalculateArea()  // Method to calculate area of triangle
        {
            // Prompting user to enter the height of the triangle in cm
            Console.WriteLine("Enter height of triangle in cm: ");
            
            // Taking input for the height in cm
            double triangleHeightInCm = Convert.ToDouble(Console.ReadLine());
            
            // Prompting user to enter the base of the triangle in cm
            Console.WriteLine("Enter base of triangle in cm: ");
            
            // Taking input for the base in cm
            double triangleBaseInCm = Convert.ToDouble(Console.ReadLine());
            
            // Converting height and base from cm to inches (1 inch = 2.54 cm)
            double triangleHeightInInches = triangleHeightInCm / 2.54;
            double triangleBaseInInches = triangleBaseInCm / 2.54;
            
            // Calculating the area of the triangle in square inches and square cm
            double squareInchArea = 0.5 * triangleHeightInInches * triangleBaseInInches;
            double squareCmArea = 0.5 * triangleHeightInCm * triangleBaseInCm;
            
            // Displaying the result (height, base, and area in both cm and inches)
            Console.WriteLine($"Triangle Height in cm is {triangleHeightInCm} while in inches is {triangleHeightInInches} \n" +
                              $"Base in cm is {triangleBaseInCm} while in inches is {triangleBaseInInches} \n" +
                              $"Area of triangle in square cm is {squareCmArea} while in square inches is {squareInchArea}");
        }
    }
}
