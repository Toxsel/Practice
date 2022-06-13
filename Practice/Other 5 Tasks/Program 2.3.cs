using System;

namespace Part3_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("График санитарных дней:");
            for (int i = 1; i <= 12; i++)
            {
                DateTime d = new DateTime(year, i, DateTime.DaysInMonth(year, i));
                if (d.Month < 10)
                {
                    Console.WriteLine($"{d.Day - (7 + (int)d.DayOfWeek - 4) % 7}.0{d.Month}");
                }
                else
                {
                    Console.WriteLine($"{d.Day - (7 + (int)d.DayOfWeek - 4) % 7}.{d.Month}");
                }
            }

        }
    }
}
