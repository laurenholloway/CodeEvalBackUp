using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CE.EmailValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "foo@bar.com";
            if(Regex.IsMatch(line, "@"))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            Console.ReadLine();
        }
    }
}
