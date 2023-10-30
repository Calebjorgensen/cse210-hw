using System;






class Program
{
    static void Main(string[] args)
    {
        Math();
    }    

    static void Math()
    {
        string name = Console.ReadLine();
        Console.WriteLine(name);
        for(int x = 10; x >=0; x--)
        {
            Console.WriteLine(x);
        }
    }
}