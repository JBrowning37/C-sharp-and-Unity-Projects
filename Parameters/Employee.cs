using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters
{
    public class Employee<T> 
    {
        public List<T> Things { get; set; }
        public int Id { get; set; }

        public void PrintList()
        {
            foreach (var things in Things)
            {
                Console.WriteLine(things);
            }
        }
        
    }
}
