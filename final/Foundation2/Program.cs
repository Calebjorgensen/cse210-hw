using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");
        Product p = new Product(10);
        Console.WriteLine(p.GetPrice());
    }
}