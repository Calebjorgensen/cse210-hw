using System;


public class Fraction
{
    public int _top;
    public int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int WholeNumber)
    {
        _top = WholeNumber;
        _bottom = 1;
    }

    public string GetFraction()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }
    public double Decimal()
    {
        return (double) _top / (double) _bottom;
    }
}



class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFraction());
        Console.WriteLine(f1.Decimal());
    }
       
}