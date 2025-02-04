
using System;

class Book
{
    // Public variable ISBN
    public string ISBN;

    // Protected variable title
    protected string title;

    // Private variable author
    private string author;

    // Constructor to initialize book details
    public Book(string ISBN, string title, string author)
    {
        this.ISBN = ISBN;
        this.title = title;
        this.author = author;
    }

    // Public method to get the author's name
    public string GetAuthor()
    {
        return author;
    }

    // Public method to set the author's name
    public void SetAuthor(string authorName)
    {
        author = authorName;
        Console.WriteLine("Author name updated successfully.");
    }

    // Method to display book details
    public void DisplayBookDetails()
    {
        Console.WriteLine($"ISBN: {ISBN}");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Author: {author}");
    }
}

class EBook : Book
{
    // Constructor for EBook, calling the base class constructor
    public EBook(string ISBN, string title, string author)
        : base(ISBN, title, author)
    {
    }

    // Method to display the EBook details (demonstrates access to ISBN and title)
    public void DisplayEBookDetails()
    {
        Console.WriteLine($"ISBN: {ISBN} (EBook)");
        Console.WriteLine($"Title: {title} (EBook)");
    }
}

class Program
{
    static void Main()
    {
        // Creating a regular Book object
        Book book1 = new Book("978-3-16-148410-0", "The Great Gatsby", "F. Scott Fitzgerald");
        book1.DisplayBookDetails();

        // Modify the author's name using SetAuthor
        book1.SetAuthor("F. S. Fitzgerald");
        Console.WriteLine($"Updated Author: {book1.GetAuthor()}\n");

        // Creating an EBook object
        EBook eBook1 = new EBook("978-1-23-456789-0", "Digital Marketing 101", "John Doe");
        eBook1.DisplayEBookDetails();

        // Modify the author's name using SetAuthor for the EBook
        eBook1.SetAuthor("Jane Doe");
        Console.WriteLine($"Updated Author: {eBook1.GetAuthor()}\n");

        // Display EBook details again after modifying the author
        eBook1.DisplayEBookDetails();
    }
}

