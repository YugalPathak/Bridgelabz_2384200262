using System;

class WeightConverter
{
    public static void Main(String[] args)
    {
        // Creating an object of the class
        WeightConverter wc = new WeightConverter();

        // Calling the method to convert and display the weight
        wc.ConvertAndDisplayWeight();
    }

    // Method to convert weight
    public void ConvertAndDisplayWeight()
    {
        // Taking user input for weight in pounds
        Console.Write("Enter weight in pounds: ");
        double weightInPounds = Convert.ToDouble(Console.ReadLine());

        // Convert pounds to kilograms
        double weightInKg = weightInPounds / 2.2;  // Conversion formula for pounds to kilograms

        // Display the result
        Console.WriteLine($"The weight of the person in pounds is {weightInPounds} and in kg is {weightInKg:F2}");
        // {weightInKg:F2} ensures the weight in kilograms is displayed with two decimal places.
    }
}
