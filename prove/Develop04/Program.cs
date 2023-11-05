using System;

class Program
{
    static void Main(string[] args)
    {
        // Need to create a switch. with a while loop

        string choice;

        do
        {
            Console.WriteLine("This is a start of the program");
            choice = Console.ReadLine();

            switch(choice)
            {
                case "1":
                Console.WriteLine("Case 1");
                break;
            }
        }while(choice != "5");

    }
}