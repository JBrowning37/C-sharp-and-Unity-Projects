using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    public class Person
    {
        public Person()
        {
            Fname = "Jess";
            Lname = "Browning";
        }

        public string Fname { get; set; }
        public string Lname { get; set; }

        public void SayName()
        {
            Console.WriteLine("Name: " + Fname + " " + Lname);
        }
    }

    
    
}
