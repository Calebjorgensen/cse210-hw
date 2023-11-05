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
                Activity a1 = new Activity();
                a1.startingActivity();
                break;
                
                case "2":
                Console.WriteLine("Case 2");
                break;

                case "3":
                Console.WriteLine("Case 3");
                break;
            }
        }while(choice != "4");

    }
}