using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //dividing instance = new dividing();

            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            dividing.div(number, out int result);
            Console.WriteLine(result);

            dividing.div(number);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
