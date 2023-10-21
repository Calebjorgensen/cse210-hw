using System;




class Program
{
    static void Main(string[] args)
    {  
        string input1 = Console.ReadLine();
        string input2 = Console.ReadLine();

        int number1 = Convert.ToInt32(input1);
        int number2 = Convert.ToInt32(input2);

        int answer = number1 + number2;

        Console.WriteLine(answer);
        

    }
       
}