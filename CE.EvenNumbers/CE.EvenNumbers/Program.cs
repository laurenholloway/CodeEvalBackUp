using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE.EvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "745";
            int number = Convert.ToInt32(line);
            if (number % 2 == 0)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
