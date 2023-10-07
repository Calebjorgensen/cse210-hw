using System;
using System.Xml.Serialization;



class Program
{
    static void Main(string[] args)
    {
        

        string choice;

        do{
        
            Console.WriteLine("Hello Prove # 2. I am going to code the crap out of you!");
            Console.WriteLine("");
            Console.WriteLine("Please select one of the options below");
            Console.WriteLine("1. New Entry: ");
            Console.WriteLine("2. Display Entries: ");
            Console.WriteLine("3. Load Journal; ");
            Console.WriteLine("4. Save Journal: ");
            Console.WriteLine("5. Exit ");
            Console.WriteLine("What would you like to do?");
            choice = Console.ReadLine();

            switch(choice)
            {
                case "1":
                Entry write = new Entry();
                write.PromptGen();
                break;

                case "2":
                // This should be used to display the display entries
                break;

                case "3":
                // This should be used to load up a journal file
                break;

                case "4":
                // This should be used to save a entry
                break;

                case "5":
                // To end the Program
                break;

            }
        } while(choice != "5");

    }
}