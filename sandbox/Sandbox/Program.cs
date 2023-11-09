using System;




class Program
{
    static void Main(string[] args)
    {
       
        int [ ] arr = {8,2,6};
        int y =0;

        foreach(int x in arr)
        {
            y +=x/2;
        }
        Console.WriteLine(y);




    }    



}