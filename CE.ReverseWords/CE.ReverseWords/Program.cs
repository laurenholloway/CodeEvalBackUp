using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE.ReverseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            //This line comes from CodeEval

            string store = "";
       //STEP 1: SPLIT STRING INTO ARRAY
            string line = "hello codeeval";
            string[] arrayLine = line.Split();

       //STEP 2: REVERSE ITEMS IN THE ARRAY
            Array.Reverse(arrayLine);

       //STEP 3: PUT THE ITEMS BACK TOGETHER INTO A STRING
            foreach(string result in arrayLine)
            {
                store = store + " " + result;
            }

            Console.WriteLine(store);
            
            
            
            
            
            
            
            

            
            
            /*string line = "hello codeeval";
            string final = "";
            if (line != "")
            {
                string[] sentence = line.Split();
                Array.Reverse(sentence);

                foreach (string word in sentence)
                {
                    //Console.WriteLine(word);
                    final = final + " " + word;
                }
                Console.WriteLine(final);
            }*/
        }
    }
}
