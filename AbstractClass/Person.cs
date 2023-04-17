using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class Person
    {
        public Person()
        {
            Fname = "Jess";
            Lname = "Browning";
        }

        public string Fname { get; set; }
        public string Lname { get; set; }

        public abstract void SayName();
        
 
    }
}
