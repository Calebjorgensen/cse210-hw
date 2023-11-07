using System;



class Calculator
{
   // public int _add;
    //public int _sub;
    //public int _mult;
    //public double _div;


    public int Addition()
    {
        int add1 = Convert.ToInt32(Console.ReadLine());
        int add2 = Convert.ToInt32(Console.ReadLine());

        int addSum = add1 + add2;
        Console.WriteLine(addSum);
        return addSum;
        
    }
    public int Substraction()
    {
        int sub1 = Convert.ToInt32(Console.ReadLine());
        int sub2 = Convert.ToInt32(Console.ReadLine());

        int subSum = sub1 - sub2;
        Console.WriteLine(subSum);
        return subSum;

    }

    public int Times()
    {
        int muli1 = Convert.ToInt32(Console.ReadLine());
        int muli2 = Convert.ToInt32(Console.ReadLine());

        int muliSum = muli1 * muli2;
        Console.WriteLine(muliSum);
        return muliSum;
    }
    public double Division()
    {
        double div1 = Convert.ToInt32(Console.ReadLine());
        double div2 = Convert.ToInt32(Console.ReadLine());

        double divSum = div1 / div2;
        Console.WriteLine(divSum);
        return divSum;

    }

    

}







class Program
{
    static void Main(string[] args)
    {
        string choice;
        Calculator math = new Calculator();

        do{
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Calculator here to help.");
        Console.WriteLine("Choose one of the options");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Substraction");
        Console.WriteLine("3. Times");
        Console.WriteLine("4. Division");
        Console.WriteLine("");

        choice = Console.ReadLine();

        switch(choice)
        {
            case "1":
            math.Addition();
            break;

            case "2":
            math.Substraction();
            break;

            case "3":
            math.Times();
            break;

            case "4":
            math.Division();
            break;
        }
        }while(choice != "5");

    }    



}