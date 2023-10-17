using System;



public class Soups
{
    public string _warmSoups;
    public string _coldSoups;

    public void Dispay()
    {
        Console.WriteLine($"{_warmSoups}");
        Console.WriteLine($"{_coldSoups}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Soups s = new Soups();
        s._warmSoups = "Broccoli and Cheese soup";
        s._coldSoups = "Thai soup";
        s.Dispay();
    }
       
}