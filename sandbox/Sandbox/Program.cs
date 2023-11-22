using System;

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
    }    
}