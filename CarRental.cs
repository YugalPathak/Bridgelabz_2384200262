
using System;

class CarRental
{
    // Properties
    public string CustomerName { get; set; }
    public string CarModel { get; set; }
    public int RentalDays { get; set; }
    public double DailyRate { get; set; } = 100.0; // Default daily rate

    // Default Constructor
    public CarRental()
    {
        CustomerName = "John Doe";
        CarModel = "Standard";
        RentalDays = 1;
    }

    // Parameterized Constructor
    public CarRental(string customerName, string carModel, int rentalDays)
    {
        this.CustomerName = customerName;
        this.CarModel = carModel;
        this.RentalDays = rentalDays > 0 ? rentalDays : 1;
    }

    // Method to Calculate Total Cost
    public double CalculateTotalCost()
    {
        return RentalDays * DailyRate;
    }

    // Method to Display Rental Details
    public void Display()
    {
        Console.WriteLine($"Customer: {CustomerName}, Car Model: {CarModel}, Rental Days: {RentalDays}, Total Cost: ${CalculateTotalCost():F2}");
    }
}

class Program
{
    static void Main()
    {
        // Using Default Constructor
        CarRental rental1 = new CarRental();
        rental1.Display();
        
        // Using Parameterized Constructor
        CarRental rental2 = new CarRental("Yugal", "Tata", 2);
        rental2.Display();
    }
}

