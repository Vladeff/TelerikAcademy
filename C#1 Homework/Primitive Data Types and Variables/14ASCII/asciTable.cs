/*Problem 7. Quotes in Strings

Declare two string variables and assign them with following value: The "use" of quotations causes difficulties.
Do the above in two different ways - with and without using quoted strings.
Print the variables to ensure that their value was correctly defined.*/

using System;
using System.Text;

class quotesInStrings
{
    static void Main()
    {
        
        Console.OutputEncoding = Encoding.ASCII;
        Console.OutputEncoding = System.Text.Encoding.GetEncoding(65001);
        int unicode = 0;
        for ( unicode = 0; unicode < 256; unicode++)
        {
        char character = (char)unicode;
              Console.Write(character + "  "); 
          }

        Console.WriteLine();

        
    }
}
    

