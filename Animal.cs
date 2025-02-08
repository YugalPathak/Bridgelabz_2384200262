using System;

// Base class representing an Animal
public class Animal
{
    public string Name { get; set; } // Property for storing the name of the animal
    public int Age { get; set; } // Property for storing the age of the animal

    // Constructor to initialize the name and age of the animal
    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Virtual method to be overridden by subclasses
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

// Derived class representing a Dog
public class Dog : Animal
{
    // Constructor for Dog, calling the base class constructor
    public Dog(string name, int age) : base(name, age) { }

    // Overriding MakeSound method to specify Dog's sound
    public override void MakeSound()
    {
        Console.WriteLine("Dog Barks");
    }
}

// Derived class representing a Cat
public class Cat : Animal
{
    // Constructor for Cat, calling the base class constructor
    public Cat(string name, int age) : base(name, age) { }

    // Overriding MakeSound method to specify Cat's sound
    public override void MakeSound()
    {
        Console.WriteLine("Cat meows");
    }
}

// Derived class representing a Bird
public class Bird : Animal
{
    // Constructor for Bird, calling the base class constructor
    public Bird(string name, int age) : base(name, age) { }

    // Overriding MakeSound method to specify Bird's sound
    public override void MakeSound()
    {
        Console.WriteLine("Bird Chirps");
    }
}

// Main Program to test polymorphism
public class Program
{
    public static void Main(String[] args)
    {
        // Creating an Animal object
        Animal animal = new Animal("Elephant", 4);

        // Creating objects of subclasses
        Animal myDog = new Dog("Oscar", 3);
        Animal myCat = new Cat("Cindrella", 2);
        Animal myBird = new Bird("Tweety", 1);

        // Calling MakeSound method on each object
        animal.MakeSound();  // Output: Animal makes a sound
        myDog.MakeSound();   // Output: Dog Barks
        myCat.MakeSound();   // Output: Cat meows
        myBird.MakeSound();  // Output: Bird Chirps
    }
}