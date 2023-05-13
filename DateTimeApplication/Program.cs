using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;
            Console.WriteLine(dateTime);
            Console.WriteLine("Please enter a number");
            int number = Convert.ToInt32(Console.ReadLine());

            dateTime = dateTime.AddHours(number);
            Console.WriteLine("In {0} hours it will be: {1}", number, dateTime);
            Console.WriteLine(dateTime);

            Console.ReadLine();
        }
    }
}
