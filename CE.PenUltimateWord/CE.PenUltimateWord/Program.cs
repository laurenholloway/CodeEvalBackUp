using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE.PenUltimateWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "another line";
            string[] newLine = line.Split();
            int index = newLine.Length - 2;
            Console.WriteLine(newLine[index]);

        }
    }
}
