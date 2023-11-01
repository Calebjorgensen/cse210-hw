using System;






class Program
{
    static void Main(string[] args)
    {
        Math("Caleb");
    }    

    static void Math(string name)
    {
        Console.WriteLine("Hello There, Welcome to our game! " + name);
        for(int x = 27; x >= 3; x-=3)
        {
            Console.WriteLine(x);
        }
    }
}