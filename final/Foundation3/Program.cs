using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");
        Address address1 = new Address("123 Lane St", "Carville","OR", "12345");
        Lectures lecture1 = new Lectures("Learning to Code", "C# Basics", "Dec-25-23","9:00AM", address1, "John Cena", "150");

        Address address2 = new Address("456 Lane Dr", "Nowhereville", "CA", "45678");
        Reception reception1 = new Reception("Coding Party", "Connect and Network", "Dec-25-23", "9:00PM", address2, "Email: EventPlanner@yournextevent.com");

        Address address3 = new Address("789 Lane Rd", "Whoville", "UT", "67890");
        OutdoorGathering outdoorGathering1 = new OutdoorGathering("Nerf War","Outside Party","Dec-25-2023","5:00PM",address3, "Light Snow Fall and 27 Degrees");


        Event[ ] events = {lecture1, reception1, outdoorGathering1};

        foreach (var evt in events)
        {
            Console.WriteLine("Standard Detials");
            Console.WriteLine("");
            Console.WriteLine(evt.GetStandardDetails());
            Console.WriteLine("");
            Console.WriteLine("Short Description");
            Console.WriteLine("");
            Console.WriteLine(evt.GetShortDetails());
            Console.WriteLine("");
            Console.WriteLine("Full Details");
            Console.WriteLine(reception1.GetFullDetails());

        
        }
    }
}