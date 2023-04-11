using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            MathMethods firstInstance = new MathMethods();
            int x = 10;
            Console.WriteLine("x + 12 = " + firstInstance.Method(x).ToString());

            MathMethods secondInstance = new MathMethods();
            decimal y = 4.5m;
            Console.WriteLine("y - 3 = " + secondInstance.Method(y).ToString());

            //Console.WriteLine("please enter a number: ");
            //string z = Console.ReadLine();
            string z = "4";
            MathMethods thirdInstance = new MathMethods();
            Console.WriteLine(z + " * " + z + " = " + thirdInstance.Method(z).ToString());

            Console.ReadLine();
        }
    }
}
