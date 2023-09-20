using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");



        // in the while statement, as long as its true then it will keep running. 
        string response = "yes";
        while (response == "yes")
        {
            Console.Write("Do you want to continue?");
            response = Console.ReadLine();
        }       
 


    }
}