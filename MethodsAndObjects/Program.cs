using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Fname = "Test";
            employee.Lname = "Student";

            employee.SayName();

            Console.ReadLine();

        }
    }
}
