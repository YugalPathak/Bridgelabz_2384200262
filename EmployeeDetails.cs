using System;

public class Employee
{
    // Fields (Attributes)
    private string Name { get; set; }
    private int Id { get; set; }
    private double Salary { get; set; }

    // Constructor
    public Employee(string name, int id, int salary)
    {
        Name = name;
        Id = id;
        Salary = salary;
    }

    public static void Main(string[] args)
    {
        // Creating an object of the class
        Employee emp = new Employee("Yugal Krishna Pathak", 238, 150800);

        // Calling the method
        emp.ShowDetails();
    }

    // Method to display the details
    public void ShowDetails()
    {
        Console.WriteLine("Employee Name: " + Name);
        Console.WriteLine("Employee Id: " + Id);
        Console.WriteLine("Employee salary: " + Salary);
    }
}