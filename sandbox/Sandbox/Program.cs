using System;




class Program
{
    static void Main(string[] args)
    {  

        int [] a = new int [20];
        for (int k = 0; k < 20; k ++)
        {
            a[k] = k*2;
        }
        for (int k = 0; k < 20; k ++)
        {
            Console.WriteLine(a[k]);
        }
    }
       
}