using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE.HappyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "22";
            int sum = 0;
            int digit;
            char[] newLine = line.ToCharArray();

            foreach(char character in newLine)
            {
                digit = Convert.ToInt32(character);
                digit = digit * digit;
                sum = sum + digit;
            }
            Console.WriteLine(sum);
           /* if (sum == 1)
            {
                Console.WriteLine("1");
            }
            else if (sum != 1)
            {
                Console.WriteLine("0");
            }*/

        }

          

        }

    }

