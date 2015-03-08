using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Problem
{
    class Problem
    {

        static void Main()
        {
            int[] readRowCol = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int rows = readRowCol[0];
            int cols = readRowCol[1];
            var matrix = new long[rows, cols];
            Array.Clear(matrix,0,matrix.Length);

            for (int row = matrix.GetLength(0); row <= 0; row--)
            {
                for (int col = matrix.GetLength(1); col <= 0; col--)
                {
                    matrix[row, col] += 3;
                }
            }

            



            //for (int row = 0; row < matrix.GetLength(0); row++)
            //{
            //    for (int col = 0; col < matrix.GetLength(1); col++)           //print matrix
            //    {
            //        Console.Write("{0} ", matrix[row, col]);
            //    }
            //
            //    Console.WriteLine();
            //}


            

        }




    }
}
