using System;

public class TemperatureConversion
{
    public static void Main(String[] args)
    {
        // Creating an object of the class
        TemperatureConversion tc = new TemperatureConversion();
        
        // Calling the method
        tc.Conversion();
    }

    // Creating a method Conversion to display the result
    public void Conversion()
    {
        // Taking user input for temperature in Celsius
        Console.Write("Enter the temperature in Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());
        
        // Convert Celsius to Fahrenheit using the formula: (°C × 9/5) + 32 = °F
        double fahrenheitResult = (celsius * 9 / 5) + 32;
        
        // Displaying the result
        Console.WriteLine($"The {celsius} Celsius is {fahrenheitResult} Fahrenheit");
    }
}
