using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    class Employee : Person
    {
        public Employee ()
        {
            Id = 12;
        }
        public int Id { get; set; }

    }
}
