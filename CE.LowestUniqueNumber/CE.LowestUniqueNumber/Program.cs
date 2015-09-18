using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE.LowestUniqueNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "3 3 9 1 6 5 8 1 5 3";
            int i;
            int unique;
            int num;
            string[] newLine = line.Split();
            newLine = newLine.Distinct().ToArray();
            for (i = 0; i < newLine.Length; i++)
            {
                num = Convert.ToInt32(newLine[i]);
                Console.WriteLine(num);
            }

        }
    }
}
