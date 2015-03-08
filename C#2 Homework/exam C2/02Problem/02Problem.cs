using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Problem
{
    class Problem
    {
        static long absDifference(long num1, long num2)              //http://stackoverflow.com/questions/339961/difference-between-2-numbers
        {
            return Math.Abs(num1 - num2);
        } 
        static void Main()
        {
            long[] sepMewsArray = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            int index = 1;
            long sum = 0;

            while (index < sepMewsArray.Length)
            {
                if (absDifference(sepMewsArray[index],sepMewsArray[index-1]) % 2 ==0)
                {
                    sum += absDifference(sepMewsArray[index], sepMewsArray[index - 1]);
                    index += 2;
                }
                else
                {
                    index++;
                }

            }
            Console.WriteLine(sum);
        }
    }
}
