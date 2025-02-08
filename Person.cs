using System;

// Base class representing a general person
public class Person
{
    public string Name { get; set; }  // Stores the name of the person
    public int Age { get; set; }      // Stores the age of the person

    // Constructor to initialize name and age
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Virtual method to display general information about a person
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }

    // Virtual method to display the role of the person
    public virtual void DisplayRole()
    {
        Console.WriteLine("Role: Person");
    }
}

// Teacher subclass inherits from Person
public class Teacher : Person
{
    public string Subject { get; set; }  // Stores the subject the teacher teaches

    // Constructor to initialize teacher-specific attributes along with base class attributes
    public Teacher(string name, int age, string subject) : base(name, age)
    {
        Subject = subject;
    }

    // Override method to display teacher-specific information
    public override void DisplayInfo()
    {
        base.DisplayInfo();  // Calls the base class method to display name and age
        Console.WriteLine($"Subject: {Subject}");
    }

    // Override method to display the role of the person as Teacher
    public override void DisplayRole()
    {
        Console.WriteLine("Role: Teacher");
    }
}

// Student subclass inherits from Person
public class Student : Person
{
    public int Grade { get; set; }  // Stores the grade of the student

    // Constructor to initialize student-specific attributes along with base class attributes
    public Student(string name, int age, int grade) : base(name, age)
    {
        Grade = grade;
    }

    // Override method to display student-specific information
    public override void DisplayInfo()
    {
        base.DisplayInfo();  // Calls the base class method to display name and age
        Console.WriteLine($"Grade: {Grade}");
    }

    // Override method to display the role of the person as Student
    public override void DisplayRole()
    {
        Console.WriteLine("Role: Student");
    }
}

// Staff subclass inherits from Person
public class Staff : Person
{
    public string Department { get; set; }  // Stores the department where the staff works

    // Constructor to initialize staff-specific attributes along with base class attributes
    public Staff(string name, int age, string department) : base(name, age)
    {
        Department = department;
    }

    // Override method to display staff-specific information
    public override void DisplayInfo()
    {
        base.DisplayInfo();  // Calls the base class method to display name and age
        Console.WriteLine($"Department: {Department}");
    }

    // Override method to display the role of the person as Staff
    public override void DisplayRole()
    {
        Console.WriteLine("Role: Staff");
    }
}

// Main Program to demonstrate inheritance
public class Program
{
    public static void Main(String[] args)
    {
        // Creating objects for each subclass
        Person teacher = new Teacher("Vishal", 21, "Java");
        Person student = new Student("Madhav", 16, 10);
        Person staff = new Staff("Shivang", 28, "Manager");

        // Displaying information and role of each object
        teacher.DisplayInfo();
        teacher.DisplayRole();
        Console.WriteLine();

        student.DisplayInfo();
        student.DisplayRole();
        Console.WriteLine();

        staff.DisplayInfo();
        staff.DisplayRole();
    }
}