using System;
using System.Security.Cryptography.X509Certificates;
using System.IO;

class Person
{
    public string _firstName;
    public string _lastName;
    public int _age;
}


class Program
{
    static void Main(string[] args)
    {
        Person p1 = new Person();
        p1._firstName = "Caleb";
        p1._lastName = "Jorgensen";
        p1._age = 24;

        Person p2 = new Person();
        p2._firstName = "Ellexis";
        p2._lastName = "Buck";
        p2._age = 28;

        List<Person> people = new List<Person>();
        people.Add(p1);
        people.Add(p2);

        foreach (Person p in people)
        {
            Console.WriteLine(p._firstName);
        }

        SaveToFile(people);
    }    

    public static void SaveToFile(List<Person> people)
    {
        Console.WriteLine("Saving to file... ");
        string fileName = "people.txt";

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach(Person p in people)
            {
                outputFile.WriteLine($"{p._firstName}~{p._lastName}~{p._age}");
            }
        }
    }
}