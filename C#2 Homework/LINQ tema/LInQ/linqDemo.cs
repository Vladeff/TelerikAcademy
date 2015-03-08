using System;
using System.Collections.Generic;
using System.Linq;

class linqDemo
    {
        static void Main()
        {

             var numbers = new List<int>();

            numbers.Add(5);
            numbers.Add(10);
            numbers.Add(10);
            numbers.Add(150);
            numbers.Add(10);

            numbers.Where(x => x > 5);

        }
    }
