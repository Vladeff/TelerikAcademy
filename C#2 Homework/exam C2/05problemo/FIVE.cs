using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05problemo
{
    class FIVE
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string holeString = string.Empty;

            SortedSet<int> sortedNums = new SortedSet<int>();


            for (int i = 0; i < n; i++)
            {
                string lineString = Console.ReadLine();             // collect all text
                holeString += lineString + "\n";
            }


            for (int i = 0; i < holeString.Length; i++)
            {
                if (Char.IsDigit(holeString[i]))                    //collect only num and add to srotedSet
                    sortedNums.Add((holeString[i]) - '0');
            }


            string numbersAsString = string.Empty;
            foreach (var item in sortedNums)
            {
                numbersAsString += item;
            }

            //Console.WriteLine(num);  123468



            using (StringReader reader = new StringReader(holeString))
            {
                string line = string.Empty;

                do
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        if (line[5] == 'a')            // BEFORE       
                        {


                        }
                        else                            //AFTER
                        {
                            if (line[0] > line[line.Length - 1])  //4 is after 2                 //Console.WriteLine(num);  123468
                            {

                                char tmp = line[line.Length - 1];
                                string newString = numbersAsString.Replace(line[line.Length - 1], line[0])
                                                                   .Replace(line[0], tmp);

                            }
                          

                        }

                    }

                } while (line != null);
                Console.WriteLine(numbersAsString);
            }




            //
            // foreach (var item in sortedNums)
            // {
            //     Console.Write(item);
            // }
            // Console.WriteLine();



        }
    }
}
