using System;


public class Job
{
    public string _company;


    public void Display()
    {
        Console.WriteLine("Hello");
    }

    public string GetInfo()
    {
        Console.WriteLine("Test test");
        return GetInfo();
    }

}

class Program
{
    static void Main(string[] args)
    {
        Job j = new Job();
        j.Display();   
        j.GetInfo();   
    }
       
}