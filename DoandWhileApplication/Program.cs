using System;

class Program
    {
        static void Main(string[] args)
        {

        //This is a demonstration of a while loop
        Console.WriteLine("Guess a four letter word:");
        string word = Console.ReadLine();

        bool wordGuess = false;

        do
        {
            switch (word)
            {
                case "fast":
                    Console.WriteLine("Nope, that's not it");
                    Console.WriteLine("Guess a four letter word:");
                    word = Console.ReadLine();
                    break;
                case "milk":
                    Console.WriteLine("That's not it silly");
                    Console.WriteLine("Guess a four letter word:");
                    word = Console.ReadLine();
                    break;
                case "gold":
                    Console.WriteLine("Nope");
                    Console.WriteLine("Guess a four letter word:");
                    word = Console.ReadLine();
                    break;
                case "bear":
                    Console.WriteLine("Bear-y good! That is correct!");
                    wordGuess = true;
                    break;
                default:
                    Console.WriteLine("That is not correct");
                    Console.WriteLine("Guess a four letter word:");
                    word = Console.ReadLine();
                    break;
            }
        } while (!wordGuess);



        //This is a demonstration of a while loop

        Console.WriteLine("Now guess a number 1-5:");
        int number = Convert.ToInt32(Console.ReadLine());

        bool guess = false;

        while (!guess) 
        {
            switch (number)
            {
                case 5:
                    Console.WriteLine("You are correct!");
                    guess = true;
                    break;
                default:
                    Console.WriteLine("That is not correct.");
                    Console.WriteLine("Guess a number 1-5:");
                    number = Convert.ToInt32(Console.ReadLine());
                    break;
            }
        }
        

        Console.ReadLine();
    }
    }

