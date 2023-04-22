using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>();

            employee.things = "This is a string";

            Employee<int> employee2 = new Employee<int>();

            employee2.things = 1234;

            Console.WriteLine(employee.things);
            Console.WriteLine(employee2.things);

            Console.ReadLine();

        }
    }
}
