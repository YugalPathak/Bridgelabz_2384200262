using System;

namespace Calculate
{
    public class DistanceConversion
    {
        public static void Main(string[] args)
        {
            // Creating object of DistanceConversion class
            DistanceConversion distance1 = new DistanceConversion();
            
            // Calling method to convert distance from feet to yards and miles
            distance1.ConvertDistance();
        }

        public void ConvertDistance()  // Method to convert distance from feet to yards and miles
        {
            // Prompting user to enter the distance in feet
            Console.WriteLine("Enter distance in feet to convert: ");
            
            // Taking input for distance in feet
            double feetDistance = Convert.ToDouble(Console.ReadLine());
            
            // Converting feet to yards
            double yardDistance = feetDistance / 3;
            
            // Converting yards to miles (1760 yards = 1 mile)
            double milesDistance = yardDistance / 1760;
            
            // Displaying the result (distance in feet, yards, and miles)
            Console.WriteLine($"Distance in feet is {feetDistance}, while in yards is {yardDistance}, and in miles is {milesDistance}");
        }
    }
}
