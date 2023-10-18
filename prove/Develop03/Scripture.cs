using System;

public class Scripture
{
    private List<Word> _words = new();
    private Reference _reference;
    private Random random = new();

    public Scripture(string text, Reference reference)
    {
        _reference = reference;
        //...
    }
}

    // HIdeRandomWords()
    //  counter = 0
    // While( counter < 3 && !AllWordsHidden()) 
        // index = 0;
        //  DO
        //      index = random.Next(_words.Count)
        //  WHILE ( _words[index].GetIsHidden )
        //
        // _words[index].Hide()
        //  counter++



    // AllWordsHidden()
    //  Foreach word in words
    //      IF !word.GetIsHidden()
    //          RETURN false
    //  RETURN true


    // Display()
    //  PUT reference.GetReferenceString()
    //  FOREACH word in words
    //      PUT word.GetWord() + " "