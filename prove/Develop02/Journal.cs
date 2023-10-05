using System;

public class Journal
{
    public string _display;
    public string _load;
    public string _save;
    public string _exit;

    public void Display()
    {
        Console.WriteLine($"{_display}");
        Console.WriteLine($"{_load}");
        Console.WriteLine($"{_save}");
        Console.WriteLine($"{_exit}");
    }


}

