using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    static class dividing
    {
        public static void div(int number, out int result)
        {
            result = number / 2;
        }

        public static void div(int number)
        {
            int number2 = 2;
            int result = number / number2;
        }
    }
}
