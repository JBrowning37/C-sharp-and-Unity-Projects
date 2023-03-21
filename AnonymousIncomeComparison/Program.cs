using System;

    class Program
    {
        static void Main(string[] args)
        {
        //Writes title of the program
        Console.WriteLine("Anonymous Income Comparison Program");

        //Asks for hourly rate and hours worked of person 1 and converts them to int
        Console.WriteLine("Person 1");
        Console.WriteLine("Hourly Rate:");
        string hourRate1 = Console.ReadLine();
        int hourNum1 = Convert.ToInt32(hourRate1);
        Console.WriteLine("Hours Worked Per Week:");
        string perWeek1 = Console.ReadLine();
        int hours1 = Convert.ToInt32(perWeek1);

        //Asks for hourly rate and hours worked of person 2 and converts them to int
        Console.WriteLine("Person 2");
        Console.WriteLine("Hourly Rate:");
        string hourRate2 = Console.ReadLine();
        int hourNum2 = Convert.ToInt32(hourRate2);
        Console.WriteLine("Hours Worked Per Week:");
        string perWeek2 = Console.ReadLine();
        int hours2 = Convert.ToInt32(perWeek2);

        //Converts info received above into annual salary
        int result1 = hours1 * 4 * 12 * hourNum1;
        int result2 = hours2 * 4 * 12 * hourNum2;

        //writes out the annual salary of both people
        Console.WriteLine("Annual salary of Person 1: " + result1);
        Console.WriteLine("Annual salary of Person 2: " + result2);

        //Compares salary and prints true or false statement
        Console.WriteLine("Does Person 1 make more than Person 2?");
        bool TrueorFalse = result1 > result2;
        Console.Write(TrueorFalse.ToString());

        Console.ReadLine();

        }
    }