using System;


class Entry
{
    public string user;
    public string date;

    public void Info()
    {
        Console.WriteLine($"{user} ~ {date}");
    }
}


class Time
{
    public void Date()
    {
        Entry e = new Entry();
        DateTime currentDateTime = DateTime.Now;
        e.date = currentDateTime.ToShortDateString();
        e.user = "Caleb";
        e.Info();
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