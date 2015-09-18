using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE.SwapElements
{
    class Program
    {
        static void Main(string[] args)
        {
            //split string into string array
            string line = "5 6 7 8 9 : 2-4";
            string[] newLine = line.Split();
            string final = "";
            string shortLine = line.Substring(0, 9);
            string[] shortArray = shortLine.Split();
            int firstNum, secondNum;

            //loop through each string
            for (int i = 0; i < newLine.Length; i++)
            {

                int findDash = newLine[i].IndexOf("-");
                if (findDash != -1)
                {

                    int lastIndex = newLine[i].Length - 1;
                    string lastChar = newLine[lastIndex];

                    firstNum = (Convert.ToInt32(newLine[i].Substring(0, findDash)));
                    secondNum = (Convert.ToInt32(newLine[i].Substring(findDash + 1)));
                    Console.WriteLine(firstNum);
             
                   //Above gives me each index I'm supposed to swap
                    
                   //Loop through each number and if     
                    if(i == firstNum)
                    {
                        newLine[i] = newLine[secondNum];
                        
                    }
                   
                    else if(i == secondNum)
                    {
                        newLine[i] = newLine[firstNum];
                    }

                   
                }

                final = final + " " + newLine[i];
               

            }
            Console.WriteLine(final);
        }
    }
}
