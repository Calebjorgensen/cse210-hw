using System;

class Program
{
    static void Main(string[] args)
    {
        
        // Here's my code for asking for a person's name, I also added spaces to make it more readable.
        Console.WriteLine("What is your First Name?: ");
        string first = Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine("What is your Last Name?: ");
        string last = Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine($"Your name is {last}, {first} {last}");
        Console.WriteLine();

        Console.WriteLine("Thanks for Joining us today!");
        
    
    }
}