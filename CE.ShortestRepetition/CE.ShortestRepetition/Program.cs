using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE.ShortestRepetition
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "abcabcabcabcabc";
            char[] pattern = line.ToCharArray();
            char[] characters = pattern.Distinct<char>().ToArray<char>();
            Console.WriteLine(characters.Length);
        }
    }
}
