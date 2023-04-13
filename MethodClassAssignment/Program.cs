using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            MathMethod instance = new MathMethod();

            int number1 = 12;
            int number2 = 3;
            instance.Output(number1, number2);

            Console.ReadLine();
        }
    }
}