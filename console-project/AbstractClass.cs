
using System;

namespace Csharp;


//Abstraction is done when only you have to inherits the abstract class attributes and not to be create the instance object of that class.
//You can not create the object of abstract class.It is used as BaseClass 
//We can also use the properties in it;
abstract class Person1
{
    public string FirstName;
    public string LastName ;
    public int Age;
    public long phoneNumber;

    public abstract void GetDetails();
}

class Student1 : Person1
{
    public int rollNo;
    public int fees;

    public Student1(string firstName, string lastName, int age,long phoneNumber ,int rollno ,int fees)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
        this.phoneNumber = phoneNumber;
        this.rollNo = rollno;
        this.fees = fees;

    }
    public override void GetDetails()
    {
      
        string name = FirstName+" "+LastName;
        Console.WriteLine($"Name:-{name}");
        Console.WriteLine($"Age:-{Age}");
        Console.WriteLine($"Phone Number:-{phoneNumber}");
        Console.WriteLine($"Roll Number:-{rollNo}");
        Console.WriteLine($"Fees:-{fees}");
    }
}

class Teacher : Person1
{
    public string qualification;
    public int salary;

    public Teacher(string firstName, string lastName, int age,long phoneNumber,string qualification,int salary)
    {
        this.FirstName = firstName;
       this.LastName = lastName;  
        this.Age = age;
        this.phoneNumber = phoneNumber;
        this.qualification = qualification;
        this.salary = salary;

    }
    public override void GetDetails()
    {
        string name = FirstName+" "+LastName;
        Console.WriteLine($"Name:-{name}");
        Console.WriteLine($"Age:-{Age}");
        Console.WriteLine($"Phone Number:-{phoneNumber}");
        Console.WriteLine($"Qualification:-{this.qualification}");
        Console.WriteLine($"Salary:-{this.salary}");
    

    }
}