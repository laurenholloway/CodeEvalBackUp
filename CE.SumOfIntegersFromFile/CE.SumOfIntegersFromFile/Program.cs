using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE.SumOfIntegersFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            int final = 0;
            string[] arrayline = line.Split();
           foreach(string singleline in line)
            {
                int newLine = Convert.ToInt32(singleline);
                final = final + newLine;
            }
            
            Console.WriteLine(final);
            
        }
    }
}
