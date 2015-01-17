using System;

    class curentDataTime
    {
        static void Main()
        {
            Console.Title = "Current Date and Time";
          ;
            DateTime now = DateTime.Now;
            Console.WriteLine("The current date and time is:");
            Console.WriteLine(now);
        }
    }

