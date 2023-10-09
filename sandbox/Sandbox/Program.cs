using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;


class Food
{
    public string _apps;
    //public string _entree;
    //public string _desserts;

    public void Display()
    {
        Console.WriteLine($"{_apps}");
    }

}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");

        Food apps = new Food();
        apps._apps = "Cheese Curds";
        apps.Display();



    }
       
}