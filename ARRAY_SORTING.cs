//Program to sort an array.[Accept values form user]
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class ARRAY_SORTING
    {
        public static void Main(string[] args)
        {
            int n;
            int temp;
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

            
            for (int i = 1; i <= n; i++)
            {
                for(int j = 1; j<i;j++)
                {
                    if (num[j] > num[i])
                    {
                        temp = num[i];
                        num[i] = num[j];
                        num[j] = temp;
                    }
                }
            }

            Console.WriteLine("arry after sort =\n ");
            for(int i = 1;i<=n;i++)
            {
                Console.WriteLine(num[i]);
            }
        }
    }
}
