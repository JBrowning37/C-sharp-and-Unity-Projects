using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Collects input from the user
            Console.WriteLine("Enter a number to do some math operations on: ");
            int x = Convert.ToInt32(Console.ReadLine());

            //creates a new istance of the class 
            MathMethods mathMethods = new MathMethods();

            //calls the method Square and prints the result
            Console.WriteLine(x + " squared is " + mathMethods.Square(x).ToString());

            //calls the method minus and prints the result
            Console.WriteLine(x + " minus 3 is " + mathMethods.Minus(x).ToString());

            //calls the method plus and prints the result
            Console.WriteLine(x + " plus 12 is " + mathMethods.Addition(x).ToString());

            Console.ReadLine();
        }

    }
}
