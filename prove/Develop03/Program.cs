using System;

class Program
{
    static void Main(string[] args)
    {
        //             (Instance)
        //(Class Type) (Object Name) = new (Constructor( Parameters ))

        // 

        // PUT "Enter the book"
        // book = GET
        // PUT "Enter the chapter"
        //  chapter = GET
        // PUT "Enter the verse"
        //...
        Reference reference = new("Book", "Chapter", "1");
        Scripture scripture = new("And it came to pass", reference);

        ///
    }
}