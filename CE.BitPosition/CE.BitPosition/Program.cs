using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE.BitPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "25,1,2";
            string[] newLine = line.Split(',');
            string binary = Convert.ToString(Convert.ToInt32(newLine[0]), 2);
            int p1 = Convert.ToInt32(newLine[1]);
            int p2 = Convert.ToInt32(newLine[2]);
            int length = binary.Length;
      
            int first = binary[length-p1];
            int second = binary[length - p2];

            if(first == second)
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
