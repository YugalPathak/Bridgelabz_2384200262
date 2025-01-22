using System;

namespace Calculate
{
    public class CalculateAge
    {
        public static void Main(string[] args)
        {
            // Creating object of class CalculateAge
            CalculateAge a1 = new CalculateAge();
            
            // Calling FindAge method to get the age as output
            a1.FindAge();
        }

        public void FindAge()
        {
            // Create variables to store name, birth year, and current year
            string name = "Harry";
            int birthYear = 2000;
            int currentYear = 2024;
            
            // Calculate the age by subtracting birth year from current year
            int age = currentYear - birthYear;
            
            // Print the current age
            Console.WriteLine($"{name}'s age in {currentYear} is {age}");
        }
    }
}
