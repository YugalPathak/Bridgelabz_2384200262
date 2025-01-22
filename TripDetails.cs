using System;

class TripDetails
{
    public static void Main(string[] args)
    {
        // Creating an object of the classname
        TripDetails tp = new TripDetails();
        
        // Calling the method
        tp.Trip();
    }

    // Creating a method Trip to display the results
    public void Trip()
    {
        // Taking user inputs to enter name
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        // Taking user input to enter starting city
        Console.Write("Enter starting city: ");
        string fromCity = Console.ReadLine();

        // Taking user input to enter via city
        Console.Write("Enter via city: ");
        string viaCity = Console.ReadLine();

        // Taking user input to enter destination city
        Console.Write("Enter destination city: ");
        string toCity = Console.ReadLine();

        // Taking user input to enter distance from starting city to via city in miles
        Console.Write("Enter distance from starting city to via city (in miles): ");
        double fromToVia = Convert.ToDouble(Console.ReadLine());

        // Taking user input to enter distance from via city to destination city in miles
        Console.Write("Enter distance from via city to final city (in miles): ");
        double viaToFinalCity = Convert.ToDouble(Console.ReadLine());

        // Taking user input to enter total time taken in hours
        Console.Write("Enter total time taken for the journey (in hours): ");
        double timeTaken = Convert.ToDouble(Console.ReadLine());

        // Compute the total distance and total time
        double totalDistance = fromToVia + viaToFinalCity;

        // Display the results
        Console.WriteLine($"The results of the trip are: \n" +
                          $"Name: {name}, \n" +
                          $"Starting City: {fromCity}, \n" +
                          $"Via City: {viaCity}, \n" +
                          $"Destination City: {toCity}, \n" +
                          $"Total Distance: {totalDistance} miles, \n" +
                          $"Total Time: {timeTaken} hours");
    }
}
