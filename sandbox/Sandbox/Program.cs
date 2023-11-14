using System;

class Game
{
    public Game()
    {
        Console.WriteLine("Welcome to my program.");
    }

    public int Loop()
    {
        int answer = 14;

        int choice = Convert.ToInt32(Console.ReadLine());

        if(answer < choice)
        {
            Console.WriteLine("Answer is too low");
        }
        else if( answer > choice)
        {
            Console.WriteLine("Higher");
        }
        else
        {
            Console.WriteLine("Right answer");
        }

        return choice;
    }

}



class Program
{
    static void Main(string[] args)
    {
        Game g = new Game();
        g.Loop();
        
    }    
}