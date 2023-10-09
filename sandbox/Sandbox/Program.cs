using System;
using System.Collections;
using System.Runtime.InteropServices.Marshalling;

class Job
{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;


    public void Display()
    {
        Console.WriteLine($"{_company}");
        Console.WriteLine($"{_jobTitle}");
        Console.WriteLine($"{_startYear} to {_endYear}");
        Console.WriteLine("");
    }
}

class Resume
{
    public string _name;

    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs: ");
        Console.WriteLine("");

        foreach(Job job in _jobs)
        {
            job.Display();
        }
    }

}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");

        Job job1 = new Job();
        job1._company = "Apple";
        job1._jobTitle = "Software Developer";
        job1._startYear = 2020;
        job1._endYear = 2023;
        


        Job job2 = new Job();
        job2._company = "Microsoft";
        job2._jobTitle = "Project Manager";
        job2._startYear = 2017;
        job2._endYear = 2020;
        

        Resume myResume = new Resume();
        myResume._name = "Caleb";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.Display();
        
        




    }
       
}