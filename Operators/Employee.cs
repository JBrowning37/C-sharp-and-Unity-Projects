using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Employee
    {
        public Employee()
        {
            Id = 1234;
        }
        public int Id { get; set; }

        public static  bool operator==(Employee employee, Employee employee2)
        {
            if (employee.Id == employee2.Id)
                return true;
            else
                return false;
        }
        public static bool operator !=(Employee employee, Employee employee2)
        {
            return employee != employee2;
        }

        //public static bool Equals(Employee employee, Employee employee2)
        //{
        //    return employee == employee2 || (employee != null && employee2 != null);
        //}

    }
}
