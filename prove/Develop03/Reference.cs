using System;

public class Reference
{
    // Attributes (Class Variables, Fields)
    private string _book;
    private string _chapter;
    private string _verse;
    private string _endVerse;


    public Reference(string book, string chapter, string verse, string endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public Reference(string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = null;
    }

    // GetReferenceString()
    //  RETURN "{book} {chapter}..."
}