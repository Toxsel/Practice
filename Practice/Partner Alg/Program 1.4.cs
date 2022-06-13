using System;

namespace Part2_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = a;
            int c = 0;
            double d = 0;
            int e = 0;
            while (a>0)
            {    
                e = a%10;
                a = a/10;
                c +=1;
            }
            while (b>0){    
                d += (b%10)*Math.Pow(10,c-1);
                c = c - 1;
                b = b/10;
            }
            Console.WriteLine(d);

        }
    }
}
