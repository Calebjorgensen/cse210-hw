using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation4 World!");
        var activites = new Activity[ ]
        {
            new Running("03 nov 2022", 30, 3.0),
            new Cycling("04 Nov 2022",30, 6.0),
            new Swimming("05 Nov 2022", 30, 30)

        };

        foreach (var activity in activites)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}