using System;

namespace Calculate
{
    public class SideOfSquare
    {
        public static void Main(string[] args)
        {
            // Creating object of SideOfSquare class
            SideOfSquare square1 = new SideOfSquare();
            
            // Calling method to calculate the side of the square
            square1.CalculateSide();
        }

        public void CalculateSide()  // Method to calculate the side of the square
        {
            // Prompting user to enter the perimeter of the square
            Console.WriteLine("Enter perimeter of square: ");
            
            // Taking input for perimeter of the square
            double squarePerimeter = Convert.ToDouble(Console.ReadLine());
            
            // Calculating the side of the square (side = perimeter / 4)
            double squareSide = squarePerimeter / 4;
            
            // Displaying the result (side and perimeter of the square)
            Console.WriteLine($"The length of the side is {squareSide} whose perimeter is {squarePerimeter}");
        }
    }
}
