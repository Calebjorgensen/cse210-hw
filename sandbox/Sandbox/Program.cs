using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");

        Console.Write("Enter a number: ");
        string valveFromUser = Console.ReadLine();
        
        int x = int.Parse(valveFromUser); 
        int y = 4;
        if (x > y)
        {
            Console.WriteLine("Greater");
        }
        else if(x < y)
        {
            Console.WriteLine("Less");
        }
        else 
        {
            Console.WriteLine("Equal");
        }
        // End of how the if and else statements work. 


    }
}