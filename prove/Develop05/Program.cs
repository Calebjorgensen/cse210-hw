using System;

class Program
{
    static void Main(string[] args)
    {
        string user = "0";
        Menu m = new Menu();

        while (user != "6")
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create new Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            user = Console.ReadLine();

            switch(user)
            {
                case "1":
                m.CreateNewGoal();
                break;

                case "2":
                m.ListGoals();
                break;

                case "3":
                m.SaveGoal();
                break;

                case "4":
                m.LoadListGoals();
                break;

                case "5":
                m.RecordEvent();
                break;
            }

        }
    }
}