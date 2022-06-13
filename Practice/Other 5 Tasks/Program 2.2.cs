using System;

namespace Part3_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            double S = Convert.ToDouble(Console.ReadLine());
            for (int i = 1; i < 999; i++)
            {
                for (int j = 1; j < 999; j++)
                {
                    double simp = (i * j) / 2;
                    double g = Math.Sqrt(Math.Pow(i, 2) + Math.Pow(j, 2));
                    if (g == Math.Truncate(g) && (simp < S))
                    {
                        Console.WriteLine($"a={i}, b={j}, c={g}, s={simp}");
                    }
                }
            }

        }
    }
}
