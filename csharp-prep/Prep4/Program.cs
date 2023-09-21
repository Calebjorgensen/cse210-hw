using System;
using System.Collections.Generic;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello User");

        // How am I going to start this build?
        List<int> numbers = new List<int>();

        int userInput = -1;
        while (userInput != 0)
        {
            Console.WriteLine("Enter a number(Type 0 to quit)");

            string userResponse = Console.ReadLine();
            userInput = int.Parse(userResponse);

            if (userInput != 0)
            {
                numbers.Add(userInput);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"This is the sum: {sum}");


        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max is: {max}");

    }
}