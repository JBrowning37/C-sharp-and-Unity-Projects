﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Employee : Person
    {
        public Employee()
        {
            Id = 1234;
        }

        public int Id { get; set; }

        public override void SayName()
        {
            Console.WriteLine("Name: " + Fname + " " + Lname);
        }

    }
}
