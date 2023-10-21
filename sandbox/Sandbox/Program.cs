using System;




class Program
{
    static void Main(string[] args)
    {  

        
        int wins;
        int ties;

        wins = Convert.ToInt32(Console.ReadLine());
        ties = Convert.ToInt32(Console.ReadLine());

        double answer = (wins * 1) + (ties * 0.5);

        Console.WriteLine(answer);
        

    }
       
}