//Program to count even and odd elements in an array.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class ARRAY_EVENODD
    {
        public static void Main(string[] args)
        {
            int n;
            int c = 0;
            int d = 0;
            int[] num = new int[15];// declare and allocate the memory of an array in a single line
            Console.WriteLine("enter the limit btween 10 - 15 \n");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the numbers\n");
            for(int i = 1; i<=n; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
                if (num[i] % 2 == 0)
                {
                    c = c + 1;
                }
                else
                {
                    d = d + 1;
                }
            }
            Console.WriteLine("number of even numbers in array of numbers =\n " + c);
            Console.WriteLine("number of odd numbers in array of numbers =\n " + d);

        }
       


    }
}
