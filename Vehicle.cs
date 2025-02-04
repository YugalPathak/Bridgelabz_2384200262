
using System;

class Vehicle
{
    // Class variable to store the fixed registration fee for all vehicles
    public static double registrationFee = 500.0;

    // Instance variables
    public string ownerName;
    public string vehicleType;

    // Constructor to initialize the vehicle details
    public Vehicle(string ownerName, string vehicleType)
    {
        this.ownerName = ownerName;
        this.vehicleType = vehicleType;
    }

    // Instance method to display the owner and vehicle details
    public void DisplayVehicleDetails()
    {
        Console.WriteLine($"Owner Name: {ownerName}");
        Console.WriteLine($"Vehicle Type: {vehicleType}");
        Console.WriteLine($"Registration Fee: {registrationFee}");
    }

    // Class method to update the registration fee for all vehicles
    public static void UpdateRegistrationFee(double newFee)
    {
        registrationFee = newFee;
        Console.WriteLine($"Registration fee updated to: {registrationFee}");
    }
}

class Program
{
    static void Main()
    {
        // Creating vehicle instances
        Vehicle vehicle1 = new Vehicle("Yugal", "Car");
        Vehicle vehicle2 = new Vehicle("Neelanshu", "Scooty");

        // Displaying vehicle details before updating the registration fee
        Console.WriteLine("Before updating registration fee:\n");
        vehicle1.DisplayVehicleDetails();
        vehicle2.DisplayVehicleDetails();

        // Updating the registration fee for all vehicles
        Vehicle.UpdateRegistrationFee(1000.0);

        // Displaying vehicle details after updating the registration fee
        Console.WriteLine("\nAfter updating registration fee:\n");
        vehicle1.DisplayVehicleDetails();
        vehicle2.DisplayVehicleDetails();
    }
}

