using System;

class Course
{
    // Class variable to store the common institute name for all courses
    public static string instituteName = "GLA University";

    // Instance variables
    public string courseName;
    public double duration; // Duration in years
    public double fee;

    // Constructor to initialize the course details
    public Course(string courseName, double duration, double fee)
    {
        this.courseName = courseName;
        this.duration = duration;
        this.fee = fee;
    }

    // Instance method to display the details of the course
    public void DisplayCourseDetails()
    {
        Console.WriteLine($"Institute: {instituteName}");
        Console.WriteLine($"Course Name: {courseName}");
        Console.WriteLine($"Duration: {duration} years");
        Console.WriteLine($"Fee: {fee}");
    }

    // Class method to update the institute name for all courses
    public static void UpdateInstituteName(string newInstituteName)
    {
        instituteName = newInstituteName;
        Console.WriteLine($"Institute name updated to: {instituteName}");
    }
}

class Program
{
    static void Main()
    {
        // Creating course instances
        Course course1 = new Course("MCA", 2, 150000);
        Course course2 = new Course("Btech. - CS", 4, 200000);

        // Displaying course details before updating the institute name
        Console.WriteLine("Before updating institute name:\n");
        course1.DisplayCourseDetails();
        course2.DisplayCourseDetails();

        // Updating institute name for all courses
        Course.UpdateInstituteName("GL Bajaj");

        // Displaying course details after updating the institute name
        Console.WriteLine("\nAfter updating institute name:\n");
        course1.DisplayCourseDetails();
        course2.DisplayCourseDetails();
    }
}