using System;
using System.Collections.Generic;
using System.Text;

namespace _2DataTypesAndArray
{
    class JaggedArray
    {

        //jagged array is array of arrays
        public static void Main4(string[] args)
        {
            //example of jagged array
            int[][] jaggedarray = new int[3][];
            jaggedarray[0] = new int[5];
            jaggedarray[1] = new int[4];
            jaggedarray[2] = new int[2];

            jaggedarray[0] = new int[] { 1, 3, 5, 7, 9 };
            jaggedarray[1] = new int[] { 0, 2, 4, 6 };
            jaggedarray[2] = new int[] { 11,22};

            for (int row = 0; row < jaggedarray.Length; row++)
            {
                Console.WriteLine("Row"+row);
                for (int col = 0; col < jaggedarray[row].Length; col++)
                {
                    Console.Write(jaggedarray[row][col]);
                }
                Console.WriteLine();

            }

        }
    }
}
