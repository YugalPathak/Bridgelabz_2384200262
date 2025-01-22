using System;

namespace Calculate
{
    public class KilometersToMiles
    {
        public static void Main(string[] args)
        {
            // Creating object of KilometersToMiles class
            KilometersToMiles km = new KilometersToMiles();
            
            // Calling the Convert method to convert kilometers to miles
            km.Convert();
        }

        public void Convert()   // Method to convert kilometers to miles
        {
            // Create variable to store the distance value in kilometers
            double distanceInKilometers = 10.8;

            // Calculate the distance in miles using the conversion factor
            double distanceInMiles = distanceInKilometers * 0.621371;

            // Print the result that is the distance in miles
            Console.WriteLine($"The distance {distanceInKilometers} km in miles is {distanceInMiles}");
        }
    }
}