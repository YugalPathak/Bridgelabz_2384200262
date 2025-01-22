using System;

namespace Calculate
{
    public class KmToMiles
    {
        public static void Main(string[] args)
        {
            // Creating an object of KmToMiles class
            KmToMiles distance1 = new KmToMiles();
            
            // Calling method to convert kilometers to miles
            distance1.ConvertToMiles();
        }

        public void ConvertToMiles()  // Method to convert kilometers to miles
        {
            // Prompting user to enter the distance in kilometers
            Console.WriteLine("Enter distance in km to convert to miles: ");
            
            // Taking input for distance in kilometers
            double km = Convert.ToDouble(Console.ReadLine());
            
            // Converting the distance from kilometers to miles (1 km = 1.6 miles)
            double miles = km / 1.6;
            
            // Displaying the result (distance in miles and kilometers)
            Console.WriteLine($"The total miles is {miles} mile for the given {km} km");
        }
    }
}
