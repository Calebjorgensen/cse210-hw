using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");
        Address address1 = new Address("123 Lane St", "Carville","OR", "12345");
        Lectures lecture1 = new Lectures("Learning to Code", "C# Basics", "Dec-25-23","9:00AM", address1, "John Cena", "150");

        Address address2 = new Address("456 Lane Dr", "Nowhereville", "CA", "45678");
        Reception reception1 = new Reception("Bucks Wedding", "Wedding of Ellexis and Caleb", "Dec-25-23", "9:00PM", address2, "Email: EventPlanner@yournextevent.com");

        Address address3 = new Address("789 Lane Rd", "Whoville", "UT", "67890");
        OutdoorGathering outdoorGathering1 = new OutdoorGathering("Nerf War","Outside Party","Dec-25-2023","5:00PM",address3, "Light Snow Fall and 27 Degrees");


        Console.WriteLine("");
        Console.WriteLine("~~~  Upcoming Lecture Event  ~~~");
        Console.WriteLine("");
        Console.WriteLine(lecture1.GetStandardDetails());
        Console.WriteLine("");
        Console.WriteLine(lecture1.GetFullDetails());
        Console.WriteLine("");
        Console.WriteLine(lecture1.GetShortDetails());
        Console.WriteLine("");
        Console.WriteLine("");

        Console.WriteLine("~~~  Upcoming Reception Event  ~~~");
        Console.WriteLine("");
        Console.WriteLine(reception1.GetStandardDetails());
        Console.WriteLine("");
        Console.WriteLine(reception1.GetFullDetails());
        Console.WriteLine("");
        Console.WriteLine(reception1.GetShortDetails());
        Console.WriteLine("");
        Console.WriteLine("");

        Console.WriteLine("~~~  Upcoming OutdoorGathering Event  ~~~");
        Console.WriteLine("");
        Console.WriteLine(outdoorGathering1.GetStandardDetails());
        Console.WriteLine("");
        Console.WriteLine(outdoorGathering1.GetFullDetails());
        Console.WriteLine("");
        Console.WriteLine(outdoorGathering1.GetShortDetails());
        Console.WriteLine("");
        Console.WriteLine("");

    }
}