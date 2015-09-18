using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE.SwapCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "JavaScript language 1.8";
            string final = "";
            string character;
            char[] letters = line.ToCharArray();
            foreach(char letter in letters)
            {
                character = letter.ToString();
                if (character == character.ToUpper())
                {
                    character = character.ToLower();
                }
                else if(character == character.ToLower())
                {
                    character = character.ToUpper();
                }
                final = final + character;
            }
            Console.WriteLine(final);
        }
    }
}
