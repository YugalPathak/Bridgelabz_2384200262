using System;
using System.Collections.Generic;

class Faculty
{
    public string Name { get; set; }

    public Faculty(string name)
    {
        Name = name;
    }

    public override string ToString()
    {
        return $"Faculty: {Name}";
    }
}

class Department
{
    public string Name { get; set; }
    public List<Faculty> Faculties { get; set; }

    public Department(string name)
    {
        Name = name;
        Faculties = new List<Faculty>();
    }

    public void AddFaculty(Faculty faculty)
    {
        Faculties.Add(faculty);
    }

    public override string ToString()
    {
        List<string> facultyNames = new List<string>();
        foreach (var faculty in Faculties)
        {
            facultyNames.Add(faculty.Name);
        }
        return $"Department: {Name}, Faculties: {string.Join(", ", facultyNames)}";
    }
}

class University
{
    public string Name { get; set; }
    public List<Department> Departments { get; set; }

    public University(string name)
    {
        Name = name;
        Departments = new List<Department>();
    }

    public void AddDepartment(Department department)
    {
        Departments.Add(department);
    }

    public void Delete()
    {
        Console.WriteLine($"University '{Name}' and all its departments are being deleted.");
        Departments.Clear();  // Deletes all departments
    }

    public override string ToString()
    {
        List<string> departmentNames = new List<string>();
        foreach (var dept in Departments)
        {
            departmentNames.Add(dept.Name);
        }
        return $"University: {Name}, Departments: {string.Join(", ", departmentNames)}";
    }
}

class Program
{
    static void Main()
    {
        // Create some faculty members
        Faculty faculty1 = new Faculty("Dr. Roman");
        Faculty faculty2 = new Faculty("Dr. George");
        Faculty faculty3 = new Faculty("Dr. Stephan");

        // Create some departments
        Department dept1 = new Department("History");
        Department dept2 = new Department("English");

        // Assign faculties to departments
        dept1.AddFaculty(faculty1);
        dept1.AddFaculty(faculty2);
        dept2.AddFaculty(faculty3);

        // Create a university
        University university = new University("GLA University");

        // Add departments to the university
        university.AddDepartment(dept1);
        university.AddDepartment(dept2);

        // Demonstrating the relationships
        Console.WriteLine(university);
        Console.WriteLine(dept1);
        Console.WriteLine(dept2);

        // Deleting the university
        university.Delete();

        // After deletion of the university, the departments are also deleted
        Console.WriteLine("\nAfter deleting the university:");
        Console.WriteLine(university);
        Console.WriteLine(dept1);
        Console.WriteLine(dept2);

        // Faculty members can still exist independently of departments
        Console.WriteLine($"\n{faculty1}");
        Console.WriteLine(faculty2);
        Console.WriteLine(faculty3);
    }
}