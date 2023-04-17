using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Id = 1234;

            Employee employee2 = new Employee();
            employee.Id = 12324;

            Console.WriteLine("Are employee1 and employee2's Id numbers the same?");
            Console.WriteLine(employee == employee2);

            Console.ReadLine();

        }
    }
}
