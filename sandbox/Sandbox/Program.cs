using System;
using System.Runtime.CompilerServices;






class Program
{
    static void Main(string[] args)
    {
        Percent(640,24);
    }    

    static void Percent(double num, int percentage)
    {
        double res = num*percentage/100;
        Console.WriteLine(res);
    }
}