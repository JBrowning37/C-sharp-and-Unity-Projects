using System;
using System.Collections.Generic;


 class Program
{
   static void Main(string[] args)
   {
        string[] stringArray = { "hello", "shark", "matcha", "pretzel", "piano"};

        Console.WriteLine("Select an index from a string array (0-4):");
        int choose = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(stringArray[choose]);  


        int[] numArray = { 12, 16, 25, 61, 100, 199, 340};

        Console.WriteLine("Select an index from an array (0-6):");
        int choice = Convert.ToInt32(Console.ReadLine());

        if (choice < 6)
        {
            Console.WriteLine(numArray[choice]);
        }
        else
        {
            Console.WriteLine("That index does not exist :(");
        }

        List<string> intList = new List<string>();
        intList.Add("Dog");
        intList.Add("Cat");
        intList.Add("Mouse");
        intList.Add("Hamster");
        intList.Add("Lizard");

        Console.WriteLine("Please choose an index (0-4) from a list of animals:");
        int pet = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(intList[pet]);

        Console.Read();
   }
 }

