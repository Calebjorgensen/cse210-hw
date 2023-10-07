using System;


// Class Name Entry
public class Entry
{
/* Variables for this class are, newEntry, getPrompt, and sumbit
_newEntry is to record the new journal entyr of the user
_getPrompt is to randomize a prompt for the new entry
_submit not sure what the sumbut is suppose to do?? 

*/
    public string _newEntry;
    public string _getPrompt;
    public string _date;
    public string _time;


// I need to figure this part out. 
public void Prompt()
{
    
    
}

// This display, the varibles need to be in the right order. Date,time,prompt,entry.
public void Display()
{
    Console.WriteLine($"{_date}~|~{_time}~|~{_getPrompt}~|~{_newEntry}");
    
}

//This is should follow the same order as above.
public string NewLine()
{
    Console.WriteLine($"{_date}~|~{_time}~|~{_getPrompt}~|~{_newEntry}");
    return NewLine();
}


}


