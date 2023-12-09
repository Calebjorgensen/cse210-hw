class Comment
{
    //public string _name;

    public void Video1Comments()
    {
        string [] video1Comments = new string[3];
        video1Comments[0] = "This is a great video - Caleb John";
        video1Comments[1] = "Great video quatiy - Bree Buck";
        video1Comments[2] = "Awesome video, thanks for posting it - Trevor Anderson";

        Console.WriteLine($"Number of comments: {video1Comments.Length}");
        Console.WriteLine(video1Comments[0]);
        Console.WriteLine(video1Comments[1]);
        Console.WriteLine(video1Comments[2]);
    }

    public void Video2Comments()
    {
        string [] video2Comments = new string[3];
        video2Comments[0] = "This is a great video - Dan Buck";
        video2Comments[1] = "Great video quatiy - Ellexis Jorgensen";
        video2Comments[2] = "Thanks for posting this, it was great - Ben Ten";

        Console.WriteLine($"Number of comments: {video2Comments.Length}");
        Console.WriteLine(video2Comments[0]);
        Console.WriteLine(video2Comments[1]);
        Console.WriteLine(video2Comments[2]);
    }
    public void Video3Comments()
    {
        string [] video3Comments = new string[3];
        video3Comments[0] = "This is a great video - Ann Marie";
        video3Comments[1] = "Great video quatiy - Sara Roll";
        video3Comments[2] = "Do you have any other videos that explain more on knots? - Tim Tall";

        Console.WriteLine($"Number of comments: {video3Comments.Length}");
        Console.WriteLine(video3Comments[0]);
        Console.WriteLine(video3Comments[1]);
        Console.WriteLine(video3Comments[2]);
    }
    public void Video4Comments()
    {
        string [] video4Comments = new string[3];
        video4Comments[0] = "This is a great video - Ean Short";
        video4Comments[1] = "Great video quatiy - Tom Cruise";
        video4Comments[2] = "Awesome video - Sara Bullock";

        Console.WriteLine($"Number of comments: {video4Comments.Length}");
        Console.WriteLine(video4Comments[0]);
        Console.WriteLine(video4Comments[1]);
        Console.WriteLine(video4Comments[2]);
    }
}