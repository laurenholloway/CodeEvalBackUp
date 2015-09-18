using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE.LongestWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "if line another text";
            string longest = "";
            string[] sentence = line.Split();
            int i;
            string current;
            for (i = 0; i < sentence.Length; i++)
            {
                current = sentence[i];
                if(current.Length > longest.Length)
                {
                    longest = current;
                }
                if(current.Length == longest.Length)
                {
                    longest = longest;
                }
            }
            Console.WriteLine(longest);
        }
    }
}
