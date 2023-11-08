using System;




class Program
{
    static void Main(string[] args)
    {
       
        int [] math = {34,43,23,64,43};
        int sum = 0;

        foreach(int x in math)
        {
            sum += x;
        }
        Console.WriteLine(sum);



    }    



}