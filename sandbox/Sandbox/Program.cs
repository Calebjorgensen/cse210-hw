using System;


public class Person
{
    private string name;


    public void NewPost()
    {
        Console.WriteLine("Hello There");
    }
    public string Name // This is a property
    {
        get {return name;}
        set {name = value;}
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person p = new Person();
        p.NewPost();
        p.Name = "Caleb";
        Console.WriteLine(p.Name);
    }
       
}