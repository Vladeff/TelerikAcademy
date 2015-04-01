namespace ExtensionMethodsDelegatesLambdaLINQ
{
    using System;
    using System.Text;

    class SubstringExtensionMain
    {
        static void Main()
        {
            StringBuilder firstBuildTest = new StringBuilder("Stanislav");
            StringBuilder result1 = firstBuildTest.Substring(1);
            Console.WriteLine(result1);

            StringBuilder result2 = firstBuildTest.Substring(0, 4);
            Console.WriteLine(result2);
        }
    }
}