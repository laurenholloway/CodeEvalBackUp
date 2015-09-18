using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE.DecimaltoBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "67";
            int num = Convert.ToInt32(line);
            string binary = Convert.ToString(num, 2);
            Console.WriteLine(binary);
            Console.ReadLine();
        }
    }
}
