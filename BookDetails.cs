using System;

public class Book
{
    // Fields (Attributes)
    private string Title { get; set; }
    private double Price { get; set; }

    // Constructor
    public Book(string title, double price)
    {
        Title = title;
        Price = price;
    }

    public static void Main(string[] args)
    {
        // Creating an object of this class
        Book book = new Book("Harry Potter", 780);

        // Calling the method
        book.ShowDetails();
    }

    // Method to display the details
    public void ShowDetails()
    {
        Console.WriteLine("Title of the book: " + Title);
        Console.WriteLine("Price of the book: " + Price);
    }
}