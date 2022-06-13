using System;

namespace Part2_Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int s = 0;
            if (a < b)
            {
                for(int i = a; i <= b; i++)
                {
                    if (i % 4 == 0)
                    {
                        s += i;
                    }
                }
                Console.WriteLine(s);
            }
            else
            {
                for (int i = b; i <= a; i++)
                {
                    if (i % 4 == 0)
                    {
                        s += i;
                    }
                }
                Console.WriteLine(s);
            }
        }
    }
}
