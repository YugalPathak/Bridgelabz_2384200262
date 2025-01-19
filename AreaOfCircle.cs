using System;

class AreaOfCircle
{
    static void Main()
    {
        Console.Write("Enter the radius of the circle: ");
        double radius = double.Parse(Console.ReadLine());

        double area = Math.PI * radius * radius;

        Console.WriteLine("The area of the circle is:" + area);
    }
}







