using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambdas
{
    public class Program
    {
        public class Employee
        {
            public string Fname { get; set; }
            public string Lname { get; set; }
            public int id { get; set; }
        }

        static void Main(string[] args)
        {
            List<Employee> employee = new List<Employee>()
            {
                new Employee { Fname = "Bobby", Lname = "Bobberson", id = 1001},
                new Employee { Fname = "Joe", Lname = "Shmoe", id = 1002 },
                new Employee { Fname = "Mary", Lname = "Sue", id = 1003 },
                new Employee { Fname = "Elizabeth", Lname = "Schuyler", id = 1004 },
                new Employee { Fname = "Joe", Lname = "Joeyton", id = 1005 },
                new Employee { Fname = "Sammy", Lname = "Simpleton", id = 1006 },
                new Employee { Fname = "Bethany", Lname = "Winsor", id = 1007 },
                new Employee { Fname = "Tristan", Lname = "Motheral", id = 1008 },
                new Employee { Fname = "Joe", Lname = "Murphy", id = 1009 },
                new Employee { Fname = "Eloise", Lname = "Engston", id = 1010 }
            };

            //makes a list
            List<Employee> JoesList = new List<Employee>();

            //adds each employee to the list that has the first name joe
            foreach (Employee employee1 in employee)
            {
                if (employee1.Fname == "Joe")
                {
                    JoesList.Add(employee1);
                }
            }

            //creates a list and adds all employees with the name joe to it
            List<Employee> JoeList = employee.Where(x => x.Fname == "Joe").ToList();

            //makes a list of all employees with an id greater that 1005
            List<Employee> IdList = employee.Where(x => x.id > 1005).ToList();

            Console.ReadLine();
        }
    }
}
