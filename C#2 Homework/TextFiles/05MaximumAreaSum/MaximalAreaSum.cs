﻿namespace MaximalAreaSum

 {
     // Write a program that reads a text file containing 
     // a square matrix of numbers.
     // Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
     // The first line in the input file contains the size of matrix N.
     // Each of the next N lines contain N numbers separated by space.
     // The output should be a single number in a separate text file.
     // Example:
     // input 	                    output
     // 4
     // 2 3 3 4
     // 0 2 3 4
     // 3 7 1 2
     // 4 3 3 2 	                    17

     using System;
     using System.IO;
     using System.Text;

      class MaximalAreaSum
     {
         private static int result = 0;
         private static int[,] subMatrix = new int[2, 2];

         static void Main()
         {
             
             int[,] matrix;
             int length;

             using (StreamReader readerResult = new StreamReader("../../InputFile.txt"))
             {
                 string line = readerResult.ReadLine();

                 length = int.Parse(line);

                 matrix = new int[length, length];

                 char[] characters = new[] { ' ' };

                 for (int lineNumber = 0; lineNumber < length; lineNumber++)
                 {
                     line = readerResult.ReadLine();

                     string[] numbers = line.Split(characters, StringSplitOptions.RemoveEmptyEntries);

                     for (int charNumber = 0; charNumber < length; charNumber++)
                     {
                         matrix[lineNumber, charNumber] = int.Parse(numbers[charNumber]);
                     }
                 }
             }


             for (int vertikal = 0; vertikal < length - 1; vertikal++)
             {
                 for (int horizontal = 0; horizontal < length - 1; horizontal++)
                 {
                     SubMatrixSum(matrix, vertikal, horizontal);
                 }
             }

            
             using (StreamWriter writer = new StreamWriter("../../result.txt"))
             {
                 writer.Write(result);
                 Console.WriteLine("result.txt - Done");
             }
         }

         private static void SubMatrixSum(int[,] array, int row, int column)
         {
             int sum = 0;

             for (int i = 0; i < 4; i++)
             {
                 sum += array[row + (i % 2), column + (i / 2)];
             }
             if (sum > result)
             {
                 for (int i = 0; i < 4; i++)
                 {
                     subMatrix[i % 2, i / 2] = array[row + (i % 2), column + (i / 2)];
                 }
                 result = sum;
             }
         }

         
     }
 }