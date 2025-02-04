
using System;

class Employee
{
    // Public variable employeeID
    public int employeeID;

    // Protected variable department
    protected string department;

    // Private variable salary
    private double salary;

    // Constructor to initialize employee details
    public Employee(int employeeID, string department, double salary)
    {
        this.employeeID = employeeID;
        this.department = department;
        this.salary = salary;
    }

    // Public method to get the salary
    public double GetSalary()
    {
        return salary;
    }

    // Public method to modify the salary
    public void SetSalary(double newSalary)
    {
        if (newSalary > 0)
        {
            salary = newSalary;
            Console.WriteLine("Salary updated successfully.");
        }
        else
        {
            Console.WriteLine("Invalid salary value. Salary must be positive.");
        }
    }

    // Method to display employee details
    public void DisplayEmployeeDetails()
    {
        Console.WriteLine($"Employee ID: {employeeID}");
        Console.WriteLine($"Department: {department}");
        Console.WriteLine($"Salary: {salary}");
    }
}

class Manager : Employee
{
    // Constructor for Manager, calling the base class constructor
    public Manager(int employeeID, string department, double salary)
        : base(employeeID, department, salary)
    {
    }

    // Method to display the manager's details (demonstrates access to employeeID and department)
    public void DisplayManagerDetails()
    {
        Console.WriteLine($"Employee ID: {employeeID} (Manager)");
        Console.WriteLine($"Department: {department} (Manager)");
        Console.WriteLine($"Salary: {GetSalary()}");
    }
}

class Program
{
    static void Main()
    {
        // Create a regular Employee object
        Employee employee1 = new Employee(101, "Sales", 50000);
        employee1.DisplayEmployeeDetails();

        // Modify the salary using SetSalary method
        employee1.SetSalary(55000);
        Console.WriteLine($"Updated Salary: ${employee1.GetSalary()}\n");

        // Create a Manager object
        Manager manager1 = new Manager(102, "HR", 75000);
        manager1.DisplayManagerDetails();

        // Modify the salary for the Manager object
        manager1.SetSalary(80000);
        Console.WriteLine($"Updated Salary: ${manager1.GetSalary()}\n");

        // Display Manager details again after modifying the salary
        manager1.DisplayManagerDetails();
    }
}

