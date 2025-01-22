using System;

namespace Calculate
{
    public class EarthVolume
    {
        public static void Main(string[] args)
        {
            // Creating an object of EarthVolume class
            EarthVolume volume1 = new EarthVolume();
            
            // Calling the method to calculate the volume of the Earth
            volume1.CalculateVolume();
        }

        public void CalculateVolume()  // Method to calculate the volume of Earth
        {
            // Creating a variable to store the radius of Earth in kilometers
            double earthRadiusInKm = 6378;
            
            // Converting the radius from kilometers to miles (1 km = 0.621371 miles)
            double earthRadiusInMiles = earthRadiusInKm * 0.621371;
            
            // Calculating the volume of Earth in cubic kilometers (V = 4/3 * π * r^3)
            double earthVolumeCubicKm = (4.0 / 3.0) * Math.PI * Math.Pow(earthRadiusInKm, 3);
            
            // Calculating the volume of Earth in cubic miles (V = 4/3 * π * r^3)
            double earthVolumeCubicMiles = (4.0 / 3.0) * Math.PI * Math.Pow(earthRadiusInMiles, 3);
            
            // Displaying the result: volume of Earth in both cubic kilometers and cubic miles
            Console.WriteLine($"The volume of Earth in cubic kilometers is {earthVolumeCubicKm} and cubic miles is {earthVolumeCubicMiles}");
        }
    }
}
