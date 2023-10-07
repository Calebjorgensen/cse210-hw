using System;
using System.Collections;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
       

        Welcome("Caleb " + "Elle");
        Number();
        
    }

    static void Welcome(string name )
    {
        Console.Write("Welcome, " + name);
        Console.WriteLine(" I am learning about Methods");
    }
    static int Number()
    {
        int number = 9;
        if (number > 8)
        {
            Console.WriteLine("Congrats");
        }
        else
        {
            Console.WriteLine("Try again");
        }
        return number;
    }
}