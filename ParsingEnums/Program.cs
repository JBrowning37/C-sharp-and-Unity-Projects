using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a day of the week");
            string day = Console.ReadLine();
            try
            {
                //DaysOfTheWeek entry = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), day);
                int underlyingvalue = (int)Enum.Parse(typeof(DaysOfTheWeek), day);
                Console.WriteLine(underlyingvalue);
            }
            catch
            {
                Console.WriteLine("Please write a valid day of the week");
            }

            Console.ReadLine();
        }
        public enum DaysOfTheWeek
        {
            Sunday,
            Munday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
        }
    }
}
