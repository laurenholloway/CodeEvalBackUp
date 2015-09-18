using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE.RightmostChar
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "Hello World,r";
            int length = line.Length;
            char character = line[length-1];
            string newLine = line.Substring(0, length - 2);
            Console.WriteLine(newLine.LastIndexOf(character));
        }
    }
}
