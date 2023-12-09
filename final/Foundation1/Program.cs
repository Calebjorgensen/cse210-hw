using System;

class Program
{
    static void Main(string[] args)
    {
        Comment vc = new Comment();

        Console.WriteLine("");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Video v1 = new Video();
        v1._title = "How to tie a fishing knot";
        v1._author = "BassPro Fishing";
        v1._length = "120";
        v1.Display();
        vc.Video1Comments();
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("");
        

        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Video v2 = new Video();
        v2._title = "Best gaming clips of 2023";
        v2._author = "MLG Gaming";
        v2._length = "465";
        v2.Display();
        vc.Video2Comments();
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("");

        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Video v3 = new Video();
        v3._title = "Fly Fishing Basics";
        v3._author = "Fish Teacher";
        v3._length = "764";
        v3.Display();
        vc.Video3Comments();
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("");

        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Video v4 = new Video();
        v4._title = "How to line a Reel";
        v4._author = "BassPro Fishing";
        v4._length = "120";
        v4.Display();
        vc.Video4Comments();
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("");
        
    }
}