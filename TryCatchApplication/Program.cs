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

            Console.WriteLine("Pick a number to divide all the numbers above by:");
            int divisor = Convert.ToInt32(Console.ReadLine());

            try
            {
                foreach (int num in numbers)
                {
                    int quotient = num / divisor;
                    Console.WriteLine(num + " divided by " + divisor + " equals " + quotient);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter a whole number.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please do not divide by zero.");
            }
            

            Console.WriteLine("Finished with try/catch block");



            Console.ReadLine();

            //try
            //{
            //    Console.WriteLine("Pick a number:");
            //    int numOne = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Pick a second number:");
            //    int numTwo = Convert.ToInt32(Console.ReadLine());
            //    int numThree = numOne / numTwo;
            //    Console.WriteLine(numOne + " divided by " + numTwo + " equals " + numThree);
            //    Console.ReadLine();
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine("Please type a whole number");
            //    return;
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Please don't divide by 0");
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.ReadLine();
            //}
        }
    }
}
