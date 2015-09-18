using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE.AgeDistribution
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "19";
            int newLine = Convert.ToInt32(line);

            if(newLine >=0 && newLine <= 2)
            {
                Console.WriteLine("Still in Mama's arms");
            }
            else if(newLine >=3 && newLine <= 4)
            {
                Console.WriteLine("Preschool Maniac");
            }
            else if(newLine>=5 && newLine <= 11)
            {
                Console.WriteLine("Elementary school");
            }
            else if(newLine>=12 && newLine <= 14)
            {
                Console.WriteLine("Middle School");
            }
            else if(newLine>=15 && newLine <= 18)
            {
                Console.WriteLine("High School");
            }
            else if(newLine>=19 && newLine <= 22)
            {
                Console.WriteLine("College");
            }
            else if(newLine>=23 && newLine <= 65)
            {
                Console.WriteLine("Working for the man");
            }
            else if(newLine>=66 && newLine <= 100)
            {
                Console.WriteLine("The Golden Years");
            }
            else
            {
                Console.WriteLine("This program is for humans");
            }
        }
    }
}
