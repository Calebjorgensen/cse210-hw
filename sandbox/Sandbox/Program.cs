using System;


class Time
{
    public Time()
    {
        Console.WriteLine("Welcome");
    }

    public void Date()
    {
        DateTime currentDate = DateTime.Now;
        Console.WriteLine(currentDate);

    }
}


class Program
{
    static void Main(string[] args)
    {
        Time t = new Time();
        t.Date();
        
    }    
}