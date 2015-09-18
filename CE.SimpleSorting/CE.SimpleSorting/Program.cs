using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE.SimpleSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "70.920 -38.797 14.354 99.323 90.374 7.581";

            string[] stringarray = line.Split();
            int[] numbersArray = new int[stringarray.Length];
            for(int i = 0; i<stringarray.Length; i++)
            {
                stringarray[i].ToString();
                numbersArray[i] = int.Parse(stringarray[i]);
                
            }
            Array.Sort(numbersArray);
            foreach (int num in numbersArray)
            {
                Console.WriteLine(num);
            }
            

           
            
            
        }
    }
}
