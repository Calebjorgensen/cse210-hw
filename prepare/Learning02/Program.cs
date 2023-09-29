using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Apple";

        Job job2 = new Job();
        job2._jobTitle = "Computer Programmer";
        job2._company = "Microsoft";

        job1.Display();
        job2.Display();
    }
}