using System;

    class beerTime
    {
        static void Main()
        {
            Console.Write("Hello!What time is it? (hh:mm tt)");
            string inputTime = Console.ReadLine();
            DateTime time;
            DateTime start = DateTime.Parse("1:00 PM");
            DateTime end = DateTime.Parse("3:00 AM");

            bool isParsed = DateTime.TryParse(inputTime, out time);
            if (isParsed)
            {
                if (time >= start && time < end)
                {
                    Console.WriteLine("Beer Time");
                }
                else
                {
                    Console.WriteLine("Non beer Time");
                }
            }
            else
            {
                Console.WriteLine("invalid time format");
                Console.WriteLine("Now its: " + DateTime.Now);
            }
        }
    }

