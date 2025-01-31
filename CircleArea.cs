using System;

public class Circle
{
    // Fields (Attributes)
    private double Radius { get; set; }

    // Constructor
    public Circle(double radius)
    {
        Radius = radius;
    }

    public static void Main(string[] args)
    {
        // Creating an object of the classname
        Circle circle = new Circle(7.64);

        // Calling the method
        circle.ShowDetails();
    }

    // Method to calculate area
    public double FindArea()
    {
        return Math.PI * Radius * Radius;
    }

    // Method to calculate circumference
    public double FindCircumference()
    {
        return 2 * Math.PI * Radius;
    }

    // Method to display the details
    public void ShowDetails()
    {
        Console.WriteLine("Radius: " + Radius);
        Console.WriteLine("Area: " + FindArea());
        Console.WriteLine("Circumference: " + FindCircumference());
    }
}

