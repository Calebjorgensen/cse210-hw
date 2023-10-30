using System;
using System.Security.Principal;





class Program
{
    static void Main(string[] args)
    {  
        int bullets = 10;

        while(bullets>0)
        {
            Console.WriteLine($"Bullets left {bullets}");
            bullets--;
        }

    }
       
}