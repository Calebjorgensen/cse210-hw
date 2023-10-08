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

public void SaveFile()
{
    string filename = "myFile.txt";
    string[] lines = System.IO.File.ReadAllLines(filename);

    foreach (string line in lines)
    {
        string[] parts = line.Split(",");

        string firstName = parts[0];
        string lastName = parts[1];
}
}
public void LoadFile()
{

}

}

