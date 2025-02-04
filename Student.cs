
using System;

class Student
{
    // Public roll number
    public int rollNumber;

    // Protected name (accessible by subclasses)
    protected string name;

    // Private CGPA (accessible only within this class)
    private double CGPA;

    // Constructor to initialize the student details
    public Student(int rollNumber, string name, double CGPA)
    {
        this.rollNumber = rollNumber;
        this.name = name;
        this.CGPA = CGPA;
    }

    // Public method to get the CGPA
    public double GetCGPA()
    {
        return CGPA;
    }

    // Public method to set the CGPA
    public void SetCGPA(double newCGPA)
    {
        if (newCGPA >= 0 && newCGPA <= 10.0)
        {
            CGPA = newCGPA;
            Console.WriteLine("CGPA updated successfully.");
        }
        else
        {
            Console.WriteLine("Invalid CGPA value.");
        }
    }

    // Method to display student details
    public void DisplayStudentDetails()
    {
        Console.WriteLine($"Roll Number: {rollNumber}");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"CGPA: {CGPA}");
    }
}

class PostgraduateStudent : Student
{
    // Constructor for PostgraduateStudent, which calls the base constructor of Student
    public PostgraduateStudent(int rollNumber, string name, double CGPA)
        : base(rollNumber, name, CGPA)
    {
    }

    // Method to display the postgraduate student's details (demonstrating access to protected member 'name')
    public void DisplayPostgraduateDetails()
    {
        Console.WriteLine($"Roll Number: {rollNumber}");
        Console.WriteLine($"Name: {name} (Postgraduate)");
        Console.WriteLine($"CGPA: {GetCGPA()}");
    }
}

class Program
{
    static void Main()
    {
        // Create a regular student object
        Student student1 = new Student(262, "Yugal", 8.0);
        student1.DisplayStudentDetails();

        // Modify CGPA of the student
        student1.SetCGPA(8.6);
        Console.WriteLine($"Updated CGPA: {student1.GetCGPA()}\n");

        // Create a postgraduate student object
        PostgraduateStudent pgStudent = new PostgraduateStudent(263, "Neelanshu", 7.5);
        pgStudent.DisplayPostgraduateDetails();

        // Modify CGPA of the postgraduate student
        pgStudent.SetCGPA(8.9);
        Console.WriteLine($"Updated CGPA: {pgStudent.GetCGPA()}\n");
    }
}

