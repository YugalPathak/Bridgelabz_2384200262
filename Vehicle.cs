using System;

// Base class representing a Vehicle
public class Vehicle
{
    public int MaxSpeed { get; set; } // Maximum speed of the vehicle
    public string FuelType { get; set; } // Type of fuel the vehicle uses

    // Constructor to initialize max speed and fuel type
    public Vehicle(int maxSpeed, string fuelType)
    {
        MaxSpeed = maxSpeed;
        FuelType = fuelType;
    }

    // Virtual method to display vehicle information
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"MaxSpeed : {MaxSpeed} FuelType : {FuelType}");
    }
}

// Derived class representing a Car
public class Car : Vehicle
{
    public int SeatCapacity { get; set; } // Number of seats in the car

    // Constructor for Car, calling the base class constructor
    public Car(int maxSpeed, string fuelType, int seatCapacity) : base(maxSpeed, fuelType) 
    { 
        SeatCapacity = seatCapacity; 
    }

    // Overriding DisplayInfo to include SeatCapacity
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"SeatCapacity : {SeatCapacity}");
    }
}

// Derived class representing a Truck
public class Truck : Vehicle
{
    public int PayloadCapacity { get; set; } // Maximum payload capacity in kg

    // Constructor for Truck, calling the base class constructor
    public Truck(int maxSpeed, string fuelType, int payloadCapacity) : base(maxSpeed, fuelType)
    {
        PayloadCapacity = payloadCapacity;
    }

    // Overriding DisplayInfo to include PayloadCapacity
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"PayloadCapacity : {PayloadCapacity}");
    }
}

// Derived class representing a Motorcycle
public class Motorcycle : Vehicle
{
    public bool HasSidecar { get; set; } // Boolean flag indicating if the motorcycle has a sidecar

    // Constructor for Motorcycle, calling the base class constructor
    public Motorcycle(int maxSpeed, string fuelType, bool hasSidecar ) : base(maxSpeed, fuelType) 
    {
        HasSidecar = hasSidecar;
    }

    // Overriding DisplayInfo to include HasSidecar
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Has Sidecar: {HasSidecar}");
    }
}

// Main class containing the program entry point
public class Program
{
    public static void Main(String[] args)
    {
        // Array of Vehicle objects storing different types of vehicles
        Vehicle[] vehicles = new Vehicle[]
        {
            new Car(200, "Petrol", 5),
            new Truck(120, "Diesel", 10000),
            new Motorcycle(180, "Petrol", false)
        };

        // Looping through each vehicle and calling DisplayInfo
        foreach (Vehicle vehicle in vehicles)
        {
            vehicle.DisplayInfo(); // Dynamic method dispatch occurs here
            Console.WriteLine(); // Adding space between vehicle details
        }
    }
}