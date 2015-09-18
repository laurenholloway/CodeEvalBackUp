using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CE.RemoveCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "how are you, abc";
            //splits line at the comma
            string[] newLine = line.Split(',');
            //creates abc string as a tester
            string tester = newLine[1].Trim();
           /* string result = Regex.Replace(newLine[0], tester, "");
            Console.WriteLine(result);*/

           char[] Letters = tester.ToCharArray();
           if()
           
            
            
            Console.ReadLine();  
        }
    }
}
