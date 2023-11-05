using System;

class Program
{
    static void Main(string[] args)
    {
        // Need to create a switch. with a while loop

        string choice;

        do
        {
            Console.WriteLine("Welcome to your Mindfullness program");
            Console.WriteLine("Choose of the following Activites");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listening Activity");
            Console.WriteLine("4. Exit Program");
            choice = Console.ReadLine();

            switch(choice)
            {
                case "1":
                Console.WriteLine("Case 1");
                break;
            }
        }while(choice != "4");

    }
}