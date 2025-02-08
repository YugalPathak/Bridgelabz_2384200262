using System;

// Superclass representing a generic vehicle
public class Vehicle
{
    public string Model { get; set; }    // Vehicle model
    public int MaxSpeed { get; set; }    // Maximum speed of the vehicle

    // Constructor to initialize Vehicle attributes
    public Vehicle(string model, int maxSpeed)
    {
        Model = model;
        MaxSpeed = maxSpeed;
    }

    // Method to display vehicle details
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Model: {Model}, Max Speed: {MaxSpeed} km/h");
    }
}

// Interface defining refuelable behavior
public interface IRefuelable
{
    void Refuel();  // Method to be implemented by petrol vehicles
}

// ElectricVehicle subclass inheriting from Vehicle
public class ElectricVehicle : Vehicle
{
    public int BatteryCapacity { get; set; }  // Battery capacity in kWh

    // Constructor initializing ElectricVehicle-specific attributes
    public ElectricVehicle(string model, int maxSpeed, int batteryCapacity) : base(model, maxSpeed)
    {
        BatteryCapacity = batteryCapacity;
    }

    // Overriding DisplayInfo to include battery details
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Battery Capacity: {BatteryCapacity} kWh");
    }

    // Method to simulate charging an electric vehicle
    public void Charge()
    {
        Console.WriteLine($"{Model} is charging its battery.");
    }
}

// PetrolVehicle subclass inheriting from Vehicle and implementing Refuelable interface
public class PetrolVehicle : Vehicle, IRefuelable
{
    public int FuelCapacity { get; set; }  // Fuel tank capacity in liters

    // Constructor initializing PetrolVehicle-specific attributes
    public PetrolVehicle(string model, int maxSpeed, int fuelCapacity) : base(model, maxSpeed)
    {
        FuelCapacity = fuelCapacity;
    }

    // Overriding DisplayInfo to include fuel capacity details
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Fuel Capacity: {FuelCapacity} liters");
    }

    // Implementation of the Refuel() method from the Refuelable interface
    public void Refuel()
    {
        Console.WriteLine($"{Model} is refueling.");
    }
}

// Main Program
public class Program
{
    public static void Main(String[] args)
    {
        // Creating objects of ElectricVehicle and PetrolVehicle
        ElectricVehicle tesla = new ElectricVehicle("Tesla Model 3", 200, 75);
        PetrolVehicle ford = new PetrolVehicle("Ford Mustang", 250, 60);

        // Displaying details and performing actions
        Console.WriteLine("Vehicle Details:");
        Console.WriteLine("----------------");
        
        tesla.DisplayInfo();
        tesla.Charge();
        Console.WriteLine();

        ford.DisplayInfo();
        ford.Refuel();
    }
}