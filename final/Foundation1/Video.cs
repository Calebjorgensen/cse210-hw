class Video
{
    public string _title;
    public string _author;
    public string _length;

    public void Display()
    {
        Console.WriteLine($"Title: {_title} \nAuthor: {_author} \nLength: {_length} (Time is recorded in seconds)");
    }
}