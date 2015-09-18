using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE.ArmstrongNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "153";
           // int sum = 0;
            int startingNumber = Convert.ToInt32(line);
            char[] digitsChar = line.ToCharArray();
            int length = digitsChar.Length;
           

            foreach(char number in digitsChar)
            {
              //Convert.ToString(number);
                Convert.ToInt32(number);               
                //int powered = Math.Pow(number,length);
                

                Console.WriteLine(number);
            } 

            
        }
    }
}
