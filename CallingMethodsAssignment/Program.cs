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
            Console.WriteLine("Enter a number: ");
            int x = Convert.ToInt32(Console.ReadLine());

            MathMethods mathMethods = new MathMethods();
            Console.WriteLine(x + " squared is " + mathMethods.Square(x).ToString());

            Console.WriteLine(x + " minus 3 is " + mathMethods.Minus(x).ToString());

            Console.WriteLine(x + " plus 12 is " + mathMethods.Addition(x).ToString());

            Console.ReadLine();
        }

    }
}
