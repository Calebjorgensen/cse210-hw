using System;
using System.Diagnostics.CodeAnalysis;


class Entry
{
    public string user;
    public string date;

    public void Info()
    {
        Console.WriteLine($"{user} ~ {date}");
    }
}

class Math
{
    public int Add()
    {
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());

        int sum = x + y;
        Console.WriteLine(sum);
        return sum;
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


        Math m = new Math();
        m.Add();
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