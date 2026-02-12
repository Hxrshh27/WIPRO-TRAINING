// Library Management System: Introduction to C# Object-Oriented Programming( Without Collection) //

using System;

class Book
{
    public string Title;
    public string Author;
    public int Year;

    public Book(string t, string a, int y)
    {
        Title = t;
        Author = a;
        Year = y;

    }
}
class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter book details
        Console.WriteLine("Enter book's title:");
        string title = Console.ReadLine();

        Console.WriteLine("Enter book's author:");
        string author = Console.ReadLine();

        Console.WriteLine("Enter book's year:");
        int year = Convert.ToInt32(Console.ReadLine());

        Book b = new Book(title,author,year);

        Console.WriteLine("Book Title: "+b.Title);
        Console.WriteLine("Book Author: "+b.Author);
        Console.WriteLine("Book Year: "+b.Year);


       
    }
}