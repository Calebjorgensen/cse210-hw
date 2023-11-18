using System;

class Program
{
    static void Main(string[] args)
    {
        int user;

        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create new Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            user = Convert.ToInt32(Console.ReadLine());

            switch(user)
            {
                case 1:
                Console.WriteLine("");
                break;

                case 2:
                Console.WriteLine("");
                break;

                case 3:
                Console.WriteLine("");
                break;

                case 4:
                Console.WriteLine("");
                break;

                case 5:
                Console.WriteLine("");
                break;
            }

        }
    }
}