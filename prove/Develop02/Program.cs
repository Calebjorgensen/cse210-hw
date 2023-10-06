using System;
using System.Xml.Serialization;



class Program
{
    static void Main(string[] args)
    {
        string userinput;
        Entry input = new Entry();

        Console.WriteLine("Welcome to your Journal");
        
        do
        {
            Console.WriteLine("Please select one of the following choices");
            Console.WriteLine("1. Write Entry: ");
            Console.WriteLine("2. Display Journal: ");
            Console.WriteLine("3. Load Journal: ");
            Console.WriteLine("4. Save Journal: ");
            Console.WriteLine("5. Exit");
            userinput = Console.ReadLine();

            switch(userinput)
            {
                //Choice 1 New Entry
                case "1":
                break;

                //Choice 2 Display Journal
                case "2":
                break;

                //Save Journal
                case "3":
                break;

                //Load Journal
                case "4":
                break;

                //No case for option 5 as its the last one outside of the switch case.
            }




        }while(userinput != "0");
       
    }
}