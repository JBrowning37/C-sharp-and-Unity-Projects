using System;

 class Program
    {
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Package Express! Please follow the instructions below:");

        Console.WriteLine("Please enter package weight:");
        int weight = Convert.ToInt32(Console.ReadLine());

        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            Console.ReadLine();
            Environment.Exit(0);
        };

        Console.WriteLine("Please enter package width:");
        int width = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please enter package height:");
        int height = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please enter package length:");
        int length = Convert.ToInt32(Console.ReadLine());

        if (width + height + length > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            Console.ReadLine();
            Environment.Exit(0);
        }
        else if (width + height + length < 50)
        {
            int dimensions = (width * height * length);
            int quote = (dimensions * weight /100);

            Console.WriteLine("Your estimated total for shipping this package is: " + ("$") + quote);
        };

        Console.ReadLine();
        }
    }

