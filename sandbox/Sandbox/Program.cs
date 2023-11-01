using System;


class Program
{
    static void Main(string[] args)
    {
        double foot = Convert.ToInt32(Console.ReadLine());
        Converter(foot);
        

    }    

    static void Converter(double foot)
    {
        foot *=12;
        Console.WriteLine(foot);
    }

}