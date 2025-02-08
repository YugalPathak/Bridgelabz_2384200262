using System;
// Base class representing a Book
public class Book
{
    public string Title { get; set; } // Title of the book
    public int PublicationYear { get; set; } // Year of publication

    // Constructor to initialize book details
    public Book(string title, int publicationYear)
    {
        Title = title;
        PublicationYear = publicationYear;
    }

    // Virtual method to display book details
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Title : {Title} PublicationYear : {PublicationYear}");
    }
}

// Derived class representing an Author, inheriting from Book
public class Author : Book
{
    public string Name { get; set; } // Author's name
    public string Bio { get; set; } // Short biography of the author

    // Constructor for Author, calling the base class constructor
    public Author(string title, int publicationYear, string name, string bio) : base(title, publicationYear) 
    { 
        Name = name;
        Bio = bio;      
    }

    // Overriding DisplayInfo to include author details
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Name of the author : {Name} Bio : {Bio}");
    }
}

// Main class containing the program entry point
public class Program
{
    public static void Main(String[] args)
    {
        // Creating a Book object
        Book myBook = new Book("Java Programming" , 1990);
        
        // Creating an Author object, stored as a Book type (polymorphism)
        Book author = new Author("The God Of Small Things" , 1997, "Arundhati Roy" , "Roy is an Indian author and political activist");

        // Displaying book details
        myBook.DisplayInfo();
        Console.WriteLine();
        
        // Displaying author details (dynamic method dispatch)
        author.DisplayInfo();
    }
}