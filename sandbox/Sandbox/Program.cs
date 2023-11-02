using System;

class Person
{
    public string _name;
    public int _age;

    public void sayHi()
    {
        Console.WriteLine($"Hello {_name}");
        Console.WriteLine($"Your age is {_age}");
    }
}


class Program
{
    static void Main(string[] args)
    {
        Person p1 = new Person();
        p1._name = "Caleb";
        p1._age = 24;
        p1.sayHi();

    }    



}