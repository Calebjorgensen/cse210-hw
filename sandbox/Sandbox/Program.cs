using System;

class Bank
{
    //public string _email;

    // This is a Constructor. The Idea of this is to do less code to get the same result.
    public Bank()
    {
        Console.WriteLine("Send Email to user");
    }
}


class Program
{
    static void Main(string[] args)
    {
        Bank b = new Bank();

    }    



}