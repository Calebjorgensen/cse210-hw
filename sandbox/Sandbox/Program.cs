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

        int choice;

        do
        {

            Console.WriteLine("1. For Addiction");
            Console.WriteLine("2. For Substraction");
            Console.WriteLine("3. For times");
            Console.WriteLine("4. for division");
            Console.WriteLine("5. To Exit");

            choice = Convert.ToInt32(Console.ReadLine());


        
        switch(choice)
        {
            case 1:
            Console.WriteLine("Case 1");
            break;

            case 2:
            Console.WriteLine("Case 2");
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