using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 instance = new Class1();
            Console.WriteLine("Please enter a number: ");
            int x = Convert.ToInt32(Console.ReadLine());

            int y;
            try
            {
                Console.WriteLine("You can enter a second number or leave it blank:");
                y = int.Parse (Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("You have chosen not to enter a value so the default of 10 will be used.");
            }

            Console.WriteLine(instance.options(x));

            Console.ReadLine();
        }
    }
}
