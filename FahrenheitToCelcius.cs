using System;

public class TemperatureConversions
{
    public static void Main(String[] args)
    {
        // Creating an object of the class
        TemperatureConversions tc = new TemperatureConversions();
        
        // Calling the method
        tc.Conversion();
    }

    // Creating a method Conversion to display the result
    public void Conversion()
    {
        // Taking user input for temperature in Fahrenheit
        Console.Write("Enter the temperature in Fahrenheit: ");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());
        
        // Convert Fahrenheit to Celsius using the formula: (°F − 32) x 5/9 = °C
        double celsiusResult = (fahrenheit - 32) * 5 / 9;
        
        // Displaying the result
        Console.WriteLine($"The {fahrenheit} Fahrenheit is {celsiusResult} Celsius");
    }
}
