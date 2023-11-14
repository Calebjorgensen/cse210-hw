using System;
using System.Xml.Serialization;

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
        do
        {
        if(answer < choice)
        {
            Console.WriteLine("Answer is too low");
            break;
        }
        else if( answer > choice)
        {
            Console.WriteLine("Higher");
            break;
        }
        }while(answer != choice);
        Console.WriteLine("That is the right answer");

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