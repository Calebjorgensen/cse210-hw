using System;


class Person
{
    private string _name;
    public string Name
    {
        get {return _name;}
        set {_name = value;}

    }
}

class Program
{
    static void Main(string[] args)
    {
        Person p = new Person();
        p.Name = "Caleb";
        Console.WriteLine(p.Name);

    }    



}