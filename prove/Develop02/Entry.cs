using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

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
    public string _submit;

// This method was in the example for Abstractions, said it was a speical constructor.
public Entry()
{
    
}

//This Method is so that I can Display the _newEntry, and the _getPrompt
public void Display()
{
    Console.WriteLine($"{_newEntry}");
    Console.WriteLine($"{_getPrompt}");
}    

//Goal of this Method is to create a list of prompts and have them random generate. 
// Has not worked yet. 
public void PromptGenerator()
{

    Console.WriteLine($"{_getPrompt}");
}



}

