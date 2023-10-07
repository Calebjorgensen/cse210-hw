using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
       

        Welcome("Caleb");
        Welcome("Elle");
        Lesson();
        Color();
        Input();
        
    }

    static void Welcome(string name )
    {
        Console.WriteLine("Welcome, " + name);
        Console.WriteLine("I am learning about Methods");
    }
    static void Lesson()
    {
        Console.WriteLine("Lesson One is covering Classes");
        Console.WriteLine("Please begin to take notes");
    }

    static void Color()
    {
        Console.WriteLine("The best Color is Yellow");
    }

    static void Input()
    {
        Console.WriteLine("What am I doing in this class?");
    }
}