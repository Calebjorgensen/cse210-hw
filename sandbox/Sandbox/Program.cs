using System;



public class Calculator
{
    public int _add;


    public void Math()
    {
       string input = Console.ReadLine();
       Console.WriteLine(input);
    }
}



class Program
{
    static void Main(string[] args)
    {
        Calculator m = new Calculator();
        m.Math();

    }
       
}