namespace ExtensionMethodsDelegatesLambdaLINQ
{
    using System;
    using System.Collections.Generic;

    class IEnumerableExtensionsMain
    {
        static void Main()
        {
            List<double> numbers = new List<double> { 1, 3, 50, 100, 1000 };


            double sum = numbers.SumAll<double>();  //test the SumAll extension method
            Console.WriteLine("Sum: {0}", sum);

            double product = numbers.ProductAll<double>();  //test the ProductAll extension method
            Console.WriteLine("Product: {0}", product);

            double minValue = numbers.MinAll<double>();     //test the MinAll extension method
            Console.WriteLine("Min Value: {0}", minValue);

            double maxValue = numbers.MaxAll<double>();     //test the MaxAll extension method
            Console.WriteLine("Max Value: {0}", maxValue);

            double averageValue = numbers.AverageAll<double>(); //test the AverageAll extension method
            Console.WriteLine("Average Value: {0}", averageValue);
        }
    }
}