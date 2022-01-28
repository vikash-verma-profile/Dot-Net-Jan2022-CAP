using System;
using System.Collections.Generic;
using System.Text;

namespace _2DataTypesAndArray
{
    class Program
    {
        public static void Main2(string[] args)
        {
            int[,] samplearray1 = new int[2, 2] { { 1, 2 }, { 3, 4 } };
            int[,] samplearray2 = new int[2, 2] { { 1, 2 }, { 3, 4 } };
            int[,] samplearray3 = new int[2, 2] { { 1, 2 }, { 3, 4 } };

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    samplearray3[i,j]= samplearray1[i, j] + samplearray2[i, j];

                }
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    samplearray3[i, j] = samplearray1[i, j] + samplearray2[i, j];

                }
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(samplearray3[i, j] + "\t");

                }
                Console.WriteLine();
            }
        }
    }
}
