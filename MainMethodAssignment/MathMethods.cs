using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class MathMethods
    {
        public int Method(int x)
        {
            return x + 12;
        }

        public decimal Method(decimal y)
        {
            return y - 3;
        }

        public int Method(string z)
        {
            int input = Int32.Parse(z);
            return input * input;
        }
    }
}
