using System;

namespace Calculate
{
    public class HeightConversion
    {
        public static void Main(string[] args)
        {
            // Creating an object of HeightConversion class
            HeightConversion height1 = new HeightConversion();
            
            // Calling method to convert height in cm to feet and inches
            height1.ConvertHeight();
        }

        public void ConvertHeight()  // Method to convert height in cm to feet and inches
        {
            // Prompting the user to enter their height in cm
            Console.WriteLine("Enter height in cm to convert: ");
            
            // Taking input for height in cm
            double heightInCm = Convert.ToDouble(Console.ReadLine());
            
            // Calculating the height in inches (1 inch = 2.54 cm)
            double heightInInches = heightInCm / 2.54;
            
            // Calculating the height in feet (12 inches = 1 foot)
            double heightInFeet = heightInInches / 12;
            
            // Displaying the result (height in cm, feet, and inches)
            Console.WriteLine($"Your height in cm is {heightInCm}, while in feet is {heightInFeet} and in inches is {heightInInches}");
        }
    }
}
