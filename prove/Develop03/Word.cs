using System;
using System.Security.Cryptography.X509Certificates;

public class Word
{
    private string _word;
    private bool isHidden;

    public Word(string word)
    {
        _word = word;
        isHidden = false;
    }

    public bool GetIsHidden()
    { 
        return isHidden;
    }

    public void Hide()
    {
        //String text = new String('_', _word.Length);
        _word = new String('_', _word.Length);
        isHidden = true;
    }
    // Show()
    //     isHidden = FALSE

    public string GetWord()
    {
        return _word;
    }

    // GetWord()
    // IF isHidden
    //      word = ""
    //      FOREACH letter in word
    //          word += "_"
    //      RETURN word
    // ELSE
    //     RETURN _word     
}