using System;
using System.Collections.Generic;
using System.Linq;





class Program
{
    static void Main(string[] args)
    {
        ////Here is a one dimensional array of strings
        //string[] stringArray = { "Go", "Try", "See", "Walk", "Fish" };

        ////A loop that prints each string on a different line
        //Console.WriteLine("Here is list of words:");
        //foreach (string str in stringArray)
        //{
        //    Console.WriteLine(str);
        //}

        ////This asks the user to input some text
        //Console.WriteLine("Write three letters you can add to the end of all of these words to make new ones?");
        //string ing = Console.ReadLine();

        ////This loop interates through each string and adds their text input to the end
        //foreach (string str in stringArray)
        //{
        //    Console.WriteLine(str + ing);
        //}

        ////This was an infinite loop but adding the break makes it only execute once
        //while (true)
        //{
        //    Console.WriteLine("Without the break; this would be infinite.");
        //    break;
        //}

        ////This is a loop that uses a < to determine if it continues iterating
        //Console.WriteLine("This is a loop that uses a < operator:");
        //int x = 1;
        //while (x < 9)
        //{
        //    Console.WriteLine(x);
        //    x++;
        //}

        ////This is a loop that is the same as the previous but uses <=
        //Console.WriteLine("This is a loop that uses a <= operator:");
        //int y = 0;
        //while (y <= 10)
        //{
        //    Console.WriteLine(y);
        //    y++;
        //}

        ////This lets a user input text to search a list and see the index
        //string[] petArray = { "zero", "dog", "cat", "fish", "bird", "rabbit", "guinea pig", "turtle", "hamster", "lizard", "ferret" };
        //Console.WriteLine("Type a pet to see where it is in the popular pet list:");
        //string petChoice = Console.ReadLine();

        //bool match = false;

        //for (int i = 0; i < petArray.Length; i++)
        //{
        //    if (petArray[i] == petChoice)
        //    {
        //        match = true;
        //        int index = Array.IndexOf(petArray, petChoice);
        //        Console.WriteLine("This is " + index + " on the list!");
        //        break;
        //    }
        //}
        //if (match == false)
        //{
        //    Console.WriteLine("This is not on the list!");
        //}

        //Below is my first attempt at part 5 of this assignment

        //string[] MatchArray = { "hello", "couch", "cupcake", "lemon", "duplicate", "candle", "duplicate" };
        //Console.WriteLine("Typing \'dupilicate\' will show both indices where it appears on the list:");
        //string MatchChoice = Console.ReadLine();

        //bool matching = false;

        //for (int i = 0; i < MatchArray.Length; i++)
        //{
        //    if (MatchArray[i] == MatchChoice)
        //    {
        //        matching = true;
        //        Console.WriteLine("This is " + i + " on the list!");
        //    }
        //}
        //if (matching == false)
        //{
        //    Console.WriteLine("This is not a duplicate!");
        //}
        //Console.ReadLine();



        List<string> List1 = new List<string>(){ "entry 1", "entry 2", "entry 3", "entry 4", "entry 5", "entry 2"};
        List<string> List2 = new List<string>();

        foreach (string entry in List1)
        {
            if (!List2.Contains(entry))
            {
                Console.WriteLine(entry + " has not appeared on the list yet!");
                List2.Add(entry);
            }
            else if (List2.Contains(entry))
            {
                Console.WriteLine(entry + " has appeared on this list!");
            }
        }
        Console.ReadLine();
    }
}


