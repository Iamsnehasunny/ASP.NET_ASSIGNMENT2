//Find total number of words in a string?

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class STRING_TOTWORDS
    {

        public static void Main()
        {
            Console.WriteLine("write sentance");

            string sentence = Console.ReadLine();
            int wordCount = 1;

            for (int i = 0; i < sentence.Length - 1; i++)
            {
                if (sentence[i] == ' ' || sentence[i] == '\n' || sentence[i] == '\t')
                {
                    wordCount++;
                }
            }
           
            Console.WriteLine("Total number of words in the given string: " + wordCount);
        }

    }
}
