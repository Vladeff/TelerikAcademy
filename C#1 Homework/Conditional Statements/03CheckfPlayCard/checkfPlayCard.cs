/*Problem 3. Check for a Play Card

Classical play cards use the following signs to designate the card face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. 
 Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise*/


using System;

    class checkfPlayCard
    {
        static void Main()
        {
            Console.Write("Enter card sign:");
            string sign = Console.ReadLine();

            if (sign == "2" || sign == "3" || sign == "4" || sign == "5" || sign == "6" || sign == "7" || sign == "8" || sign == "9" || sign == "10" || sign == "J" || sign == "Q" || sign == "K" || sign == "A")
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }

