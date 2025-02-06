using System;
using System.Collections.Generic;

class Course
{
    public string Name { get; set; }
    public Professor Professor { get; set; }  // Aggregation: A course is taught by one professor.
    public List<Student> Students { get; set; }  // A course can have multiple students.

    public Course(string name)
    {
        Name = name;
        Students = new List<Student>();
    }

    public void AssignProfessor(Professor professor)
    {
        Professor = professor;
        Console.WriteLine($"{professor.Name} is now assigned to teach the course: {Name}");
    }

    public void AddStudent(Student student)
    {
        Students.Add(student);
        Console.WriteLine($"{student.Name} has enrolled in the course: {Name}");
    }

    public override string ToString()
    {
        return $"{Name} (Professor: {Professor.Name}, Students Enrolled: {Students.Count})";
    }
}

class Professor
{
    public string Name { get; set; }
    public List<Course> Courses { get; set; }  // A professor can teach multiple courses.

    public Professor(string name)
    {
        Name = name;
        Courses = new List<Course>();
    }

    public void TeachCourse(Course course)
    {
        course.AssignProfessor(this);
        Courses.Add(course);
    }

    public void ShowCourses()
    {
        Console.WriteLine($"{Name} teaches the following courses:");
        foreach (var course in Courses)
        {
            Console.WriteLine(course.Name);
        }
    }
}

class Student
{
    public string Name { get; set; }
    public List<Course> EnrolledCourses { get; set; }  // A student can enroll in multiple courses.

    public Student(string name)
    {
        Name = name;
        EnrolledCourses = new List<Course>();
    }

    public void EnrollCourse(Course course)
    {
        course.AddStudent(this);
        EnrolledCourses.Add(course);
    }

    public void ShowEnrolledCourses()
    {
        Console.WriteLine($"{Name} is enrolled in the following courses:");
        foreach (var course in EnrolledCourses)
        {
            Console.WriteLine(course.Name);
        }
    }
}

class University
{
    public string Name { get; set; }
    public List<Student> Students { get; set; }
    public List<Professor> Professors { get; set; }
    public List<Course> Courses { get; set; }

    public University(string name)
    {
        Name = name;
        Students = new List<Student>();
        Professors = new List<Professor>();
        Courses = new List<Course>();
    }

    public void AddStudent(Student student)
    {
        Students.Add(student);
    }

    public void AddProfessor(Professor professor)
    {
        Professors.Add(professor);
    }

    public void AddCourse(Course course)
    {
        Courses.Add(course);
    }

    public void ShowUniversityInfo()
    {
        Console.WriteLine($"University: {Name}");
        Console.WriteLine("Courses Offered:");
        foreach (var course in Courses)
        {
            Console.WriteLine(course);
        }
    }
}

class Program
{
    static void Main()
    {
        // Create a university
        University university = new University("GLA University");

        // Create students
        Student student1 = new Student("Yugal");
        Student student2 = new Student("Shivang");

        // Add students to the university
        university.AddStudent(student1);
        university.AddStudent(student2);

        // Create professors
        Professor professor1 = new Professor("Dr. Jaden");
        Professor professor2 = new Professor("Dr. Harry");

        // Add professors to the university
        university.AddProfessor(professor1);
        university.AddProfessor(professor2);

        // Create courses
        Course course1 = new Course("English");
        Course course2 = new Course("History");

        // Add courses to the university
        university.AddCourse(course1);
        university.AddCourse(course2);

        // Professors teach courses
        professor1.TeachCourse(course1);
        professor2.TeachCourse(course2);

        // Students enroll in courses
        student1.EnrollCourse(course1);
        student2.EnrollCourse(course2);
        student1.EnrollCourse(course2);

        // Show university information
        university.ShowUniversityInfo();

        // Show the courses each professor teaches
        professor1.ShowCourses();
        professor2.ShowCourses();

        // Show the courses each student is enrolled in
        student1.ShowEnrolledCourses();
        student2.ShowEnrolledCourses();
    }
}