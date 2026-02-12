// Student Management System: Introduction to C# Object-Oriented Programming //

using System;

class Student
{
    public string Name ;
    public int Age ;
    public string Grade ;

    public Student(string n, int a, string g)
    {
        Name = n;
        Age = a;
        Grade = g;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter student details
        Console.WriteLine("Enter student's name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter student's age:");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter student's grade:");
        string grade = Console.ReadLine();

        Student s = new Student(name,age,grade);
        Console.WriteLine("Student Name: "+ s.Name);
        Console.WriteLine("Student Age: "+ s.Age);
        Console.WriteLine("Student Grade: "+ s.Grade);

    }
}