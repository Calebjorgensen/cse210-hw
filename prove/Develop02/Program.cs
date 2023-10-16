using System;
using System.Security.Cryptography;
using System.Xml;
using System.Xml.Serialization;



class Program
{
    static void Main(string[] args)
    {
        

        string choice;

        Journal j = new Journal();

        do{
        
            Console.WriteLine("Hello Prove # 2. I am going to code the crap out of you!");
            Console.WriteLine("");
            Console.WriteLine("Please select one of the options below");
            Console.WriteLine("1. New Entry: ");
            Console.WriteLine("2. Display Entries: ");
            Console.WriteLine("3. Save Journal: ");
            Console.WriteLine("4. Load journal: ");
            Console.WriteLine("5. Exit ");
            Console.WriteLine("What would you like to do?");
            choice = Console.ReadLine();

            switch(choice)
            {

                // ALL OF CASE ONE CONNECTS TO ENTRY SO FAR, NOTHING CONNECTS TO THE JOURNAL YET.
                case "1":
                j.Write();

                break;

                case "2":
                j.Display();
                
                break;

                case "3":
                j.SaveFile();
                break;

                case "4":
                // This should be used to save a entry
                break;

            }
        } while(choice != "5");

    }
}