using System;
using System.IO;

public class Menu
{

    private List<Goal> _goals;

    private int _score;
    public Menu()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void CreateNewGoal()
    {
        string user = "0";
        Console.WriteLine("The type of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("What type of Goal would you like to create: ");

        user = Console.ReadLine();
        string name;
        string description;
        int points;
        int bonus;
        int totalAmount;
        switch(user)
        {
            case "1":
            Console.WriteLine("What is the name of your Goal: ");
            name = Console.ReadLine();
            Console.WriteLine("What is the description of your goal: ");
            description = Console.ReadLine();
            Console.WriteLine("How many points will this goal be worth: ");
            points = int.Parse(Console.ReadLine());

            SimpleGoal sg = new SimpleGoal(name, description, points);
            _goals.Add(sg);
            break;


            //CORRECT THE WRTIELINE STATEMENTS
            case "2":
            Console.WriteLine("What is the name of your Goal: ");
            name = Console.ReadLine();
            Console.WriteLine("What is the description of your goal: ");
            description = Console.ReadLine();
            Console.WriteLine("How many points will this goal be worth: ");
            points = int.Parse(Console.ReadLine());

            EternalGoal eg = new EternalGoal(name, description, points);
            _goals.Add(eg);
            break;

            case "3":
            Console.WriteLine("What is the name of your Goal: ");
            name = Console.ReadLine();
            Console.WriteLine("What is the description of your goal: ");
            description = Console.ReadLine();
            Console.WriteLine("How many points will this goal be worth: ");
            points = int.Parse(Console.ReadLine());
            Console.WriteLine("What amount for your bonus");
            bonus = int.Parse(Console.ReadLine());
            Console.WriteLine("How many times do you want to complete this to get your bonus");
            totalAmount = int.Parse(Console.ReadLine());

            CheckListGoal clg = new CheckListGoal(name, description, points, bonus, totalAmount);
            _goals.Add(clg);
            break;
        }
    }

    public void ListGoals()
    {   
        foreach(Goal goal in _goals)
        {
            Console.WriteLine(goal.GetPrintableGoal());
        }

    }

    public void SaveGoal()
    {
        // remember the score save
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine("");
            
            
            // You can use the $ and include variables just like with Console.WriteLine
            
            outputFile.WriteLine($"{_goals}");
        }
    }
    public void LoadListGoals()
    {
        // This mehtod will need to be done after the save goal
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string firstName = parts[0];
            //string lastName = parts[1];
        }
    }
    public void RecordEvent()
    {
        // The biggest thing it will do is update the score. Add the score to the current score, maybe add a method to the goal class get points
    }
    public void CurrentScore()
    {

    }
}