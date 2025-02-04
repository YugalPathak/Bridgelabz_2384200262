using System;

class HotelBooking
{
    // Properties
    public string GuestName { get; set; }
    public string RoomType { get; set; }
    public int Nights { get; set; }

    // Default Constructor
    public HotelBooking()
    {
        GuestName = "Yugal";
        RoomType = "Standard";
        Nights = 2;
    }

    // Parameterized Constructor
    public HotelBooking(string guestName, string roomType, int nights)
    {
        this.GuestName = guestName;
        this.RoomType = roomType;
        this.Nights = nights > 0 ? nights : 1;
    }

    // Copy Constructor
    public HotelBooking(HotelBooking other)
    {
        this.GuestName = other.GuestName;
        this.RoomType = other.RoomType;
        this.Nights = other.Nights;
    }

    // Method to Display Booking Details
    public void Display()
    {
        Console.WriteLine($"Guest: {GuestName}, Room Type: {RoomType}, Nights: {Nights}");
    }
}

class Program
{
    static void Main()
    {
        // Using Default Constructor
        HotelBooking booking1 = new HotelBooking();
        booking1.Display();
        
        // Using Parameterized Constructor
        HotelBooking booking2 = new HotelBooking("Johnson", "Deluxe", 3);
        booking2.Display();

        // Using Copy Constructor
        HotelBooking booking3 = new HotelBooking(booking2);
        booking3.Display();
    }
}