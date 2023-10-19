using System;




class Program
{
    static void Main(string[] args)
    {  

        int [] a = new int [10];
        for (int k = 0; k < 10; k ++)
        {
            a[k] = k*2;
        }
        for (int k = 0; k < 10; k ++)
        {
            Console.WriteLine(a[k]);
        }
    }
       
}