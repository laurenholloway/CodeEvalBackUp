using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE.SumOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "496";

            char[] digitArray = line.ToCharArray();
            int i;
            int store = 0;
            string result;
            int final;
          
                for (i = 0; i < digitArray.Length; i++)
                {
                result = Convert.ToString(digitArray[i]);
                final = int.Parse(result);
                store = store + final;
                
            }
            Console.WriteLine(store);

        }
    
        }
    }


