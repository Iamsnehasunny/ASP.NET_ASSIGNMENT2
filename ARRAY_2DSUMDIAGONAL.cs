//Program to add diagonal elements of two-dimensional array

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class ARRAY_2DSUMDIAGONAL
    {

        static void Main(string[] args)
        {
            int total=0;
            
            int[,] arr = new int[10, 10];
            Console.Write("Enter elements of the Matrix: \n");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arr[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }
            Console.WriteLine("Printing Matrix: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.Write("Diagonals are : ");
            for (int row = 0; row < 3; row++)
            {
                for (int column = 0; column < 3; column++)
                {
                    if (row == column)
                    {
                        Console.Write(arr[row, column] + " ");
                        total += arr[row, column];
                    }
                }
            }
            Console.WriteLine("\n Sum : " + total);

        }

    }
}
