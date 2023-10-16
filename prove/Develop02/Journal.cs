using System;
using System.IO;
public class Journal
{
    

    public List<Entry> _list = new List<Entry>();
    public void Write()
    {
        Entry user = new Entry(); // This is the Instantiate
        DateTime theCurrentTime = DateTime.Now; // To get time and date
        user._date = theCurrentTime.ToShortDateString();
        string prompt = user.Prompts();
        Console.WriteLine(prompt);
        user._getPrompt = prompt;
        user._newEntry = Console.ReadLine(); // User can input there entry
        _list.Add(user);
    }
    public void Display()
    {
        Console.WriteLine("Journal Entries ");
        foreach (Entry entry in _list)
        {
            entry.Display();
        }
    }

    public void SaveFile()
    {
        string fileName = "myFile.txt";

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine("");
            
            // You can use the $ and include variables just like with Console.WriteLine
            string color = "Blue";
            outputFile.WriteLine($"My favorite color is {color}");
        }

    }
    public void LoadFile()
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

}

