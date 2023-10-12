using System;


public class Person
{
    private string _firstName;

    public string GetFirstName()
    {
        return _firstName;
    }

    public void SetFirstName(string firstName)
    {
        _firstName = firstName;
    }
}




class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
        Person p = new Person();
        p.SetFirstName("Caleb");

        Console.WriteLine(p.GetFirstName());


    }
       
}