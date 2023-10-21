using System;




class Program
{
    static void Main(string[] args)
    {  
        // This is getting the input from the user
        string input1 = Console.ReadLine();
        string input2 = Console.ReadLine();

        // This is converting the string input into an Int
        int number1 = Convert.ToInt32(input1);
        int number2 = Convert.ToInt32(input2);

        // Adding the too new Ints 
        int answer = number1 + number2;

        Console.WriteLine(answer);
        

    }
       
}