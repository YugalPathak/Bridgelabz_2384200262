using System;

namespace Calculate
{
    public class AthleteRun
    {
        public static void Main(string[] args)
        {
            // Creating an object of the AthleteRun class
            AthleteRun r1 = new AthleteRun();
            
            // Calling the CountRounds method to perform the calculations
            r1.CountRounds();
        }

        public void CountRounds()
        {
            // Taking input from the user for the sides of the triangle (in meters)
            Console.Write("Enter the first side of the triangle in meters: ");
            double side1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second side of the triangle in meters: ");
            double side2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the third side of the triangle in meters: ");
            double side3 = Convert.ToDouble(Console.ReadLine());

            // Calculating the perimeter of the triangle
            double perimeter = side1 + side2 + side3;

            // Total distance to run (5 km = 5000 meters)
            double distance = 5000;

            // Calculating the number of rounds the athlete will run
            double rounds = distance / perimeter;

            // Displaying the result
            Console.WriteLine($"The total number of rounds the athlete will run is {rounds} to complete 5 km.");
        }
    }
}
