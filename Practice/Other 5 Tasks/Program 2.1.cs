using System;
using System.Globalization;

namespace Part3_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d;
            GregorianCalendar cal = new GregorianCalendar();
            int Сount, DayN;
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            string data = $"{c}, {b}, {a}";
            if (DateTime.TryParse(data, out d)){
                DayN = cal.GetDayOfYear(d);
                if (cal.IsLeapYear(c)){
                    Сount = 366 - DayN;
                }
                else{
                    Сount = 365 - DayN;
                }
                Console.WriteLine("Номер дня с начала года:" + " " + DayN);
                Console.WriteLine("Дней до конца года:" + " " + Сount);
            }
            else{
                Console.WriteLine("Дата введена некорректно");
            }
        }
    }
}
