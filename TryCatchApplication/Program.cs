using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating a list of integers
            List<int> numbers = new List<int>() { 6, 12, 16, 18, 20 };

            //Prints the list with each entry on a seperate line
            Console.WriteLine("Here is a list of numbers");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            //try block that divides all numbers in list by entered number
            //There are catches to catch if someone enters a zero, a decimal, or a string
            try
            {
                //collects a number from user
                Console.WriteLine("Pick a number to divide all the numbers above by:");
                int divisor = Convert.ToInt32(Console.ReadLine());

                foreach (int num in numbers)
                {
                    int quotient = num / divisor;
                    Console.WriteLine(num + " divided by " + divisor + " equals " + quotient);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a whole number.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Please do not divide by zero.");
            }
            
            //Tells the user that they have exited the try/catch block
            Console.WriteLine("Finished with try/catch block");

            Console.ReadLine();
        }
    }
}
