using System;



class Calculator
{
    public int _add;
    public int _sub;
    public int _mult;
    public double _div;

    public Calculator()
    {
        Console.WriteLine("This is a Calculator Program");

    }

    public int Addition()
    {
        int x = 4;
        int y = 5;

        int sum = x + y;
        return sum;
        
    }

}







class Program
{
    static void Main(string[] args)
    {
        Calculator add = new Calculator();
        add.Addition();
        Console.WriteLine(add.Addition());

    }    



}