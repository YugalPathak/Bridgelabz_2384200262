using System;

// Superclass representing a person in the restaurant
public class Person
{
    public string Name { get; set; }  // Name of the person
    public int Id { get; set; }       // Unique ID

    // Constructor to initialize Person attributes
    public Person(string name, int id)
    {
        Name = name;
        Id = id;
    }

    // Method to display basic details of the person
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"ID: {Id}, Name: {Name}");
    }
}

// Interface defining worker responsibilities
public interface IWorker
{
    void PerformDuties();  // Method that must be implemented by all workers
}

// Chef class inheriting from Person and implementing Worker interface
public class Chef : Person, IWorker
{
    public string Specialty { get; set; }  // Chef's specialty dish or cuisine

    // Constructor initializing Chef-specific attributes along with Person attributes
    public Chef(string name, int id, string specialty) : base(name, id)
    {
        Specialty = specialty;
    }

    // Overriding DisplayInfo() to include chef-specific information
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Role: Chef, Specialty: {Specialty}");
    }

    // Implementation of PerformDuties() for a Chef
    public void PerformDuties()
    {
        Console.WriteLine($"{Name} is cooking delicious {Specialty} dishes.");
    }
}

// Waiter class inheriting from Person and implementing Worker interface
public class Waiter : Person, IWorker
{
    public int TableCount { get; set; }  // Number of tables assigned to the waiter

    // Constructor initializing Waiter-specific attributes along with Person attributes
    public Waiter(string name, int id, int tableCount) : base(name, id)
    {
        TableCount = tableCount;
    }

    // Overriding DisplayInfo() to include waiter-specific information
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Role: Waiter, Assigned Tables: {TableCount}");
    }

    // Implementation of PerformDuties() for a Waiter
    public void PerformDuties()
    {
        Console.WriteLine($"{Name} is serving customers at {TableCount} tables.");
    }
}

// Main Program
public class Program
{
    public static void Main(String[] args)
    {
        // Creating objects of Chef and Waiter
        IWorker chef = new Chef("Gordon Ramsay", 101, "Italian Cuisine");
        IWorker waiter = new Waiter("John Doe", 201, 5);

        // Displaying details and performing duties
        Console.WriteLine("Restaurant Workers Details:");
        Console.WriteLine("---------------------------");
        
        ((Person)chef).DisplayInfo();  // Casting to Person to call DisplayInfo()
        chef.PerformDuties();          // Calling the duty method
        Console.WriteLine();

        ((Person)waiter).DisplayInfo(); // Casting to Person to call DisplayInfo()
        waiter.PerformDuties();         // Calling the duty method
    }
}