using System;

// Base class representing a general course
public class Course
{
    public string CourseName { get; set; }
    public int Duration { get; set; }
    
    // Constructor to initialize course details
    public Course(string courseName, int duration)
    {
        CourseName = courseName;
        Duration = duration;
    }
    
    // Virtual method to display course details
    public virtual void DisplayCourseInfo()
    {
        Console.WriteLine($"Course: {CourseName}, Duration: {Duration} weeks");
    }
}

// Subclass representing an online course
public class OnlineCourse : Course
{
    public string Platform { get; set; }
    public bool IsRecorded { get; set; }
    
    // Constructor to initialize online course details
    public OnlineCourse(string courseName, int duration, string platform, bool isRecorded) : base(courseName, duration)
    {
        Platform = platform;
        IsRecorded = isRecorded;
    }
    
    // Overriding method to include additional details specific to online courses
    public override void DisplayCourseInfo()
    {
        base.DisplayCourseInfo();
        Console.WriteLine($"Platform: {Platform}, Recorded: {(IsRecorded ? "Yes" : "No")}");
    }
}

// Subclass representing a paid online course
public class PaidOnlineCourse : OnlineCourse
{
    public double Fee { get; set; }
    public double Discount { get; set; }
    
    // Constructor to initialize paid online course details
    public PaidOnlineCourse(string courseName, int duration, string platform, bool isRecorded, double fee, double discount) : base(courseName, duration, platform, isRecorded)
    {
        Fee = fee;
        Discount = discount;
    }
    
    // Overriding method to include pricing details
    public override void DisplayCourseInfo()
    {
        base.DisplayCourseInfo();
        double finalPrice = Fee - (Fee * Discount / 100);
        Console.WriteLine($"Fee: ${Fee}, Discount: {Discount}%, Final Price: ${finalPrice}");
    }
}

// Main program to demonstrate the hierarchy
public class Program
{
    public static void Main(String[] args)
    {
        // Creating different types of courses
        Course course = new Course("Java Programming", 4);
        OnlineCourse onlineCourse = new OnlineCourse("C# for Beginners", 6, "GeeksForGeeks", true);
        PaidOnlineCourse paidOnlineCourse = new PaidOnlineCourse("Advanced C#", 8, "Coursera", true, 1000, 10);

        // Displaying course details
        course.DisplayCourseInfo();
        Console.WriteLine();
        onlineCourse.DisplayCourseInfo();
        Console.WriteLine();
        paidOnlineCourse.DisplayCourseInfo();
    }
}