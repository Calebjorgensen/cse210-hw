using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,11);

        int guess = -1;

        while (guess != number)
        {
            Console.WriteLine("What is your Guess:  ");
            guess = int.Parse(Console.ReadLine());
        }

    }
}