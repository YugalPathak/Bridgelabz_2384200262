using System;
using System.Collections.Generic;

class School
{
    public string Name;
    public List<Student> Students = new List<Student>(); // Aggregation: School has Students

    public School(string name)
    {
        Name = name;
    }

    // Add a student to the school
    public void AddStudent(Student student)
    {
        Students.Add(student);
    }

    // Display all students in the school
    public void ShowStudents()
    {
        Console.WriteLine($"\nSchool: {Name}");
        foreach (var student in Students)
        {
            Console.WriteLine($"Student: {student.Name}");
        }
    }
}

class Student
{
    public string Name;
    private List<Course> courses = new List<Course>(); // Association: Student has multiple Courses

    public Student(string name)
    {
        Name = name;
    }

    // Enroll in a Course
    public void EnrollInCourse(Course course)
    {
        if (!courses.Contains(course))
        {
            courses.Add(course);
            course.AddStudent(this); // Establishing two-way relationship
        }
    }

    // View enrolled courses
    public void ViewCourses()
    {
        Console.WriteLine($"\n{Name} is enrolled in the following courses:");
        foreach (var course in courses)
        {
            Console.WriteLine($"  - {course.CourseName}");
        }
    }
}

class Course
{
    public string CourseName;
    private List<Student> students = new List<Student>(); // Association: Course has multiple Students

    public Course(string courseName)
    {
        CourseName = courseName;
    }

    // Add a student to the course
    public void AddStudent(Student student)
    {
        if (!students.Contains(student))
        {
            students.Add(student);
        }
    }

    // View students enrolled in the course
    public void ViewStudents()
    {
        Console.WriteLine($"\nCourse: {CourseName} has the following students:");
        foreach (var student in students)
        {
            Console.WriteLine($"  - {student.Name}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a School
        School school = new School("Kanha Makhan Public School");

        // Create Students
        Student student1 = new Student("Yugal");
        Student student2 = new Student("Shivang");
        Student student3 = new Student("Chotu");

        // Add Students to School (Aggregation)
        school.AddStudent(student1);
        school.AddStudent(student2);
        school.AddStudent(student3);

        // Create Courses
        Course math = new Course("Mathematics");
        Course science = new Course("Science");

        // Students enroll in courses (Association - Many-to-Many)
        student1.EnrollInCourse(math);
        student1.EnrollInCourse(science);
        student2.EnrollInCourse(math);
        student3.EnrollInCourse(science);

        // Display Students in the School
        school.ShowStudents();

        // Display Students enrolled in each Course
        math.ViewStudents();
        science.ViewStudents();

        // Each Student views their enrolled Courses
        student1.ViewCourses();
        student2.ViewCourses();
        student3.ViewCourses();
    }
}