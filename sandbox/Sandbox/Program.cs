using System;
using System.Reflection.Metadata.Ecma335;

class Bank
{
    private string accountNum = "0123456789";

    public string Account
    {
        get {return accountNum;}
    }
}

class Program
{
    static void Main(string[] args)
    {
        Bank card = new Bank();
        Console.WriteLine(card.Account);
    }
       
}