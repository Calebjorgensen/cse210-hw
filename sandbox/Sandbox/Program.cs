using System;
using System.ComponentModel.Design;

class Entry
{


    public Entry()
    {
        Console.WriteLine("Welcome to Sammy's Food Shack");
    }
    public string [] menu = {"soup","crab","steak","desert"};
    
    
    public void Display()
    {

    }
}

class Calculator
{

}




class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World");
        Entry e = new Entry();

        int [] arr = {124,324,523,532,234,554};
        int sum = 0;

        foreach(int x in arr)
        {
            sum += x;
        }
        Console.WriteLine(sum);
      
    }    



}