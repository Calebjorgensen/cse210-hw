using System;
using System.Collections;


class Foo
{
    public string _bar; // An Attribute

    public void Display()
    {
        Console.WriteLine($"{_bar}");
    }
}


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");

        Foo barz; // An Object
        barz = new Foo(); // Instantation
        barz._bar = "Hello World";
        barz.Display();

    }
       
}