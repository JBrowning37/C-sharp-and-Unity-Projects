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

            instance.Output(12, 3);

            instance.Output(number1: 3, number2: 5);

            Console.ReadLine();
        }
    }
}