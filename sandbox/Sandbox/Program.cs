using System;
using System.Diagnostics.Contracts;
using System.Xml.XPath;


public class Calculator
{
    public int _add;

    public void Addiction()
    {
        int x = 10;
        int y = 9;

        int answer = x + y;

        Console.WriteLine(answer);
        
    }

    public void Substraction()
    {
        int s = 73;
        int a = 10;

        int answer2 = s - a;
        Console.WriteLine(answer2);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calculator m = new Calculator();
        m.Addiction();
        m.Substraction();
    }
       
}