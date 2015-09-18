using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE.CapitalizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "hello world";
            string done = "";
            string[] newLine = line.Split();
            foreach(string word in newLine)
            {
                char[] character = word.ToCharArray();
                string oneChar = character[0].ToString();
                oneChar = oneChar.ToUpper();
                string newWord = word.Substring(1);
                string finalWord = oneChar + newWord;
                done = done + " " + finalWord;
            }
            Console.WriteLine(done);
        }
    }
}
