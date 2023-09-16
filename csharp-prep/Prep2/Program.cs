using System;
using System.IO.Compression;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;
using System.Xml.Schema;

class Program
{
    static void Main(string[] args)
    {
        // Goal of this code is write a program takes the users grade input and lets them know if they passed the class. Use a series of if else statements. 
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("Enter your Grade Number: ");
        string valveFromUser = Console.ReadLine();

        int x = int.Parse(valveFromUser);
        int a = 90;
        int b = 80;
        int c = 70;
        int d = 60;


        if (x >= a)
        {
            Console.WriteLine("Great you got an A!");
        }
        else if (x >= b)
        {
            Console.WriteLine("B you are going good! Keep up the Work");
        }
        else if (x >= c)
        {
            Console.WriteLine("C Your doing good, remember to ask your Professor if you need Help!");
        }
        else if (x >= d)
        {
            Console.WriteLine("D Oh no, remember you have resources to help your grade, Ask your Professor");
        }
        else
        {
            Console.WriteLine("F Oh no, Please reach out for help, Your Professor is a great place to start!");
        }



   
    }
}