using System;

public class Hose
{
    private string _size;
    private string _length;
    private string _color;

    public void ShowSizes()
    {
        Console.WriteLine($"{_size}");
    }

    public void ShowLengths()
    {
        Console.WriteLine($"{_length}");
    }

    public void ShowColors()
    {
        Console.WriteLine($"{_color}");
    }

    public string GetInfoC
    {
        get {return _color;}
        set {_color = value;}
    }
    public string GetInfoL
    {
        get {return _length;}
        set {_length = value;}
    }
    public string GetInfoS
    {
        get {return _size;}
        set {_size = value;}
    }

}


class Program
{
    static void Main(string[] args)
    {
        Hose s = new Hose();
        s.GetInfoS = "1/4, 1/2, 3/4, 1";
        s.ShowSizes();

        Hose l = new Hose();
        l.GetInfoL = "25ft, 50ft, 75ft, 100ft";
        l.ShowLengths();

        Hose c = new Hose();
        c.GetInfoC = "Red, Black, Blue, White, Yellow, Green";
        c.ShowColors();
    }
       
}