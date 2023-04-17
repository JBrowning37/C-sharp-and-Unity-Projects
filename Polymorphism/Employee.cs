using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
        public class Employee : IQuittable
        {
            public Employee()
            {
                Id = 1234;
            }

        public int Id { get; set; }

        public void Quit()
        {
            Console.WriteLine("This is the quit method");
        }
    }
}
