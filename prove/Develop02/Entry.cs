using System;
using System.Security.Cryptography.X509Certificates;


// Class Name Entry
public class Entry
{
/* Variables for this class are, newEntry, getPrompt, and sumbit
_newEntry is to record the new journal entyr of the user
_getPrompt is to randomize a prompt for the new entry
_date
_time

*/
    public string _newEntry;
    public string _getPrompt;
    public string _date;
    public string _time;


// I need to figure this part out. 

// The prompt works but only for the first prompt


public string Prompts()
{
    string[] prompts = 
    {
        "How have you seen the hand of God in your life today?",
        "What are 3 positive things from your life today?",
        "How did you show love today?",
        "What was one difficult thing from today?",
        "What's one goal you want to complete for tomorrow?",
    };
    string prompt = prompts[0];

    return prompt;
    
}

// This display, the varibles need to be in the right order. Date,time,prompt,entry.
public void Display()
{
    Console.WriteLine($"{_date}~|~{_time}~|~{_getPrompt}~|~{_newEntry}");
    
}


// This is use to enter in a new line or another prompt. string NewLine isn't connected anywhere so this method doesn't do anything yet.
public string NewLine()
{
    Console.WriteLine($"{_date}~|~{_time}~|~{_getPrompt}~|~{_newEntry}");
    return NewLine();
}


}


