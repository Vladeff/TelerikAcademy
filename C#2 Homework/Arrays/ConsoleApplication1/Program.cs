using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new String('-', 57));
            Console.WriteLine("Enter elements of the array in one lane separated by \",\":");
            Console.WriteLine(new String('-', 57));           
            string input = Console.ReadLine();
            Console.WriteLine();

            string[] inputToArray = input.Split(',');

            List<int> tempMaxSecElements = new List<int>();
            List<int> maxSecElements = new List<int>();

            //string maxSecuence = "";
            //string tempMaxSec = "";

            for (int i = 0; i < inputToArray.Length; i++)
            {


                if (((i < inputToArray.Length - 1) && ((inputToArray[i] == inputToArray[i + 1]))))
                {
                    tempMaxSecElements.Add(i);
                }
                else if (((i > 0) && ((inputToArray[i] == inputToArray[i - 1]))))
                {
                    tempMaxSecElements.Add(i);
                }
                if ((i < inputToArray.Length - 1) && (inputToArray[i] != inputToArray[i + 1]))
                {

                    if (tempMaxSecElements.Count > maxSecElements.Count)
                    {


                        maxSecElements = tempMaxSecElements.ToList();
                        tempMaxSecElements.Clear();
                    }
                    else
                    {
                        tempMaxSecElements.Clear();
                    }

                }

            }

            if (tempMaxSecElements.Count > maxSecElements.Count)
            {

                maxSecElements = tempMaxSecElements.ToList();
                tempMaxSecElements.Clear();
            }

            Console.WriteLine("The longest secuence of equal symbols is");
            for (int i = 0; i < maxSecElements.Count; i++)
            {
                if (i == maxSecElements.Count - 1)
                {
                    Console.Write("{0} - Total {1} equal elements", inputToArray[maxSecElements[i]], maxSecElements.Count);
                }
                else
                {
                    Console.Write("{0}, ", inputToArray[maxSecElements[i]]);
                }
            }
            Console.WriteLine();
            Console.WriteLine();
 
        }
    }
}
