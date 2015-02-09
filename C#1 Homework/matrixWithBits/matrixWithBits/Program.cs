using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrixWithBits
{
    class Program
    {
        static void Main()
        {
            bool[,] track = new bool[8, 8];
            for (int i = 0; i < 8; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                for (int j = 0; j < 8; j++)
                {
                    track[i, j] = ((currentNumber >> j) & 1) != 0; ;
                
                }
                int row = 0;
                int col = 0;

                string direction = "down";
                string lastDirection ="down";
                int pathCount = 0;
                int directionCount = 0;

                bool exitFound = false;

                while (true)
                {
                    if (!track[row, col])   //dali e razlichen ot 0
                    {
                        break;
                    }                     
                    pathCount++;

                    if (row ==7 && col ==7)
                    {
                        exitFound = true;
                        break;
                    }
                    if(direction =="down" && (row + 1>7||track[row+1,col] ))
                    {
                        direction = "left" ;

                        if (col + 1 > 7 || track[row, col + 1])
                        {
                            break;
                        }
                        else if (direction =="up"&&(row -1<0 ||track[row-1,col]) )
                        {
                            direction = "left" ;
                        }

                         else if (direction =="left" && lastDirection =="down" && (col +1 >7 || track[row,col+1>]))

                            {
                             direction = "up";
                            }
                        }
                    }

                    if (direction =="down")
                    {
                        row++;
                    }
                    else if (direction == "left" )
                    {
                        col++; // poneve wyrvim nalqvo e ++ ako beshe nadqsno --
                    }
                    else if (direction =="up")
                    {
                        row--;
                    }

                }

                if(exitFound)
                {
                    Console.WriteLine(pathCount +" "+directionCount);
                }
                else
                {
                    Console.WriteLine("No "+ pathCount);
                }
            }

        }
    }
}
