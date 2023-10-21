using System;

public class Reference
{
    // Attributes (Class Variables, Fields)
    private string _book;
    private string _chapter;
    private string _verse;
    


    public Reference(string book, string chapter, string verse, string endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = $"{verse}-{endVerse}";
    }

    public Reference(string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    // GetReferenceString()
    //  RETURN "{book} {chapter}..."
    public string GetReferenceString()
    {
        return $"{_book} {_chapter}: {_verse}";
    }
}