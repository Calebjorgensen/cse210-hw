using System;

public class Scripture
{
    private List<Word> _words = new List<Word>();
    private Reference _reference;
    private Random random = new Random();

    public Scripture(string text, Reference reference)
    {
        _reference = reference;
        string[] textArray = text.Split(' ');
        foreach(string t in textArray)
        {
            Word w = new Word(t);
            _words.Add(w);

        }
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