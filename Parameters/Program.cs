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
            //instatiates an employee object with type string
            Employee<string> employee = new Employee<string>();
            //instatiates an employee object with type int
            Employee<int> employee2 = new Employee<int>();

            //assgins a list of int or string with the property value things
            employee.Things = new List<string>() { "one", "two", "Three", "four", "five" };
            employee2.Things = new List<int>() { 1, 2, 3, 4, 5 };

            //loop that prints all the string employee list
            for (int i = 0; i< employee.Things.Count();i++)
            {
                Console.WriteLine(employee.Things[i]);
            }

            //loop that prints all the int emlpoyee list
            for (int i = 0; i < employee2.Things.Count(); i++)
            {
                Console.WriteLine(employee2.Things[i]);
            }

            Console.ReadLine();
        }
    }
}
