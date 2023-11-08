using System;



class Program
{
    static void Main(string[] args)
    {
       
        int [] test = new int [10];
        for(int x = 2; x < 10; x++)
        {
            test[x] = x*3;
        }
        foreach(int x in test)
        {
            Console.WriteLine(x);
        }

    }    



}