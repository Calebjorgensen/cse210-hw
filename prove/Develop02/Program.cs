using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");

       Journal journal1 = new Journal();
       journal1._display = "1. Display";
       journal1._load = "2. Load";
       journal1._save = "3. Save";
       journal1._exit = "4. Exit";
       journal1.Display();
       
       /* int choice = 3;

        switch(choice)
        {
            case 1:
            Console.WriteLine("Test Case 1");
            break;

            case 2:
            Console.WriteLine("Test Case 2");
            break;

            case 3:
            Journal journal1 = new Journal();
            journal1._display = "Display";
            break;

        }
        */

        

    }
}