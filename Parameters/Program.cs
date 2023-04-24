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
            employee.Things = "This is a string";

            //The above isn't working to add a string but when I try doing it
            //Like the commented code below it throws an error when ran...
            //employee.Things.Add("This is a string");


            Employee<int> employee2 = new Employee<int>();
            employee2.Things.Add(1234);

            Console.ReadLine();

        }
    }
}
