using System;
using System.Globalization;



class Program
{
    static void Main(string[] args)
    {
        List<string> _greeting = new List<string>();
        _greeting.Add("Hello");
        _greeting.Add("Hey");
        _greeting.Add("Hi");
        foreach(string greet in _greeting)
        {
            Console.WriteLine(greet);
        }

    }
       
}