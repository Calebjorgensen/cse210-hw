using System;

class Bank
{
    public string _email;

    // This is a Constructor. The Idea of this is to do less code to get the same result.
    public Bank()
    {
        Console.WriteLine("Send Email to user");
    }

    public string Email(string _email)
    {
        Console.WriteLine(_email);
        return _email;
    }
}


class Program
{
    static void Main(string[] args)
    {
        Bank b = new Bank();

    }    



}