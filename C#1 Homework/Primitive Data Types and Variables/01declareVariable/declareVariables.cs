/*Problem 1. Declare Variables

Declare five variables choosing for each of them the most appropriate 
 * of the types byte, sbyte, short, ushort, int, uint, long, ulong to
 * represent the following values: 52130, -115, 4825932, 97, -10000.
Choose a large enough type for each number to ensure it will fit in it.
 * Try to compile the code. */


using System;

class declareVariables
{
    static void Main()
        {
            ushort shops = 52213;
            sbyte needOfInvestitors = -115;
            int peopleReadyToBuy = 4825932;
            byte banks = 97;
            short peopleWithDept = -10000;

            Console.WriteLine("In Sofia there are:");
            Console.WriteLine("Shops: " +shops);
            Console.WriteLine("Number of people ready to spend money: "+ peopleReadyToBuy);
            Console.WriteLine("Required number of investors: " + needOfInvestitors);
            Console.WriteLine( "People with debt: " + peopleWithDept);
            Console.WriteLine("Banks: " + banks );
        }
}

