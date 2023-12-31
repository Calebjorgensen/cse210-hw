using System;
using System.Diagnostics.Contracts;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 3;
        _bottom = 3;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
    public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
         return text;
    }
    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}