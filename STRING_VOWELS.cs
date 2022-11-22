//Find total number of vowels in a string

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class STRING_VOWELS
    {
        public static void Main()
        {
            int i, len, vowels;
            Console.WriteLine("write sentance");

            string sentence = Console.ReadLine();
            vowels = 0;
            len = sentence.Length;

            for (i = 0; i < len; i++)
            {

                
                if (sentence[i] == 'a' || sentence[i] == 'e' ||
                    sentence[i] == 'i' || sentence[i] == 'o' ||
                    sentence[i] == 'u' || sentence[i] == 'A' ||
                    sentence[i] == 'E' || sentence[i] == 'I' ||
                    sentence[i] == 'O' || sentence[i] == 'U')
                {
                    vowels++;
                }

            }
            Console.WriteLine("count of vowel = " + vowels);
        }
    }
}

