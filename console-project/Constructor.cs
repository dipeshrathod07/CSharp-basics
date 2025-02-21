using Csharp;
using System;

namespace Csharp
{

  class Car
{
    // Private fields
    private string model;
    private string colour;
    private int year;

    // Properties
    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    public string Colour
    {
        get { return colour; }
        set { colour = value; }
    }

    public int Year
    {
        get { return year; }
        set { year = value; }
    }

    // Parameterized constructor
    public Car(string model, string colour, int year)
    {
        this.Model = model;   // Assign parameter to property
        this.Colour = colour; // Assign parameter to property
        this.Year = year;     // Assign parameter to property
    }
}
class Student
{
    // Instance variables
    private string name;
    private int age;
    private string grade;

    // Static field to track total students
    private static int totalStudents;

    // Constructor to initialize the student's name, age, and grade
    public Student(string name, int age, string grade)
    {
        this.Name = name; // Using properties for validation
        this.Age = age;
        this.Grade = grade;
        totalStudents++; // Increment the static counter
    }

    // Property for Name
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    // Property for Age
    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    // Property for Grade with validation
    public string Grade
    {
        get { return grade; }
        set
        {
            if (value == "A" || value == "B" || value == "C")
            {
                grade = value;
            }
            else
            {
                grade = ""; // Assign empty string for invalid grades
            }
        }
    }

    // Static method to get the total number of students
    public static int GetTotalStudents()
    {
        return totalStudents;
    }

    // Method to display student information
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Grade: {Grade}");
        Console.WriteLine($"Total Students: {GetTotalStudents()}");
    }
}
class Constructor
{
    public static void Dispaly()
    {
         // Input and creation of students
            Console.WriteLine("Enter details for Student 1:");
            Console.Write("Name: ");
            string name1 = Console.ReadLine();
            Console.Write("Age: ");
            int age1 = int.Parse(Console.ReadLine());
            Console.Write("Grade: ");
            string grade1 = Console.ReadLine();
            Student student1 = new Student(name1, age1, grade1);
            student1.DisplayInfo();

            Console.WriteLine("\nEnter details for Student 2:");
            Console.Write("Name: ");
            string name2 = Console.ReadLine();
            Console.Write("Age: ");
            int age2 = int.Parse(Console.ReadLine());
            Console.Write("Grade: ");
            string grade2 = Console.ReadLine();
            Student student2 = new Student(name2, age2, grade2);
            student2.DisplayInfo();

            Console.WriteLine("\nEnter details for Student 3:");
            Console.Write("Name: ");
            string name3 = Console.ReadLine();
            Console.Write("Age: ");
            int age3 = int.Parse(Console.ReadLine());
            Console.Write("Grade: ");
            string grade3 = Console.ReadLine();
            Student student3 = new Student(name3, age3, grade3);
            student3.DisplayInfo();
    }

}

}
