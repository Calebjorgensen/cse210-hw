using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");


        Console.WriteLine("Do you enjoy school");

        string stoplight = Console.ReadLine();

        if(stoplight == "red")
        {
            Console.WriteLine("Red");
            Console.WriteLine("Stop");
        }
        else if(stoplight == "Yellow")
        {
            Console.WriteLine("Yellow");
            Console.WriteLine("Slow Down");
        }
        else if(stoplight == "green")
        {
            Console.WriteLine("Green");
            Console.WriteLine("Keep going");
        }
        else
        {
            Console.WriteLine("Bail Bail Bail!");
        }


    }
}