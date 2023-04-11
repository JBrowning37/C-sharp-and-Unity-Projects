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

            Console.WriteLine("You can enter a second number or leave it blank:");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(instance.options(x, y));

            Console.ReadLine();
        }
    }
}
