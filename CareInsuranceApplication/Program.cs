using System;

    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Care Insurance Approval Application");

        Console.WriteLine("What is your age?");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Have you ever had a DUI? (Please write true or false)");
        bool DUI = Convert.ToBoolean(Console.ReadLine());

        Console.WriteLine("How many speeding tickets do you have?");
        int tickets = Convert.ToInt32(Console.ReadLine());

        bool isAccepted = age > 15 && DUI == false && tickets <= 3;

        Console.WriteLine("Qualified?");
        Console.WriteLine(isAccepted);


        Console.ReadLine();
        }
    }

