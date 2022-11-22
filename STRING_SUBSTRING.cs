//Program to check whether a given substring is present in the given string
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class STRING_SUBSTRING
    {
        static void Main(string[] args)
        {
            Console.WriteLine("write sentance");
            string sentence = Console.ReadLine();
            String value = "and";
            Boolean result = sentence.Contains(value);
            Console.WriteLine($"Does string contain specified substring? {result}");
        }
    }
}
