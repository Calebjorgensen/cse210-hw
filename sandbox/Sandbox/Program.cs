using System;
using System.Xml.Schema;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");


        List<string> fish = new List<string> {"trout, bass, catfish, carp"};
        foreach(var number in fish)
        {
            Console.WriteLine($"{number}");
        }


    }
}