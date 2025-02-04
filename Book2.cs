using System;

class Book
{
    // Properties
    public string Title { get; set; }
    public string Author { get; set; }
    public double Price { get; set; }
    public bool IsAvailable { get; set; }

    // Default Constructor
    public Book()
    {
        Title = "Unknown";
        Author = "Unknown";
        Price = 0.0;
        IsAvailable = true;
    }

    // Parameterized Constructor
    public Book(string title, string author, double price, bool isAvailable)
    {
        this.Title = title;
        this.Author = author;
        this.Price = price;
        this.IsAvailable = isAvailable;
    }

    // Method to Borrow a Book
    public void BorrowBook()
    {
        if (IsAvailable)
        {
            IsAvailable = false;
            Console.WriteLine($"You have borrowed '{Title}' by {Author}.");
        }
        else
        {
            Console.WriteLine($"Sorry, '{Title}' is currently unavailable.");
        }
    }

    // Method to Display Book Details
    public void Display()
    {
        Console.WriteLine($"Title: {Title}, Author: {Author}, Price: ${Price}, Available: {IsAvailable}");
    }
}

class Program
{
    static void Main()
    {
        // Creating a book instance
        Book book1 = new Book("The Great Gatsby", "F. Scott Fitzgerald", 10.99, true);
        book1.Display();

        // Borrowing the book
        book1.BorrowBook();
        book1.Display();

        // Trying to borrow again
        book1.BorrowBook();
    }
}