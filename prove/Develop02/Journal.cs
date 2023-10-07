using System;

public class Journal
{
    
    public string _load;
    public string _save;
    public string _exit;

    public List<Entry> _savedJournal = new List<Entry>();

    public void Display()
    {
        Console.WriteLine("Journal Entries ");
        foreach (Entry journalFile in _savedJournal)
        {
            journalFile.Display();
        }
    }


}

