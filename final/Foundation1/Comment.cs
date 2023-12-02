class Comment
{
    //public string _comment;

    public void Video1Comments()
    {
        string [] video1Comments = new string[3];
        video1Comments[0] = "This is a great video";
        video1Comments[1] = "Great video quatiy";
        video1Comments[2] = "Awesome video, thanks for posting it!";

        Console.WriteLine($"Number of comments: {video1Comments.Length}");
        Console.WriteLine(video1Comments[0]);
        Console.WriteLine(video1Comments[1]);
        Console.WriteLine(video1Comments[2]);
    }

    public void Video2Comments()
    {
        string [] video2Comments = new string[3];
        video2Comments[0] = "This is a great video";
        video2Comments[1] = "Great video quatiy";
        video2Comments[2] = "Thanks for posting this, it was great";

        Console.WriteLine($"Number of comments: {video2Comments.Length}");
        Console.WriteLine(video2Comments[0]);
        Console.WriteLine(video2Comments[1]);
        Console.WriteLine(video2Comments[2]);
    }
    public void Video3Comments()
    {
        string [] video3Comments = new string[3];
        video3Comments[0] = "This is a great video";
        video3Comments[1] = "Great video quatiy";
        video3Comments[2] = "Do you have any other videos that explain more on knots?";

        Console.WriteLine($"Number of comments: {video3Comments.Length}");
        Console.WriteLine(video3Comments[0]);
        Console.WriteLine(video3Comments[1]);
        Console.WriteLine(video3Comments[2]);
    }
    public void Video4Comments()
    {
        string [] video4Comments = new string[3];
        video4Comments[0] = "This is a great video";
        video4Comments[1] = "Great video quatiy";
        video4Comments[2] = "Awesome video";

        Console.WriteLine($"Number of comments: {video4Comments.Length}");
        Console.WriteLine(video4Comments[0]);
        Console.WriteLine(video4Comments[1]);
        Console.WriteLine(video4Comments[2]);
    }
}