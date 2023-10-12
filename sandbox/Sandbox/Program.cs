using System;




class Program
{
    static void Main(string[] args)
    {

        double userPrice = double.Parse(Console.ReadLine());

        double ten = 10 / .15;
        double twenty = 20 / .20;
        double thirty = 30 / .30;

        if(userPrice > ten)
        {
            Console.WriteLine("You get a 15% Discount");
        }
        else if(userPrice > twenty)
        {
            Console.WriteLine("You get a 20% Discount");
        }
        else if(userPrice > thirty)
        {
            Console.WriteLine("You get a 30% Discount");
        }
        else
        {
            Console.WriteLine("No discount applied.");
        }

    }
       
}