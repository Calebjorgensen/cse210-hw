using System;




class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello there");

        int answer = 14;

        int choice = Convert.ToInt32(Console.ReadLine());

        if(answer > choice)
        {
            Console.WriteLine("Too Low, try again");
        }
        else if(answer < choice)
        {
            Console.WriteLine("Too high, try again");
        }
        else
        {
            Console.WriteLine("That is right!");
        }
        
    }    
}