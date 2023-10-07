using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
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

private static List<string> prompts = new List<string>
{
    "How have you seen the Hand of God in your life today?",
    "What are 3 postive things that happen to you today?",
    "Did you meet anyone new today?",
    "What did you talk about with your family and freinds today?",
    "How will you be better tomorrow?",
};

private static string GenerateRandomPrompt()
{
    Random random = new Random();
    int index = random.Next(prompts.Count);
    return prompts[index];
}

//Goal of this Method is to create a list of prompts and have them random generate. 
// Has not worked yet. 
public void PromptGen()
{
    Console.WriteLine("");
    Console.WriteLine("Type Enter for Prompt or 5 to Exit:");
    Console.WriteLine("");
    while (true)
    {
        var key = Console.ReadKey(true);
        if (key.KeyChar == '5' || key.KeyChar == '5')
        {
            break;
        }
        else
        {
            Console.WriteLine(GenerateRandomPrompt());
        }
    }
    
}



}

