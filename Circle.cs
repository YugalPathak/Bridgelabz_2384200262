
using System;

class Circle
{
    public double Radius { get; set; }

    // Default Constructor
    public Circle() : this(1.0) // Calls the parameterized constructor
    {
    }

    // Parameterized Constructor
    public Circle(double radius)
    {
        this.Radius = radius > 0 ? radius : 1.0;
    }

    public void Display()
    {
        Console.WriteLine($"Radius: {Radius}");
    }
}

class Program
{
    static void Main()
    {
        Circle c1 = new Circle();  // Calls default constructor
        c1.Display();

        Circle c2 = new Circle(7.25);  // Calls parameterized constructor
        c2.Display();
    }
}

