using System;



class Calculator
{
   // public int _add;
    //public int _sub;
    //public int _mult;
    //public double _div;

    public Calculator()
    {
        Console.WriteLine("This is a Calculator Program");

    }

    public int Addition()
    {
        int add1 = Convert.ToInt32(Console.ReadLine());
        int add2 = Convert.ToInt32(Console.ReadLine());

        int addSum = add1 + add2;
        return addSum;
        
    }
    public int Substraction()
    {
        int sub1 = Convert.ToInt32(Console.ReadLine());
        int sub2 = Convert.ToInt32(Console.ReadLine());

        int subSum = sub1 - sub2;
        return subSum;

    }

    public int Times()
    {
        int muli1 = Convert.ToInt32(Console.ReadLine());
        int muli2 = Convert.ToInt32(Console.ReadLine());

        int muliSum = muli1 * muli2;
        return muliSum;
    }
    public double Division()
    {
        int div1 = Convert.ToInt32(Console.ReadLine());
        int div2 = Convert.ToInt32(Console.ReadLine());

        int divSum = div1 / div2;
        return divSum;

    }

    

}







class Program
{
    static void Main(string[] args)
    {
        Calculator math = new Calculator();
        Console.WriteLine(math.Addition());
        Console.WriteLine(math.Substraction());
        Console.WriteLine(math.Times());
        Console.WriteLine(math.Division());

    }    



}