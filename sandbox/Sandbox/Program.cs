using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");


        Console.WriteLine("Do you enjoy school");

        string entry = Console.ReadLine();

        switch(entry)
        {
            case "1":
            Console.WriteLine("option 1");
            break;

            case "2":
            Console.WriteLine("option 2");
            break;

            case "3":
            Console.WriteLine("option 3");
            break;
        }


    }
}