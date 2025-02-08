using System;

// Base class representing an Employee
public class Employee
{
    public string Name { get; set; } // Employee's name
    public int Id { get; set; } // Employee ID
    public double Salary { get; set; } // Employee salary

    // Constructor to initialize employee details
    public Employee(string name, int id, double salary)
    {
        Name = name;
        Id = id;
        Salary = salary;
    }

    // Virtual method to display employee details
    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Name : {Name} Id : {Id} Salary : {Salary}");
    }
}

// Derived class representing a Manager
public class Manager : Employee
{
    public int TeamSize { get; set; } // Number of team members

    // Constructor for Manager, calling the base class constructor
    public Manager(string name, int id, double salary, int teamSize) : base(name, id, salary) 
    { 
        TeamSize = teamSize; 
    }

    // Overriding DisplayDetails to include TeamSize
    public override void DisplayDetails()
    {
        Console.WriteLine($"Name : {Name} Id : {Id} Salary : {Salary} TeamSize : {TeamSize}");
    }
}

// Derived class representing a Developer
public class Developer : Employee
{
    public string ProgrammingLanguage { get; set; } // Primary programming language

    // Constructor for Developer, calling the base class constructor
    public Developer(string name, int id, double salary, string programmingLanguage) : base(name, id, salary)
    {
        ProgrammingLanguage = programmingLanguage;
    }

    // Overriding DisplayDetails to include ProgrammingLanguage
    public override void DisplayDetails()
    {
        Console.WriteLine($"Name : {Name} Id : {Id} Salary : {Salary} Programming Language : {ProgrammingLanguage}");
    }
}

// Derived class representing an Intern
public class Intern : Employee
{
    public string InternshipDuration { get; set; } // Duration of the internship

    // Constructor for Intern, calling the base class constructor
    public Intern(string name, int id, double salary, string internshipDuration) : base(name, id, salary) 
    {
        InternshipDuration = internshipDuration;
    }

    // Overriding DisplayDetails to include InternshipDuration
    public override void DisplayDetails()
    {
        Console.WriteLine($"Name : {Name} Id : {Id} Salary : {Salary} InternshipDuration : {InternshipDuration}");
    }
}

// Main class containing the program entry point
public class Program
{
    public static void Main(String[] args)
    {
        // Creating different types of employees
        Employee employee = new Employee("Yugal", 100, 80000);
        Employee manager = new Manager("Neelanshu", 101, 60000, 5);
        Employee developer = new Developer("Chotu", 102, 40000, "Java");
        Employee intern = new Intern("Shivang", 103, 20000, "Six Months");

        // Displaying details for each employee
        employee.DisplayDetails(); 
        manager.DisplayDetails();
        developer.DisplayDetails();
        intern.DisplayDetails();      
    }
}