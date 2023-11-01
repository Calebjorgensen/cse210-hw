using System;


class Program
{
    static void Main(string[] args)
    {
       Discount("Caleb", 2000);
       Discount("Elle", 1300);

    }    

    static void Discount(string name, double purchase)
    {
        if(purchase>1500)
        {
            purchase*=0.85;
        }
        Console.WriteLine("Hello " + name);
        Console.WriteLine("Your total today is " + purchase);

    }

}