using System;

// Base class representing a generic smart home device
public class Devices
{
    public string DeviceId { get; set; } // Unique identifier for the device
    public string Status { get; set; } // Device status (e.g., ON, OFF)

    // Constructor to initialize device properties
    public Devices(string deviceId, string status)
    {
        DeviceId = deviceId;
        Status = status;
    }

    // Virtual method to display device status
    public virtual void DisplayStatus()
    {
        Console.WriteLine($"Device ID: {DeviceId}, Status: {Status}");
    }
}

// Derived class representing a thermostat, inheriting from Devices
public class Thermostat : Devices
{
    public double TemperatureSetting { get; set; } // Temperature setting for the thermostat

    // Constructor for Thermostat, calling the base class constructor
    public Thermostat(string deviceId, string status, double temperatureSetting) : base(deviceId, status)
    {
        TemperatureSetting = temperatureSetting;
    }

    // Overriding DisplayStatus to include temperature setting
    public override void DisplayStatus()
    {
        base.DisplayStatus();
        Console.WriteLine($"Temperature Setting: {TemperatureSetting}°C");
    }
}

// Main class containing the program entry point
public class Program
{
    public static void Main(String[] args)
    {
        // Creating a generic Devices object
        Devices device = new Devices("Device01", "ON");
        
        // Creating a Thermostat object
        Thermostat thermostat = new Thermostat("Thermo01", "Active", 22.5);

        // Displaying status of both devices
        device.DisplayStatus();
        Console.WriteLine();
        thermostat.DisplayStatus();
    }
}