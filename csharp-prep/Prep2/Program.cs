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
        Console.WriteLine("Hello");

        Console.WriteLine("");

        Console.Write("Enter your Grade Number: ");
        string valveFromUser = Console.ReadLine();

        Console.WriteLine("");

        // Variables follow a simple pattern
        // Capital letter means letter grade + Example(B+,C+,D+)
        // Lower case letter means normal letter grade Example(A,B,C,D)
        // Double lower case letter means letter grade - Example(A-,B-,C-,D-)
        int x = int.Parse(valveFromUser);
        int a = 93;
        int aa = 90;
        int B = 87;
        int b = 83;
        int bb = 80;
        int C = 77;
        int c = 73;
        int cc = 70;
        int D = 67;
        int d = 63;
        int dd = 60;


        if (x >= a)
        {
            Console.WriteLine("A Great job, your crushing it!");
        }
        else if (x >= aa)
        {
            Console.WriteLine("A- That's pretty Great");
        }
        else if (x >= B)
        {
            Console.WriteLine("B+ is awesome so close to an A");
        }
        else if (x >= b)
        {
            Console.WriteLine("B that's pretty Good. Keep going!");
        }
        else if (x >= bb)
        {
            Console.WriteLine("B- you are going good! Keep up the Work");
        }
        else if (x >= C)
        {
            Console.WriteLine("C+ Your close to a B keep going!");
        }
        else if (x >= c)
        {
            Console.WriteLine("C Your doing good, remember to ask your Professor if you need Help!");
        }
        else if (x >= cc)
        {
            Console.WriteLine("C- That close to a D, remember to ask for help when needed.");
        }
        else if (x >= D)
        {
            Console.WriteLine("D+ That's a little low, remember to ask your Professor for help!");
        }
        else if (x >= d)
        {
            Console.WriteLine("D Oh no, remember you have resources to help your grade, Ask your Professor");
        }
        else if (x >= dd)
        {
            Console.WriteLine("D- That's really close to a F, remember to ask for help!");
        }
        else
        {
            Console.WriteLine("F Oh no, Please reach out for help, Your Professor is a great place to start!");
        }

        Console.WriteLine("");



   
    }
}