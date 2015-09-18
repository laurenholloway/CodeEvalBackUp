using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE.SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "4Always0 5look8 4on9 7the2 4bright8 9side7 3of8 5life5";
            //SPLIT STRING INTO AN ARRAY BY SPACES
            string final = "";
            string[] newLine = line.Split();
            //LOOP THROUGH THE ARRAY
            foreach(string word in newLine)
            {
                //FIND THE LENGTH OF THE STRING
                int lastIndex = word.Length - 1;
                //SUBSTRING THE 0 INDEX AND THE LENGTH INDEX/SET TO VARIABLES
                string first = word.Substring(0, 1);
                string last = word.Substring(lastIndex);
                string middle = word.Substring(1, lastIndex-1);
                //CONCATENATE THE VARIABLES IN REVERSE ORDER TO THE MAIN SUBSTRING
                string newWord = last + middle + first + " ";
                final = final + newWord;
            }
            Console.WriteLine(final);
        }
    }
}
