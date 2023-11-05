using System;

class Activity
{
    public int _timer;
    //public string _name; THIS DOESN'T DO ANYTHING RIGHT NOW


    public Activity()
    {
        Console.WriteLine("Enter the time in seconds your want to do this activity");
        _timer = int.Parse(Console.ReadLine());
        Console.WriteLine("You have enter " + _timer + " in seconds");

        
    }
    public void startingActivity()
    {
        Console.WriteLine("Hello");
    }
}