using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE.ReadMore
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "Two thousand verses is a great many - very, very great many.";
            if(line.Length <= 55)
            {
                Console.WriteLine(line);
            }

            else if(line.Length > 55)
            {
                line = line.Substring(0, 39);
                line = line.Trim();
                Console.WriteLine(line + "... <Read More>");
            } 
                
        }
    }
}
