using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class arrays
    {
        static void Main10()
        {
            int[] a = { 10, 20 };

            int[,] matrix = new int[2,2];
            int[][] jagged = new int[3][];

            jagged[0] = new int[] { 1, 2, 3, 4, 5 };
            jagged[1] = new int[] { 1, 2 };
            jagged[2] = new int[] { 1, 2, 3};

            for (int i = 0; i < jagged.Length; i++)
            {
                for (int k = 0; k < jagged[i].Length; k++)
                {
                    Console.Write(jagged[i][k]);
                }
                Console.WriteLine();
            }

            int length = matrix.Length;

            Console.WriteLine("enter the values for matrix");
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {

                    matrix[row,col] = Convert.ToInt32(Console.ReadLine());
                }

            }
            Console.WriteLine("entered  for matrix are");
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {

                    Console.Write(matrix[row, col]+"\t");
                }
                Console.WriteLine();
            }

            int[] b=new int[2];
            for (int i = 0; i < b.Length; i++)
            {
                b[i]=Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Values entered from user");
            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine(b[i]);
            }

        }
    }
}
