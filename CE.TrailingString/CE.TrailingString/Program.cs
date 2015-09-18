using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE.TrailingString
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "San Francisco,San Jose";
            string[] newLine = line.Split(',');
            string searchTerm = newLine[1];
            string searchPhrase = newLine[0];

            if(searchPhrase.LastIndexOf(searchTerm) == -1)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(1);
            }
            
            Console.ReadLine();
        }
    }
}
