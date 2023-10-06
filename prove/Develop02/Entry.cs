using System;
using System.Runtime.CompilerServices;


public class Entry
{
    public string _newEntry;
    public string _getPrompt;
    public string _submit;

public Entry()
{
    
}

public void Display()
{
    Console.WriteLine($"{_newEntry}");
    Console.WriteLine($"{_getPrompt}");
}    


public static string [] prompt = 
{
    "How have you seen the Hand of God in your life today?",
    "What was 3 postive things that happened today?",
};


public void PromptGenerator()
{
    Console.WriteLine($"{prompt}");
}

}

