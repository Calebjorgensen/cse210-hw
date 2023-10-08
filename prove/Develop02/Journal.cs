using System;

public class Journal
{
    
    public string _load;
    public string _save;
    public string _exit;

    public List<Entry> _list = new List<Entry>();

    public void Display()
    {
        Console.WriteLine("Journal Entries ");
        foreach (Entry journalFile in _list)
        {
            journalFile.Display();
        }
    }


}

