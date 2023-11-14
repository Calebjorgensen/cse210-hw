using System;

class Game
{
    public Game()
    {
        Console.WriteLine("Welcome to my program.");
    }

    public int Add()
    {
        int x = 7;
        int y = 7;

        int sum = x + y;
        Console.WriteLine(sum);
        return sum;
    }
}



class Program
{
    static void Main(string[] args)
    {
        Game g = new Game();
        g.Add();
        
    }    
}