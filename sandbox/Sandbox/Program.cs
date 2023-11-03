using System;

class Calculator
{
   // public int _add;
    //public int _sub; 
    //public int _times;
    //public double _division;

    public Calculator() // Contructor
    {
        Console.WriteLine("Hello welcome to this app");
    }
}


class Program
{
    static void Main(string[] args)
    {
        Calculator c = new Calculator();

        int choice = Convert.ToInt32(Console.ReadLine());

        do 
        {
        switch(choice)
        {
            case 1:
            Console.WriteLine("Welcome to addiction");
            break;

            case 2:
            Console.WriteLine("Hello");
            break;

            case 3:
            Console.WriteLine("Case 3");
            break;

            case 4:
            Console.WriteLine("Case 4");
            break;
        }
        } while(choice != 5);
    }    



}