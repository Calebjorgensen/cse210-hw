using System;

public class Hose
{
    public string _size;
    public string _length;
    public string _color;

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
}


class Program
{
    static void Main(string[] args)
    {
        Hose l = new Hose();
        l._length = "25ft, 50ft, 75ft, 100ft";
        l.ShowLengths();

        Console.WriteLine("");

        Hose s = new Hose();
        s._size = "1/4, 3/8, 1/2, 3/4";
        s.ShowSizes();

        Hose c = new Hose();
        c._color = "Red, Black, Blue, White, Yellow, Green";
        c.ShowColors();
    }
       
}