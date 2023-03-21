using System;

namespace TechAcademyDR
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opening lines
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");

            // Asks for name and says hello
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("Hello " + yourName + "!");

            //asks what course they are on
            Console.WriteLine("What course are you on?");
            string StudentCourse = Console.ReadLine();

            //asks what page number they are on and converts string to int
            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            int pgNum = Convert.ToInt32(pageNumber);

            //asks if they need help with anything and converts string to bool
            Console.WriteLine("Do you need help with anything? Please answer \"True\" or \"False\"");
            string help = Console.ReadLine();
            bool needHelp = Convert.ToBoolean(help);

            //Asks for specifics on positive experiences 
            Console.WriteLine("Were there any positive experiences you would like to share? Please be specific.");
            string posiExp = Console.ReadLine();

            //Asks for specific feedback
            Console.WriteLine("Is there any feedback you would like to provide? Please be specific.");
            string feedback = Console.ReadLine();

            //Ask how many hours they studied
            Console.WriteLine("How many hours did you study?");
            string hoursStudied = Console.ReadLine();
            int hours = Convert.ToInt32(hoursStudied);

            //says thank you 
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");

            Console.ReadLine();


        }
    }
}
