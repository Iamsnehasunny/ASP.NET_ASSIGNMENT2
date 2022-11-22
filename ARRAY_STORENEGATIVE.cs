//Program to store all negative elements in an array to another array?
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class ARRAY_STORENEGATIVE
    {
        public static void Main(string[] args)
        {
            int n;
            int c = 1;
            int[] negative = new int[15];
            int[] num = new int[15];// declare and allocate the memory of an array in a single line
            Console.WriteLine("enter the limit btween 10 - 15 \n");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the numbers\n");
            for (int i = 1; i <= n; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }
           
            Console.WriteLine("number of negative numbers in array of numbers =\n ");
            for (int i = 1; i <= n; i++)
            {
                if (num[i] < 0)
                {
                    negative[c] = num[i];
                    c = c + 1;
                }
            }
            for (int j = 1; j < c; j++)
            {
                Console.WriteLine(negative[j]);
            }

        }
    }
}
