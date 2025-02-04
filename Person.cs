
using System;

class Person
{
    // Properties
    public string Name { get; set; }
    public int Age { get; set; }

    // Parameterized Constructor
    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    // Copy Constructor
    public Person(Person other)
    {
        this.Name = other.Name;
        this.Age = other.Age;
    }

    // Method to Display Person Details
    public void Display()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

class Program
{
    static void Main()
    {
        // Creating a Person object
        Person person1 = new Person("Yugal", 22);
        person1.Display();

        // Creating a copy of person1
        Person person2 = new Person(person1);
        person2.Display();
    }
}

