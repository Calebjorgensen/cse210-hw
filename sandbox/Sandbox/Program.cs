using System;




class Program
{
    static void Main(string[] args)
    {

        int price = 30;
        int spend = int.Parse(Console.ReadLine());
        if (spend > price)
        {
            Console.WriteLine("You get a discount");
        }
        else
        {
            Console.WriteLine($"Your price is lower them ${price} so no discount can be added");
        }

    }
       
}